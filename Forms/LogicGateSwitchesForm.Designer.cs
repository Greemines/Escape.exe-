namespace EscapeExe
{
    partial class LogicGateSwitchesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRoom = new Label();
            lblPlayer = new Label();
            lblTime = new Label();
            progressTime = new ProgressBar();
            lblInstruction = new Label();
            panelL1 = new Panel();
            panelL2 = new Panel();
            panelL3 = new Panel();
            lblL1 = new Label();
            lblL2 = new Label();
            lblL3 = new Label();
            lblSwitches = new Label();
            chkA = new CheckBox();
            chkB = new CheckBox();
            chkC = new CheckBox();
            chkD = new CheckBox();
            btnSubmit = new Button();
            lblMessage = new Label();
            btnHint = new Button();
            lblDigits = new Label();
            SuspendLayout();

            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblRoom.ForeColor = Color.FromArgb(0, 255, 156);
            lblRoom.Location = new Point(30, 20);
            lblRoom.Name = "lblRoom";
            lblRoom.Text = "ROOM 4 - LOGIC GATE SWITCHES";

            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Consolas", 10F);
            lblPlayer.ForeColor = Color.FromArgb(200, 200, 200);
            lblPlayer.Location = new Point(32, 55);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Text = "Player:";

            lblTime.Font = new Font("Consolas", 20F, FontStyle.Bold);
            lblTime.ForeColor = Color.FromArgb(0, 255, 156);
            lblTime.Location = new Point(620, 18);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(150, 40);
            lblTime.Text = "15:00";
            lblTime.TextAlign = ContentAlignment.MiddleRight;

            progressTime.Location = new Point(30, 90);
            progressTime.Name = "progressTime";
            progressTime.Size = new Size(740, 12);

            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Consolas", 11F);
            lblInstruction.ForeColor = Color.FromArgb(200, 200, 200);
            lblInstruction.Location = new Point(30, 118);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Text = "Set the four switches so that all three security lamps turn green:";

            panelL1.BackColor = Color.FromArgb(255, 85, 85);
            panelL1.BorderStyle = BorderStyle.FixedSingle;
            panelL1.Location = new Point(60, 160);
            panelL1.Name = "panelL1";
            panelL1.Size = new Size(30, 30);

            panelL2.BackColor = Color.FromArgb(255, 85, 85);
            panelL2.BorderStyle = BorderStyle.FixedSingle;
            panelL2.Location = new Point(60, 210);
            panelL2.Name = "panelL2";
            panelL2.Size = new Size(30, 30);

            panelL3.BackColor = Color.FromArgb(255, 85, 85);
            panelL3.BorderStyle = BorderStyle.FixedSingle;
            panelL3.Location = new Point(60, 260);
            panelL3.Name = "panelL3";
            panelL3.Size = new Size(30, 30);

            lblL1.AutoSize = true;
            lblL1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblL1.ForeColor = Color.FromArgb(0, 255, 156);
            lblL1.Location = new Point(105, 162);
            lblL1.Name = "lblL1";
            lblL1.Text = "L1 =";

            lblL2.AutoSize = true;
            lblL2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblL2.ForeColor = Color.FromArgb(0, 255, 156);
            lblL2.Location = new Point(105, 212);
            lblL2.Name = "lblL2";
            lblL2.Text = "L2 =";

            lblL3.AutoSize = true;
            lblL3.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblL3.ForeColor = Color.FromArgb(0, 255, 156);
            lblL3.Location = new Point(105, 262);
            lblL3.Name = "lblL3";
            lblL3.Text = "L3 =";

            lblSwitches.AutoSize = true;
            lblSwitches.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblSwitches.ForeColor = Color.FromArgb(200, 200, 200);
            lblSwitches.Location = new Point(560, 140);
            lblSwitches.Name = "lblSwitches";
            lblSwitches.Text = "SWITCHES";

            chkA.AutoSize = true;
            chkA.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA.ForeColor = Color.FromArgb(0, 255, 156);
            chkA.Location = new Point(560, 170);
            chkA.Name = "chkA";
            chkA.TabIndex = 0;
            chkA.Text = "A";
            chkA.CheckedChanged += chkSwitch_CheckedChanged;

            chkB.AutoSize = true;
            chkB.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB.ForeColor = Color.FromArgb(0, 255, 156);
            chkB.Location = new Point(560, 205);
            chkB.Name = "chkB";
            chkB.TabIndex = 1;
            chkB.Text = "B";
            chkB.CheckedChanged += chkSwitch_CheckedChanged;

            chkC.AutoSize = true;
            chkC.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkC.ForeColor = Color.FromArgb(0, 255, 156);
            chkC.Location = new Point(560, 240);
            chkC.Name = "chkC";
            chkC.TabIndex = 2;
            chkC.Text = "C";
            chkC.CheckedChanged += chkSwitch_CheckedChanged;

            chkD.AutoSize = true;
            chkD.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkD.ForeColor = Color.FromArgb(0, 255, 156);
            chkD.Location = new Point(560, 275);
            chkD.Name = "chkD";
            chkD.TabIndex = 3;
            chkD.Text = "D";
            chkD.CheckedChanged += chkSwitch_CheckedChanged;

            btnSubmit.BackColor = Color.FromArgb(22, 27, 34);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(0, 255, 156);
            btnSubmit.Location = new Point(310, 315);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 45);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "UNLOCK";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;

            lblMessage.Font = new Font("Consolas", 11F);
            lblMessage.ForeColor = Color.FromArgb(255, 170, 60);
            lblMessage.Location = new Point(0, 367);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(800, 25);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            btnHint.BackColor = Color.FromArgb(22, 27, 34);
            btnHint.FlatAppearance.BorderColor = Color.FromArgb(255, 170, 60);
            btnHint.FlatStyle = FlatStyle.Flat;
            btnHint.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnHint.ForeColor = Color.FromArgb(255, 170, 60);
            btnHint.Location = new Point(30, 400);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(140, 40);
            btnHint.TabIndex = 5;
            btnHint.Text = "HINT";
            btnHint.UseVisualStyleBackColor = false;

            lblDigits.Font = new Font("Consolas", 13F, FontStyle.Bold);
            lblDigits.ForeColor = Color.FromArgb(0, 255, 156);
            lblDigits.Location = new Point(520, 405);
            lblDigits.Name = "lblDigits";
            lblDigits.Size = new Size(250, 30);
            lblDigits.Text = "Code: _ _ _ _ _";
            lblDigits.TextAlign = ContentAlignment.MiddleRight;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(800, 460);
            Controls.Add(lblRoom);
            Controls.Add(lblPlayer);
            Controls.Add(lblTime);
            Controls.Add(progressTime);
            Controls.Add(lblInstruction);
            Controls.Add(panelL1);
            Controls.Add(panelL2);
            Controls.Add(panelL3);
            Controls.Add(lblL1);
            Controls.Add(lblL2);
            Controls.Add(lblL3);
            Controls.Add(lblSwitches);
            Controls.Add(chkA);
            Controls.Add(chkB);
            Controls.Add(chkC);
            Controls.Add(chkD);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(btnHint);
            Controls.Add(lblDigits);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LogicGateSwitchesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape.exe - Room 4";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRoom;
        private Label lblPlayer;
        private Label lblTime;
        private ProgressBar progressTime;
        private Label lblInstruction;
        private Panel panelL1;
        private Panel panelL2;
        private Panel panelL3;
        private Label lblL1;
        private Label lblL2;
        private Label lblL3;
        private Label lblSwitches;
        private CheckBox chkA;
        private CheckBox chkB;
        private CheckBox chkC;
        private CheckBox chkD;
        private Button btnSubmit;
        private Label lblMessage;
        private Button btnHint;
        private Label lblDigits;
    }
}