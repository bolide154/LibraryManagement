namespace WinForm
{
    partial class MainGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiTypeOfBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAuthor,
            this.mnuBook});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAuthor
            // 
            this.mnuAuthor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiInfor});
            this.mnuAuthor.Name = "mnuAuthor";
            this.mnuAuthor.Size = new System.Drawing.Size(56, 20);
            this.mnuAuthor.Text = "Author";
            // 
            // mnuiInfor
            // 
            this.mnuiInfor.Name = "mnuiInfor";
            this.mnuiInfor.Size = new System.Drawing.Size(137, 22);
            this.mnuiInfor.Text = "Information";
            this.mnuiInfor.Click += new System.EventHandler(this.mnuiInfor_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiTypeOfBook});
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Size = new System.Drawing.Size(46, 20);
            this.mnuBook.Text = "Book";
            // 
            // mnuiTypeOfBook
            // 
            this.mnuiTypeOfBook.Name = "mnuiTypeOfBook";
            this.mnuiTypeOfBook.Size = new System.Drawing.Size(152, 22);
            this.mnuiTypeOfBook.Text = "Type Of Book";
            this.mnuiTypeOfBook.Click += new System.EventHandler(this.mnuiTypeOfBook_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 373);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthor;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuiInfor;
        private System.Windows.Forms.ToolStripMenuItem mnuiTypeOfBook;
    }
}