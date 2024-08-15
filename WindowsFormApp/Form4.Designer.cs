namespace WindowsFormApp
{
    partial class Form4
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
            grpAddPersonnel = new GroupBox();
            btnShowArchive = new Button();
            btnSave = new Button();
            btnClear = new Button();
            txtCity = new TextBox();
            txtIdNo = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpAddPersonnel.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddPersonnel
            // 
            grpAddPersonnel.Controls.Add(btnShowArchive);
            grpAddPersonnel.Controls.Add(btnSave);
            grpAddPersonnel.Controls.Add(btnClear);
            grpAddPersonnel.Controls.Add(txtCity);
            grpAddPersonnel.Controls.Add(txtIdNo);
            grpAddPersonnel.Controls.Add(txtFullName);
            grpAddPersonnel.Controls.Add(label3);
            grpAddPersonnel.Controls.Add(label2);
            grpAddPersonnel.Controls.Add(label1);
            grpAddPersonnel.Location = new Point(12, 12);
            grpAddPersonnel.Name = "grpAddPersonnel";
            grpAddPersonnel.Size = new Size(556, 282);
            grpAddPersonnel.TabIndex = 0;
            grpAddPersonnel.TabStop = false;
            grpAddPersonnel.Text = "PERSONNEL INFORMATION";
            // 
            // btnShowArchive
            // 
            btnShowArchive.Location = new Point(359, 224);
            btnShowArchive.Name = "btnShowArchive";
            btnShowArchive.Size = new Size(157, 29);
            btnShowArchive.TabIndex = 5;
            btnShowArchive.Text = "Show Archive";
            btnShowArchive.UseVisualStyleBackColor = true;
            btnShowArchive.Click += btnShowArchive_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(248, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(138, 224);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(138, 174);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(378, 27);
            txtCity.TabIndex = 2;
            // 
            // txtIdNo
            // 
            txtIdNo.Location = new Point(138, 122);
            txtIdNo.Name = "txtIdNo";
            txtIdNo.Size = new Size(378, 27);
            txtIdNo.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(138, 73);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(378, 27);
            txtFullName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 174);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 122);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Identity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 312);
            Controls.Add(grpAddPersonnel);
            Name = "Form4";
            Text = "Form4";
            grpAddPersonnel.ResumeLayout(false);
            grpAddPersonnel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddPersonnel;
        private TextBox txtCity;
        private TextBox txtIdNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnShowArchive;
        private Button btnSave;
        public TextBox txtFullName;
    }
}