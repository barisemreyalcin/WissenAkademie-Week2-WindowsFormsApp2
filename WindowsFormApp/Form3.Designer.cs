namespace WindowsFormApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStartGame = new Button();
            label1 = new Label();
            txtEnteredNumber = new TextBox();
            btnGuess = new Button();
            lblInfo = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(40, 29);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(600, 64);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 113);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter a number between 0 - 100";
            // 
            // txtEnteredNumber
            // 
            txtEnteredNumber.Location = new Point(310, 110);
            txtEnteredNumber.Name = "txtEnteredNumber";
            txtEnteredNumber.Size = new Size(330, 27);
            txtEnteredNumber.TabIndex = 2;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(40, 165);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(600, 54);
            btnGuess.TabIndex = 3;
            btnGuess.Text = "Guess the Number";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(40, 274);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 20);
            lblInfo.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(40, 349);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(600, 29);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(285, 274);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 436);
            Controls.Add(lblMsg);
            Controls.Add(progressBar1);
            Controls.Add(lblInfo);
            Controls.Add(btnGuess);
            Controls.Add(txtEnteredNumber);
            Controls.Add(label1);
            Controls.Add(btnStartGame);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartGame;
        private Label label1;
        private TextBox txtEnteredNumber;
        private Button btnGuess;
        private Label lblInfo;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lblMsg;
    }
}