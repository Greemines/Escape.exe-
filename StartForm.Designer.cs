namespace EscapeExe
{
    partial class StartForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            btnPlay = new Button();
            btnLeaderboard = new Button();
            btnExit = new Button();
            SuspendLayout();

            lblTitle.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 255, 156);
            lblTitle.Location = new Point(0, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 70);
            lblTitle.Text = "Escape.exe";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitle.Font = new Font("Consolas", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 200, 200);
            lblSubtitle.Location = new Point(0, 115);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(800, 25);
            lblSubtitle.Text = "Trapped inside a locked cyber vault. Crack the codes, beat the clock, find the exit.";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            lblName.AutoSize = true;
            lblName.Font = new Font("Consolas", 12F);
            lblName.ForeColor = Color.FromArgb(0, 255, 156);
            lblName.Location = new Point(250, 180);
            lblName.Name = "lblName";
            lblName.Text = "> enter player name:";

            txtName.BackColor = Color.FromArgb(22, 27, 34);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Consolas", 14F);
            txtName.ForeColor = Color.FromArgb(0, 255, 156);
            txtName.Location = new Point(250, 210);
            txtName.MaxLength = 20;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 30);
            txtName.TabIndex = 0;

            btnPlay.BackColor = Color.FromArgb(22, 27, 34);
            btnPlay.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnPlay.ForeColor = Color.FromArgb(0, 255, 156);
            btnPlay.Location = new Point(310, 270);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(180, 45);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;

            btnLeaderboard.BackColor = Color.FromArgb(22, 27, 34);
            btnLeaderboard.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnLeaderboard.FlatStyle = FlatStyle.Flat;
            btnLeaderboard.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnLeaderboard.ForeColor = Color.FromArgb(0, 255, 156);
            btnLeaderboard.Location = new Point(310, 325);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(180, 45);
            btnLeaderboard.TabIndex = 2;
            btnLeaderboard.Text = "LEADERBOARD";
            btnLeaderboard.UseVisualStyleBackColor = false;
            btnLeaderboard.Click += btnLeaderboard_Click;

            btnExit.BackColor = Color.FromArgb(22, 27, 34);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 156);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(0, 255, 156);
            btnExit.Location = new Point(310, 380);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;

            AcceptButton = btnPlay;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(800, 460);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnPlay);
            Controls.Add(btnLeaderboard);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape.exe - The Cyber Vault";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblName;
        private TextBox txtName;
        private Button btnPlay;
        private Button btnLeaderboard;
        private Button btnExit;
    }
}