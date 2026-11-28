namespace EscapeExe
{
    public partial class AlgorithmTraceForm : Form
    {
        private int[] numbers = new int[4];
        private int[] answer = new int[4];

        public AlgorithmTraceForm()
        {
            InitializeComponent();
            Load += AlgorithmTraceForm_Load;
            FormClosed += AlgorithmTraceForm_FormClosed;
        }

        private void AlgorithmTraceForm_Load(object? sender, EventArgs e)
        {
            numbers = PuzzleBank.GenerateTraceArray();
            answer = PuzzleBank.BubbleSortOnePass(numbers);
            lblArray.Text = "[" + string.Join(", ", numbers) + "]";

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
                lblMessage.Text = "Please type the 4 numbers first.";
                txtAnswer.Focus();
                return;
            }

            string[] parts = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 4)
            {
                lblMessage.Text = "Please type exactly 4 numbers.";
                txtAnswer.SelectAll();
                txtAnswer.Focus();
                return;
            }

            int[] typed = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(parts[i], out typed[i]))
                {
                    lblMessage.Text = "Numbers only, please.";
                    txtAnswer.SelectAll();
                    txtAnswer.Focus();
                    return;
                }
            }

            if (typed.SequenceEqual(answer))
            {
                GameSession.RoomsSolved++;
                UpdateDigits();
                int digit = GameSession.Digits[GameSession.RoomsSolved - 1];
                MessageBox.Show("Correct! The algorithm is traced.\nCode digit: " + digit, "Room 5 cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoTo(new FinalRoomForm());
            }
            else
            {
                lblMessage.Text = "Wrong order. Try again.";
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

        private void AlgorithmTraceForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
        }
    }
}