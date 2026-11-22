namespace EscapeExe
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name to start.", "Name required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            GameSession.StartNewGame(name);

            BinaryDoorForm room1 = new BinaryDoorForm();
            room1.FormClosed += (s, args) => Application.Exit();
            room1.Show();
            Hide();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm board = new LeaderboardForm();
            board.FormClosed += (s, args) => Show();
            board.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}