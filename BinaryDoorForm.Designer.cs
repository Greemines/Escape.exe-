namespace EscapeExe
{
    partial class BinaryDoorForm
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
            lblBinary = new Label();
            txtAnswer = new TextBox();
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
            lblRoom.Text = "ROOM 1 - BINARY DOOR";

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
            lblInstruction.Location = new Point(30, 125);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Text = "Convert the binary number on the door into a decimal number:";

            lblBinary.BackColor = Color.FromArgb(22, 27, 34);
            lblBinary.BorderStyle = BorderStyle.FixedSingle;
            lblBinary.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblBinary.ForeColor = Color.FromArgb(0, 255, 156);
            lblBinary.Location = new Point(250, 155);
            lblBinary.Name = "lblBinary";
            lblBinary.Size = new Size(300, 80);
            lblBinary.Text = "0000";
            lblBinary.TextAlign = ContentAlignment.MiddleCenter;

            txtAnswer.BackColor = Color.FromArgb(22, 27, 34);
            txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtAnswer.Font = new Font("Consolas", 16F);
            txtAnswer.ForeColor = Color.FromArgb(0, 255, 156);
            txtAnswer.Location = new Point(300, 250);
            txtAnswer.MaxLength = 3;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(200, 33);
            txtAnswer.TabIndex = 0;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            txtAnswer.KeyDown += txtAnswer_KeyDown;

            btnSubmit.BackColor = Color.FromArgb(22, 27, 34);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(0, 255, 156);
            btnSubmit.Location = new Point(310, 300);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 45);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;

            lblMessage.Font = new Font("Consolas", 11F);
            lblMessage.ForeColor = Color.FromArgb(255, 170, 60);
            lblMessage.Location = new Point(0, 355);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(800, 25);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            btnHint.BackColor = Color.FromArgb(22, 27, 34);
            btnHint.FlatAppearance.BorderColor = Color.FromArgb(255, 170, 60);
            btnHint.FlatStyle = FlatStyle.Flat;
            btnHint.Font = new Font("Consolas", 11F, FontStyle.Bold);
            btnHint.ForeColor = Color.FromArgb(255, 170, 60);
            btnHint.Location = new Point(30, 395);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(140, 40);
            btnHint.TabIndex = 2;
            btnHint.Text = "HINT";
            btnHint.UseVisualStyleBackColor = false;

            lblDigits.Font = new Font("Consolas", 13F, FontStyle.Bold);
            lblDigits.ForeColor = Color.FromArgb(0, 255, 156);
            lblDigits.Location = new Point(520, 400);
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
            Controls.Add(lblBinary);
            Controls.Add(txtAnswer);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(btnHint);
            Controls.Add(lblDigits);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BinaryDoorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape.exe - Room 1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRoom;
        private Label lblPlayer;
        private Label lblTime;
        private ProgressBar progressTime;
        private Label lblInstruction;
        private Label lblBinary;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Label lblMessage;
        private Button btnHint;
        private Label lblDigits;
    }
}