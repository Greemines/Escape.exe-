namespace EscapeExe
{
    partial class AlgorithmTraceForm
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
            lblArray = new Label();
            lblFormat = new Label();
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
            lblRoom.Text = "ROOM 5 - ALGORITHM TRACE";

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
            lblInstruction.Text = "Write the array exactly as it looks after ONE pass of bubble sort:";

            lblArray.BackColor = Color.FromArgb(22, 27, 34);
            lblArray.BorderStyle = BorderStyle.FixedSingle;
            lblArray.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblArray.ForeColor = Color.FromArgb(0, 255, 156);
            lblArray.Location = new Point(200, 148);
            lblArray.Name = "lblArray";
            lblArray.Size = new Size(400, 75);
            lblArray.Text = "[ ]";
            lblArray.TextAlign = ContentAlignment.MiddleCenter;

            lblFormat.Font = new Font("Consolas", 11F, FontStyle.Italic);
            lblFormat.ForeColor = Color.FromArgb(255, 170, 60);
            lblFormat.Location = new Point(0, 232);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(800, 25);
            lblFormat.Text = "Type the 4 numbers separated by spaces, for example: 1 4 2 5";
            lblFormat.TextAlign = ContentAlignment.MiddleCenter;

            txtAnswer.BackColor = Color.FromArgb(22, 27, 34);
            txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtAnswer.Font = new Font("Consolas", 16F);
            txtAnswer.ForeColor = Color.FromArgb(0, 255, 156);
            txtAnswer.Location = new Point(275, 268);
            txtAnswer.MaxLength = 20;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(250, 33);
            txtAnswer.TabIndex = 0;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            txtAnswer.KeyDown += txtAnswer_KeyDown;

            btnSubmit.BackColor = Color.FromArgb(22, 27, 34);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(0, 255, 156);
            btnSubmit.Location = new Point(310, 315);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 45);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "SUBMIT";
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
            btnHint.TabIndex = 2;
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
            Controls.Add(lblArray);
            Controls.Add(lblFormat);
            Controls.Add(txtAnswer);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(btnHint);
            Controls.Add(lblDigits);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AlgorithmTraceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape.exe - Room 5";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRoom;
        private Label lblPlayer;
        private Label lblTime;
        private ProgressBar progressTime;
        private Label lblInstruction;
        private Label lblArray;
        private Label lblFormat;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Label lblMessage;
        private Button btnHint;
        private Label lblDigits;
    }
}