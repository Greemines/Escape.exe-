namespace EscapeExe
{
    public partial class CaesarCipherForm : Form
    {
        private string answer = "";
        private int shift;

        public CaesarCipherForm()
        {
            InitializeComponent();
            Load += CaesarCipherForm_Load;
            FormClosed += CaesarCipherForm_FormClosed;
        }

        private void CaesarCipherForm_Load(object? sender, EventArgs e)
        {
            answer = PuzzleBank.GetCipherWord();
            shift = PuzzleBank.GetCipherShift();
            lblCipher.Text = PuzzleBank.CaesarEncode(answer, shift);

            if (shift == 1)
            {
                lblClue.Text = "Clue: each letter was shifted forward by 1 place.";
            }
            else
            {
                lblClue.Text = "Clue: each letter was shifted forward by " + shift + " places.";
            }

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
            string input = txtAnswer.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(input))
            {
                lblMessage.Text = "Please type the decoded word first.";
                txtAnswer.Focus();
                return;
            }

            if (!input.All(char.IsLetter))
            {
                lblMessage.Text = "Letters only, please.";
                txtAnswer.SelectAll();
                txtAnswer.Focus();
                return;
            }

            if (input == answer)
            {
                GameSession.RoomsSolved++;
                UpdateDigits();
                int digit = GameSession.Digits[GameSession.RoomsSolved - 1];
                MessageBox.Show("Correct! The cipher is cracked.\nCode digit: " + digit, "Room 3 cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoTo(new LogicGateSwitchesForm());
            }
            else
            {
                lblMessage.Text = "Wrong word. Try again.";
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

        private void CaesarCipherForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
        }
    }
}