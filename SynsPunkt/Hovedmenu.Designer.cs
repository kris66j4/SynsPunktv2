namespace SynsPunkt
{
    partial class Hovedmenu
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
            this.vareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opretVareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletVareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletVareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opretKundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletKundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletKundeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vareToolStripMenuItem,
            this.kundeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vareToolStripMenuItem
            // 
            this.vareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opretVareToolStripMenuItem,
            this.sletVareToolStripMenuItem,
            this.sletVareToolStripMenuItem1});
            this.vareToolStripMenuItem.Name = "vareToolStripMenuItem";
            this.vareToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.vareToolStripMenuItem.Text = "Vare";
            // 
            // opretVareToolStripMenuItem
            // 
            this.opretVareToolStripMenuItem.Name = "opretVareToolStripMenuItem";
            this.opretVareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opretVareToolStripMenuItem.Text = "Opret vare";
            this.opretVareToolStripMenuItem.Click += new System.EventHandler(this.opretVareToolStripMenuItem_Click);
            // 
            // sletVareToolStripMenuItem
            // 
            this.sletVareToolStripMenuItem.Name = "sletVareToolStripMenuItem";
            this.sletVareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sletVareToolStripMenuItem.Text = "Ændre vare";
            this.sletVareToolStripMenuItem.Click += new System.EventHandler(this.sletVareToolStripMenuItem_Click);
            // 
            // sletVareToolStripMenuItem1
            // 
            this.sletVareToolStripMenuItem1.Name = "sletVareToolStripMenuItem1";
            this.sletVareToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sletVareToolStripMenuItem1.Text = "Slet vare";
            this.sletVareToolStripMenuItem1.Click += new System.EventHandler(this.sletVareToolStripMenuItem1_Click);
            // 
            // kundeToolStripMenuItem
            // 
            this.kundeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opretKundeToolStripMenuItem,
            this.sletKundeToolStripMenuItem,
            this.sletKundeToolStripMenuItem1});
            this.kundeToolStripMenuItem.Name = "kundeToolStripMenuItem";
            this.kundeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.kundeToolStripMenuItem.Text = "Kunde";
            // 
            // opretKundeToolStripMenuItem
            // 
            this.opretKundeToolStripMenuItem.Name = "opretKundeToolStripMenuItem";
            this.opretKundeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.opretKundeToolStripMenuItem.Text = "Opret kunde";
            this.opretKundeToolStripMenuItem.Click += new System.EventHandler(this.opretKundeToolStripMenuItem_Click);
            // 
            // sletKundeToolStripMenuItem
            // 
            this.sletKundeToolStripMenuItem.Name = "sletKundeToolStripMenuItem";
            this.sletKundeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sletKundeToolStripMenuItem.Text = "Ændre kunde";
            this.sletKundeToolStripMenuItem.Click += new System.EventHandler(this.sletKundeToolStripMenuItem_Click);
            // 
            // sletKundeToolStripMenuItem1
            // 
            this.sletKundeToolStripMenuItem1.Name = "sletKundeToolStripMenuItem1";
            this.sletKundeToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.sletKundeToolStripMenuItem1.Text = "Slet kunde";
            this.sletKundeToolStripMenuItem1.Click += new System.EventHandler(this.sletKundeToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hent alle varer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 360);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rådgivning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 360);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hent ordre i bestemt periode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(242, 360);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 63);
            this.button4.TabIndex = 8;
            this.button4.Text = "Udprint alle varer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Varenr\tGruppe\tMærke   Type    Stk.    Pris"});
            this.listBox1.Location = new System.Drawing.Point(68, 25);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(662, 308);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 471);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hovedmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opretVareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletVareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opretKundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletKundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletVareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sletKundeToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

