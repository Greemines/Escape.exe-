namespace EscapeExe
{
    public partial class MissingKeywordForm : Form
    {
        private KeywordQuestion question = null!;

        public MissingKeywordForm()
        {
            InitializeComponent();
            Load += MissingKeywordForm_Load;
            FormClosed += MissingKeywordForm_FormClosed;
        }

        private void MissingKeywordForm_Load(object? sender, EventArgs e)
        {
            question = PuzzleBank.GetKeywordQuestion();
            lblCode.Text = question.Line;
            cmbKeyword.Items.Clear();
            cmbKeyword.Items.AddRange(PuzzleBank.ShuffleOptions(question.Options));

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbKeyword.SelectedItem == null)
            {
                lblMessage.Text = "Please choose a keyword first.";
                return;
            }

            string chosen = cmbKeyword.SelectedItem.ToString() ?? "";

            if (chosen == question.Answer)
            {
                GameSession.RoomsSolved++;
                UpdateDigits();
                int digit = GameSession.Digits[GameSession.RoomsSolved - 1];
                MessageBox.Show("Correct! The door unlocks.\nCode digit: " + digit, "Room 2 cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoTo(new CaesarCipherForm());
            }
            else
            {
                lblMessage.Text = "Wrong keyword. Try again.";
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

        private void MissingKeywordForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
        }
    }
}