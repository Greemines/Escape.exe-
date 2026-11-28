namespace EscapeExe
{
    public partial class FinalRoomForm : Form
    {
        private string exitCode = "";

        public FinalRoomForm()
        {
            InitializeComponent();
            Load += FinalRoomForm_Load;
            FormClosed += FinalRoomForm_FormClosed;
        }

        private void FinalRoomForm_Load(object? sender, EventArgs e)
        {
            exitCode = string.Concat(GameSession.Digits);
            ShowCollectedDigits();

            lblPlayer.Text = "Player: " + GameSession.PlayerName;
            progressTime.Maximum = GameSession.TotalSeconds;
            UpdateTime();

            GameSession.TimeChanged += UpdateTime;
            GameSession.TimeUp += OnTimeUp;
        }

        private void ShowCollectedDigits()
        {
            string text = "";
            for (int i = 0; i < GameSession.Digits.Length; i++)
            {
                if (i < GameSession.RoomsSolved)
                {
                    text += GameSession.Digits[i] + " ";
                }
                else
                {
                    text += "_ ";
                }
            }
            lblCollected.Text = text.Trim();
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

        private void txtCode_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckCode();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckCode();
        }

        private void CheckCode()
        {
            string input = txtCode.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                lblMessage.Text = "Please type the 5-digit exit code first.";
                txtCode.Focus();
                return;
            }

            if (input.Length != 5 || !input.All(char.IsDigit))
            {
                lblMessage.Text = "The exit code must be exactly 5 digits.";
                txtCode.SelectAll();
                txtCode.Focus();
                return;
            }

            if (input == exitCode)
            {
                GameSession.StopTimer();
                GameSession.RoomsSolved++;
                MessageBox.Show("ACCESS GRANTED!\nYou escaped the Cyber Vault!", "Escaped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoTo(new ResultForm());
            }
            else
            {
                lblMessage.Text = "ACCESS DENIED. Wrong code. Try again.";
                txtCode.SelectAll();
                txtCode.Focus();
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

        private void FinalRoomForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
        }
    }
}