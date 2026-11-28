namespace EscapeExe
{
    public partial class LogicGateSwitchesForm : Form
    {
        private LogicCircuit circuit = null!;
        private readonly Color lampOn = Color.FromArgb(0, 220, 130);
        private readonly Color lampOff = Color.FromArgb(255, 85, 85);

        public LogicGateSwitchesForm()
        {
            InitializeComponent();
            Load += LogicGateSwitchesForm_Load;
            FormClosed += LogicGateSwitchesForm_FormClosed;
        }

        private void LogicGateSwitchesForm_Load(object? sender, EventArgs e)
        {
            circuit = PuzzleBank.GetLogicCircuit();
            lblL1.Text = circuit.LampText[0];
            lblL2.Text = circuit.LampText[1];
            lblL3.Text = circuit.LampText[2];
            UpdateLamps();

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

        private bool[] GetLampStates()
        {
            bool a = chkA.Checked;
            bool b = chkB.Checked;
            bool c = chkC.Checked;
            bool d = chkD.Checked;

            bool[] states = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                states[i] = circuit.Lamps[i](a, b, c, d);
            }
            return states;
        }

        private void UpdateLamps()
        {
            bool[] states = GetLampStates();
            panelL1.BackColor = states[0] ? lampOn : lampOff;
            panelL2.BackColor = states[1] ? lampOn : lampOff;
            panelL3.BackColor = states[2] ? lampOn : lampOff;
        }

        private void chkSwitch_CheckedChanged(object? sender, EventArgs e)
        {
            if (circuit == null)
            {
                return;
            }
            UpdateLamps();
            lblMessage.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool[] states = GetLampStates();

            if (states[0] && states[1] && states[2])
            {
                GameSession.RoomsSolved++;
                UpdateDigits();
                int digit = GameSession.Digits[GameSession.RoomsSolved - 1];
                MessageBox.Show("Correct! All lamps are green.\nCode digit: " + digit, "Room 4 cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoTo(new AlgorithmTraceForm());
            }
            else
            {
                lblMessage.Text = "Not all lamps are green. Try again.";
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

        private void LogicGateSwitchesForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GameSession.TimeChanged -= UpdateTime;
            GameSession.TimeUp -= OnTimeUp;
        }
    }
}