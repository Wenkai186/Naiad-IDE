namespace NAIADIDE
{
    partial class NaiadIDE
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaiadIDE));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsButton5 = new System.Windows.Forms.ToolStripButton();
            this.tsButton6 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.saveXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.CanMessage = new System.Windows.Forms.ToolStripButton();
            this.IPAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new NAIADIDE.PaintPanel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSButton1,
            this.tsButton2,
            this.tsButton3,
            this.tsButton4,
            this.tsButton5,
            this.tsButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(45, 937);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tSButton1_MouseDown);
            // 
            // tSButton1
            // 
            this.tSButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tSButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButton1.Image = global::NAIAD_IDE_1._0.Properties.Resources.Search;
            this.tSButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButton1.Name = "tSButton1";
            this.tSButton1.Size = new System.Drawing.Size(42, 44);
            this.tSButton1.Text = "toolStripButton1";
            this.tSButton1.ToolTipText = "Search Target";
            this.tSButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tSButton1_MouseDown);
            // 
            // tsButton2
            // 
            this.tsButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButton2.Image = global::NAIAD_IDE_1._0.Properties.Resources.trace;
            this.tsButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton2.Name = "tsButton2";
            this.tsButton2.Size = new System.Drawing.Size(42, 44);
            this.tsButton2.Text = "toolStripButton1";
            this.tsButton2.ToolTipText = "Tracing the target";
            this.tsButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsButton2_MouseDown);
            // 
            // tsButton3
            // 
            this.tsButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButton3.Image = global::NAIAD_IDE_1._0.Properties.Resources.straightArrow;
            this.tsButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton3.Name = "tsButton3";
            this.tsButton3.Size = new System.Drawing.Size(42, 44);
            this.tsButton3.Text = "toolStripButton1";
            this.tsButton3.BackColorChanged += new System.EventHandler(this.Line_Click);
            this.tsButton3.Click += new System.EventHandler(this.Line_Click);
            // 
            // tsButton4
            // 
            this.tsButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButton4.Image = global::NAIAD_IDE_1._0.Properties.Resources.Curve;
            this.tsButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton4.Name = "tsButton4";
            this.tsButton4.Size = new System.Drawing.Size(42, 44);
            this.tsButton4.Text = "tsButton4";
            this.tsButton4.ToolTipText = "Call Back";
            this.tsButton4.Click += new System.EventHandler(this.tsButton4_Click);
            // 
            // tsButton5
            // 
            this.tsButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButton5.Image = ((System.Drawing.Image)(resources.GetObject("tsButton5.Image")));
            this.tsButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton5.Name = "tsButton5";
            this.tsButton5.Size = new System.Drawing.Size(42, 44);
            this.tsButton5.Text = "toolStripButton1";
            this.tsButton5.ToolTipText = "Change shape";
            this.tsButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsButton5_MouseDown);
            // 
            // tsButton6
            // 
            this.tsButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButton6.Image = ((System.Drawing.Image)(resources.GetObject("tsButton6.Image")));
            this.tsButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton6.Name = "tsButton6";
            this.tsButton6.Size = new System.Drawing.Size(42, 44);
            this.tsButton6.Text = "toolStripButton1";
            this.tsButton6.ToolTipText = "Fire Torpedo";
            this.tsButton6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsButton6_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "Save as Json ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveAsToolStripMenuItem.Text = "Save As XML";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cutToolStripMenuItem.Text = "Remove";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectAllToolStripMenuItem.Text = "Remove All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // welcomeToolStripMenuItem
            // 
            this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
            this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.welcomeToolStripMenuItem.Text = "Welcome";
            this.welcomeToolStripMenuItem.Click += new System.EventHandler(this.welcomeToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // bTCP
            // 
            this.bTCP.BackColor = System.Drawing.Color.ForestGreen;
            this.bTCP.Location = new System.Drawing.Point(317, 840);
            this.bTCP.Name = "bTCP";
            this.bTCP.Size = new System.Drawing.Size(221, 40);
            this.bTCP.TabIndex = 3;
            this.bTCP.Text = "Communication with NAIAD";
            this.bTCP.UseVisualStyleBackColor = false;
            this.bTCP.Click += new System.EventHandler(this.bTCP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 840);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveXML,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.CanMessage});
            this.toolStrip2.Location = new System.Drawing.Point(45, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1231, 43);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // saveXML
            // 
            this.saveXML.AutoSize = false;
            this.saveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveXML.Image = global::NAIAD_IDE_1._0.Properties.Resources.save;
            this.saveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveXML.Name = "saveXML";
            this.saveXML.Size = new System.Drawing.Size(50, 47);
            this.saveXML.Text = "Xml";
            this.saveXML.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveXML.ToolTipText = "Save as Xml";
            this.saveXML.Click += new System.EventHandler(this.saveXML_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NAIAD_IDE_1._0.Properties.Resources._return;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Remove last item";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::NAIAD_IDE_1._0.Properties.Resources.clear;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 40);
            this.toolStripButton2.Text = "Clear";
            this.toolStripButton2.ToolTipText = "Clear All";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::NAIAD_IDE_1._0.Properties.Resources.PID;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(49, 40);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "PID Controller";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::NAIAD_IDE_1._0.Properties.Resources.delete;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 40);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Delete selected item";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // CanMessage
            // 
            this.CanMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CanMessage.Image = global::NAIAD_IDE_1._0.Properties.Resources.can;
            this.CanMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CanMessage.Name = "CanMessage";
            this.CanMessage.Size = new System.Drawing.Size(49, 40);
            this.CanMessage.Text = "CanMessage";
            this.CanMessage.Click += new System.EventHandler(this.CanMessage_Click);
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSize = true;
            this.IPAddress.Location = new System.Drawing.Point(94, 826);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(71, 12);
            this.IPAddress.TabIndex = 6;
            this.IPAddress.Text = "IPAddress :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 873);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port Number :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 826);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 870);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.DrawLine = false;
            this.panel1.Location = new System.Drawing.Point(48, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 595);
            this.panel1.TabIndex = 10;
            this.panel1.Text = "panel1";
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panle1_MouseUp);
            // 
            // NaiadIDE
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1276, 962);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTCP);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NaiadIDE";
            this.Text = "NAIAD IDE 1.0";
            this.Load += new System.EventHandler(this.NaiadIDE_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSButton1;
       // private PaintPanel panel1;
        //private PaintPanel panel1;
        private System.Windows.Forms.ToolStripButton tsButton2;
        private System.Windows.Forms.ToolStripButton tsButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsButton4;
        private System.Windows.Forms.Button bTCP;
        private System.Windows.Forms.ToolStripButton tsButton5;
        private System.Windows.Forms.ToolStripButton tsButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton saveXML;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label IPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton CanMessage;
        private PaintPanel panel1;
    }
}

