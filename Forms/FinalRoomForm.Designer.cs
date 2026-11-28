namespace EscapeExe
{
    partial class FinalRoomForm
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
            lblCollected = new Label();
            txtCode = new TextBox();
            btnSubmit = new Button();
            lblMessage = new Label();
            lblNoHints = new Label();
            SuspendLayout();

            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblRoom.ForeColor = Color.FromArgb(0, 255, 156);
            lblRoom.Location = new Point(30, 20);
            lblRoom.Name = "lblRoom";
            lblRoom.Text = "FINAL ROOM - EXIT CODE";

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
            lblInstruction.Location = new Point(30, 120);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Text = "Enter the 5-digit exit code built from the digits you collected:";

            lblCollected.BackColor = Color.FromArgb(22, 27, 34);
            lblCollected.BorderStyle = BorderStyle.FixedSingle;
            lblCollected.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblCollected.ForeColor = Color.FromArgb(0, 255, 156);
            lblCollected.Location = new Point(200, 148);
            lblCollected.Name = "lblCollected";
            lblCollected.Size = new Size(400, 75);
            lblCollected.Text = "_ _ _ _ _";
            lblCollected.TextAlign = ContentAlignment.MiddleCenter;

            txtCode.BackColor = Color.FromArgb(22, 27, 34);
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Consolas", 20F, FontStyle.Bold);
            txtCode.ForeColor = Color.FromArgb(0, 255, 156);
            txtCode.Location = new Point(300, 250);
            txtCode.MaxLength = 5;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 39);
            txtCode.TabIndex = 0;
            txtCode.TextAlign = HorizontalAlignment.Center;
            txtCode.KeyDown += txtCode_KeyDown;

            btnSubmit.BackColor = Color.FromArgb(22, 27, 34);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(0, 255, 156);
            btnSubmit.Location = new Point(310, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 45);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "OPEN EXIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;

            lblMessage.Font = new Font("Consolas", 11F);
            lblMessage.ForeColor = Color.FromArgb(255, 170, 60);
            lblMessage.Location = new Point(0, 365);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(800, 25);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            lblNoHints.Font = new Font("Consolas", 10F, FontStyle.Italic);
            lblNoHints.ForeColor = Color.FromArgb(150, 150, 150);
            lblNoHints.Location = new Point(0, 410);
            lblNoHints.Name = "lblNoHints";
            lblNoHints.Size = new Size(800, 25);
            lblNoHints.Text = "No hints are allowed in the Final Room.";
            lblNoHints.TextAlign = ContentAlignment.MiddleCenter;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(800, 460);
            Controls.Add(lblRoom);
            Controls.Add(lblPlayer);
            Controls.Add(lblTime);
            Controls.Add(progressTime);
            Controls.Add(lblInstruction);
            Controls.Add(lblCollected);
            Controls.Add(txtCode);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(lblNoHints);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FinalRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape.exe - Final Room";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRoom;
        private Label lblPlayer;
        private Label lblTime;
        private ProgressBar progressTime;
        private Label lblInstruction;
        private Label lblCollected;
        private TextBox txtCode;
        private Button btnSubmit;
        private Label lblMessage;
        private Label lblNoHints;
    }
}