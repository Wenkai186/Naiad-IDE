namespace NAIADIDE
{
    partial class SearchSetting
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
            this.bYes = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bYes
            // 
            this.bYes.Location = new System.Drawing.Point(163, 160);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(75, 23);
            this.bYes.TabIndex = 6;
            this.bYes.Text = "Yes";
            this.bYes.UseVisualStyleBackColor = true;
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Search Light",
            "Search Door",
            "Search Toy",
            "Search Fish"});
            this.comboBox.Location = new System.Drawing.Point(24, 41);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 20);
            this.comboBox.TabIndex = 7;
            // 
            // SearchSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 257);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.bYes);
            this.Name = "SearchSetting";
            this.Text = "Search Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bYes;
        private System.Windows.Forms.ComboBox comboBox;
    }
}