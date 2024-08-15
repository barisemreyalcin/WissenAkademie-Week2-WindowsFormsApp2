namespace WindowsFormApp
{
    partial class Form5
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
            lvPersonnel = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // lvPersonnel
            // 
            lvPersonnel.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvPersonnel.Dock = DockStyle.Fill;
            lvPersonnel.FullRowSelect = true;
            lvPersonnel.GridLines = true;
            lvPersonnel.Location = new Point(0, 0);
            lvPersonnel.Name = "lvPersonnel";
            lvPersonnel.Size = new Size(800, 450);
            lvPersonnel.TabIndex = 0;
            lvPersonnel.UseCompatibleStateImageBehavior = false;
            lvPersonnel.View = View.Details;
            lvPersonnel.DoubleClick += lvPersonnel_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Full Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Identity";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "City";
            columnHeader4.Width = 120;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvPersonnel);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvPersonnel;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}