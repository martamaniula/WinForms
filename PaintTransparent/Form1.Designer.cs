namespace Painttransparent
{
    partial class Drawing_transparent
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sposob_rysowania = new System.Windows.Forms.GroupBox();
            this.Frame_color = new System.Windows.Forms.Button();
            this.Fill_color = new System.Windows.Forms.Button();
            this.Wypełnienie = new System.Windows.Forms.ComboBox();
            this.Rysowanie = new System.Windows.Forms.GroupBox();
            this.Spray = new System.Windows.Forms.Button();
            this.Elipsa = new System.Windows.Forms.Button();
            this.Prostokąt = new System.Windows.Forms.Button();
            this.Linia = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sposob_rysowania.SuspendLayout();
            this.Rysowanie.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.Sposob_rysowania);
            this.splitContainer1.Panel2.Controls.Add(this.Rysowanie);
            this.splitContainer1.Size = new System.Drawing.Size(1471, 877);
            this.splitContainer1.SplitterDistance = 986;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 877);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.Move += new System.EventHandler(this.pictureBox1_Move);
            // 
            // Sposob_rysowania
            // 
            this.Sposob_rysowania.Controls.Add(this.Frame_color);
            this.Sposob_rysowania.Controls.Add(this.Fill_color);
            this.Sposob_rysowania.Controls.Add(this.Wypełnienie);
            this.Sposob_rysowania.Location = new System.Drawing.Point(42, 488);
            this.Sposob_rysowania.Name = "Sposob_rysowania";
            this.Sposob_rysowania.Size = new System.Drawing.Size(340, 292);
            this.Sposob_rysowania.TabIndex = 3;
            this.Sposob_rysowania.TabStop = false;
            this.Sposob_rysowania.Text = "Sposób rysowania";
            // 
            // Frame_color
            // 
            this.Frame_color.BackColor = System.Drawing.Color.White;
            this.Frame_color.Location = new System.Drawing.Point(195, 159);
            this.Frame_color.Name = "Frame_color";
            this.Frame_color.Size = new System.Drawing.Size(102, 104);
            this.Frame_color.TabIndex = 2;
            this.Frame_color.UseVisualStyleBackColor = false;
            this.Frame_color.Click += new System.EventHandler(this.Frame_color_Click);
            // 
            // Fill_color
            // 
            this.Fill_color.BackColor = System.Drawing.Color.Black;
            this.Fill_color.Location = new System.Drawing.Point(30, 159);
            this.Fill_color.Name = "Fill_color";
            this.Fill_color.Size = new System.Drawing.Size(106, 104);
            this.Fill_color.TabIndex = 1;
            this.Fill_color.UseVisualStyleBackColor = false;
            this.Fill_color.Click += new System.EventHandler(this.Fill_color_Click);
            // 
            // Wypełnienie
            // 
            this.Wypełnienie.FormattingEnabled = true;
            this.Wypełnienie.Items.AddRange(new object[] {
            "Bez wypełnienia",
            "Z wypełnieniem"});
            this.Wypełnienie.Location = new System.Drawing.Point(6, 69);
            this.Wypełnienie.Name = "Wypełnienie";
            this.Wypełnienie.Size = new System.Drawing.Size(328, 39);
            this.Wypełnienie.TabIndex = 0;
            this.Wypełnienie.Text = "Bez wypełnienia";
            this.Wypełnienie.SelectedIndexChanged += new System.EventHandler(this.Wypełnienie_SelectedIndexChanged);
            // 
            // Rysowanie
            // 
            this.Rysowanie.Controls.Add(this.Spray);
            this.Rysowanie.Controls.Add(this.Elipsa);
            this.Rysowanie.Controls.Add(this.Prostokąt);
            this.Rysowanie.Controls.Add(this.Linia);
            this.Rysowanie.Location = new System.Drawing.Point(42, 73);
            this.Rysowanie.Name = "Rysowanie";
            this.Rysowanie.Size = new System.Drawing.Size(340, 372);
            this.Rysowanie.TabIndex = 0;
            this.Rysowanie.TabStop = false;
            this.Rysowanie.Text = "Rysowanie";
            // 
            // Spray
            // 
            this.Spray.BackgroundImage = global::Painttransparent.Properties.Resources.Spray;
            this.Spray.Location = new System.Drawing.Point(70, 297);
            this.Spray.Name = "Spray";
            this.Spray.Size = new System.Drawing.Size(207, 47);
            this.Spray.TabIndex = 3;
            this.Spray.UseVisualStyleBackColor = true;
            this.Spray.Click += new System.EventHandler(this.Spray_Click);
            // 
            // Elipsa
            // 
            this.Elipsa.BackgroundImage = global::Painttransparent.Properties.Resources.Ellipse;
            this.Elipsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Elipsa.Location = new System.Drawing.Point(70, 216);
            this.Elipsa.Name = "Elipsa";
            this.Elipsa.Size = new System.Drawing.Size(207, 53);
            this.Elipsa.TabIndex = 2;
            this.Elipsa.UseVisualStyleBackColor = true;
            this.Elipsa.Click += new System.EventHandler(this.Elipsa_Click);
            // 
            // Prostokąt
            // 
            this.Prostokąt.BackgroundImage = global::Painttransparent.Properties.Resources.Rectangle;
            this.Prostokąt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prostokąt.Location = new System.Drawing.Point(70, 145);
            this.Prostokąt.Name = "Prostokąt";
            this.Prostokąt.Size = new System.Drawing.Size(207, 48);
            this.Prostokąt.TabIndex = 1;
            this.Prostokąt.UseVisualStyleBackColor = true;
            this.Prostokąt.Click += new System.EventHandler(this.Prostokąt_Click);
            // 
            // Linia
            // 
            this.Linia.BackgroundImage = global::Painttransparent.Properties.Resources.Line;
            this.Linia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Linia.Location = new System.Drawing.Point(70, 65);
            this.Linia.Name = "Linia";
            this.Linia.Size = new System.Drawing.Size(207, 58);
            this.Linia.TabIndex = 0;
            this.Linia.UseVisualStyleBackColor = true;
            this.Linia.Click += new System.EventHandler(this.Linia_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1471, 49);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(198, 46);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colorDialog1.FullOpen = true;
            // 
            // Drawing_transparent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1471, 877);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Drawing_transparent";
            this.Text = "Drawing_transparent";
            this.Move += new System.EventHandler(this.Drawing_transparent_Move);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sposob_rysowania.ResumeLayout(false);
            this.Rysowanie.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Rysowanie;
        private System.Windows.Forms.Button Elipsa;
        private System.Windows.Forms.Button Prostokąt;
        private System.Windows.Forms.Button Linia;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Sposob_rysowania;
        private System.Windows.Forms.ComboBox Wypełnienie;
        private System.Windows.Forms.Button Frame_color;
        private System.Windows.Forms.Button Fill_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Spray;
    }
}

