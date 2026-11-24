namespace EscapeExe
{
    public partial class BinaryDoorForm : Form
    {
        private int answer;

        public BinaryDoorForm()
        {
            InitializeComponent();
            Load += BinaryDoorForm_Load;
            FormClosed += BinaryDoorForm_FormClosed;
        }

        private void BinaryDoorForm_Load(object? sender, EventArgs e)
        {
            answer = PuzzleBank.GenerateBinaryNumber();
            lblBinary.Text = PuzzleBank.ToFourBitBinary(answer);

            lblPlayer.Text = "Player: " + GameSession.PlayerName;
            progressTime.Maximum = GameSession.TotalSeconds;
            UpdateTime();
            UpdateDigits();

            GameSession.TimeChanged += UpdateTime;
            GameSession.TimeUp += OnTimeUp;
        }

        private void UpdateTime()
        {
            lblTime.Text = GameSession.FormatTime(GameSession.TimeLeft);
            progressTime.Value = Math.Clamp(GameSession.TimeLeft, 0, progressTime.Maximum);

            if (GameSession.TimeLeft <= 60)
            {
                lblTime.ForeColor = Color.FromArgb(255, 85, 85);
            }
            else
            {
                lblTime.ForeColor = Color.FromArgb(0, 255, 156);
            }
        }

        private void UpdateDigits()
        {
            string text = "Code:";
            for (int i = 0; i < GameSession.Digits.Length; i++)
            {
                if (i < GameSession.RoomsSolved)
                {
                    text += " " + GameSession.Digits[i];
                }
                else
                {
                    text += " _";
                }
            }
            lblDigits.Text = text;
        }

        private void txtAnswer_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            string input = txtAnswer.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                lblMessage.Text = "Please type a number first.";
                txtAnswer.Focus();
                return;
            }

            if (!int.TryParse(input, out int number))
            {
                lblMessage.Text = "Numbers only, please.";
                txtAnswer.SelectAll();
                txtAnswer.Focus();
                return;
            }

            if (number == answer)
            {
                GameSession.RoomsSolved++;
                UpdateDigits();
                int digit = GameSession.Digits[GameSession.RoomsSolved - 1];
                MessageBox.Show("Correct! The door unlocks.\nCode digit: " + digit, "Room 1 cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoTo(new MissingKeywordForm());
            }
            else
            {
                lblMessage.Text = "Wrong number. Try again.";
                txtAnswer.SelectAll();
                txtAnswer.Focus();
            }
        }

        private void OnTimeUp()
        {
            if (!Visible)
            {
                return;
            }
            GoTo(new ResultForm());
        }

        private void GoTo(Form next)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
            next.FormClosed += (s, args) => Application.Exit();
            next.Show();
            Hide();
        }

        private void BinaryDoorForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
        }
    }
}