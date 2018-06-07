namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aquivoToolStripMenuItem
            // 
            this.aquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex1ToolStripMenuItem,
            this.ex2ToolStripMenuItem,
            this.ex3ToolStripMenuItem,
            this.ex4ToolStripMenuItem,
            this.ex5ToolStripMenuItem,
            this.ex6ToolStripMenuItem,
            this.ex7ToolStripMenuItem});
            this.aquivoToolStripMenuItem.Name = "aquivoToolStripMenuItem";
            this.aquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aquivoToolStripMenuItem.Text = "Arquivo";
            this.aquivoToolStripMenuItem.Click += new System.EventHandler(this.aquivoToolStripMenuItem_Click);
            // 
            // ex1ToolStripMenuItem
            // 
            this.ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            this.ex1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex1ToolStripMenuItem.Text = "Ex1";
            this.ex1ToolStripMenuItem.Click += new System.EventHandler(this.teste1ToolStripMenuItem_Click);
            // 
            // ex2ToolStripMenuItem
            // 
            this.ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            this.ex2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex2ToolStripMenuItem.Text = "Ex2";
            this.ex2ToolStripMenuItem.Click += new System.EventHandler(this.teste2ToolStripMenuItem_Click);
            // 
            // ex3ToolStripMenuItem
            // 
            this.ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            this.ex3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex3ToolStripMenuItem.Text = "Ex3";
            this.ex3ToolStripMenuItem.Click += new System.EventHandler(this.ex3ToolStripMenuItem_Click);
            // 
            // ex4ToolStripMenuItem
            // 
            this.ex4ToolStripMenuItem.Name = "ex4ToolStripMenuItem";
            this.ex4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex4ToolStripMenuItem.Text = "Ex4";
            this.ex4ToolStripMenuItem.Click += new System.EventHandler(this.ex4ToolStripMenuItem_Click);
            // 
            // ex5ToolStripMenuItem
            // 
            this.ex5ToolStripMenuItem.Name = "ex5ToolStripMenuItem";
            this.ex5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex5ToolStripMenuItem.Text = "Ex5";
            this.ex5ToolStripMenuItem.Click += new System.EventHandler(this.ex5ToolStripMenuItem_Click);
            // 
            // ex6ToolStripMenuItem
            // 
            this.ex6ToolStripMenuItem.Name = "ex6ToolStripMenuItem";
            this.ex6ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex6ToolStripMenuItem.Text = "Ex6";
            this.ex6ToolStripMenuItem.Click += new System.EventHandler(this.ex6ToolStripMenuItem_Click);
            // 
            // ex7ToolStripMenuItem
            // 
            this.ex7ToolStripMenuItem.Name = "ex7ToolStripMenuItem";
            this.ex7ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex7ToolStripMenuItem.Text = "Ex7";
            this.ex7ToolStripMenuItem.Click += new System.EventHandler(this.ex7ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Exemplo Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex2ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ex3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex7ToolStripMenuItem;
    }
}

