namespace LevelCreator
{
    partial class LevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelForm));
            this.numericUpDownLevels = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpacing = new System.Windows.Forms.NumericUpDown();
            this.btnCreateLevels = new System.Windows.Forms.Button();
            this.labelLevels = new System.Windows.Forms.Label();
            this.labelSpacing = new System.Windows.Forms.Label();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.labelSpecialRange = new System.Windows.Forms.Label();
            this.numericUpDownSpecialStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpecialEnd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpecialSpacing = new System.Windows.Forms.NumericUpDown();
            this.labelSpecialStart = new System.Windows.Forms.Label();
            this.labelSpecialEnd = new System.Windows.Forms.Label();
            this.labelSpecialSpacing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownLevels
            // 
            this.numericUpDownLevels.Location = new System.Drawing.Point(291, 30);
            this.numericUpDownLevels.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDownLevels.Name = "numericUpDownLevels";
            this.numericUpDownLevels.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownLevels.TabIndex = 0;
            // 
            // numericUpDownSpacing
            // 
            this.numericUpDownSpacing.DecimalPlaces = 2;
            this.numericUpDownSpacing.Location = new System.Drawing.Point(291, 80);
            this.numericUpDownSpacing.Name = "numericUpDownSpacing";
            this.numericUpDownSpacing.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSpacing.TabIndex = 1;
            // 
            // btnCreateLevels
            // 
            this.btnCreateLevels.Location = new System.Drawing.Point(139, 337);
            this.btnCreateLevels.Name = "btnCreateLevels";
            this.btnCreateLevels.Size = new System.Drawing.Size(142, 39);
            this.btnCreateLevels.TabIndex = 7;
            this.btnCreateLevels.Text = "Create Levels";
            this.btnCreateLevels.UseVisualStyleBackColor = true;
            this.btnCreateLevels.Click += new System.EventHandler(this.btnCreateLevels_Click);
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(10, 30);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(136, 20);
            this.labelLevels.TabIndex = 8;
            this.labelLevels.Text = "Number of Levels:";
            // 
            // labelSpacing
            // 
            this.labelSpacing.AutoSize = true;
            this.labelSpacing.Location = new System.Drawing.Point(10, 80);
            this.labelSpacing.Name = "labelSpacing";
            this.labelSpacing.Size = new System.Drawing.Size(139, 20);
            this.labelSpacing.TabIndex = 9;
            this.labelSpacing.Text = "Level Spacing (m):";
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(42, 130);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(52, 20);
            this.labelPrefix.TabIndex = 10;
            this.labelPrefix.Text = "Prefix:";
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(42, 175);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(53, 20);
            this.labelSuffix.TabIndex = 11;
            this.labelSuffix.Text = "Suffix:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(291, 130);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(120, 26);
            this.txtPrefix.TabIndex = 2;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(291, 175);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(120, 26);
            this.txtSuffix.TabIndex = 3;
            // 
            // labelSpecialRange
            // 
            this.labelSpecialRange.AutoSize = true;
            this.labelSpecialRange.Location = new System.Drawing.Point(10, 225);
            this.labelSpecialRange.Name = "labelSpecialRange";
            this.labelSpecialRange.Size = new System.Drawing.Size(117, 20);
            this.labelSpecialRange.TabIndex = 12;
            this.labelSpecialRange.Text = "Special Range:";
            // 
            // numericUpDownSpecialStart
            // 
            this.numericUpDownSpecialStart.Location = new System.Drawing.Point(237, 225);
            this.numericUpDownSpecialStart.Name = "numericUpDownSpecialStart";
            this.numericUpDownSpecialStart.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownSpecialStart.TabIndex = 4;
            // 
            // numericUpDownSpecialEnd
            // 
            this.numericUpDownSpecialEnd.Location = new System.Drawing.Point(351, 223);
            this.numericUpDownSpecialEnd.Name = "numericUpDownSpecialEnd";
            this.numericUpDownSpecialEnd.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownSpecialEnd.TabIndex = 5;
            // 
            // numericUpDownSpecialSpacing
            // 
            this.numericUpDownSpecialSpacing.DecimalPlaces = 2;
            this.numericUpDownSpecialSpacing.Location = new System.Drawing.Point(291, 278);
            this.numericUpDownSpecialSpacing.Name = "numericUpDownSpecialSpacing";
            this.numericUpDownSpecialSpacing.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSpecialSpacing.TabIndex = 6;
            // 
            // labelSpecialStart
            // 
            this.labelSpecialStart.AutoSize = true;
            this.labelSpecialStart.Location = new System.Drawing.Point(183, 227);
            this.labelSpecialStart.Name = "labelSpecialStart";
            this.labelSpecialStart.Size = new System.Drawing.Size(48, 20);
            this.labelSpecialStart.TabIndex = 14;
            this.labelSpecialStart.Text = "Start:";
            // 
            // labelSpecialEnd
            // 
            this.labelSpecialEnd.AutoSize = true;
            this.labelSpecialEnd.Location = new System.Drawing.Point(303, 227);
            this.labelSpecialEnd.Name = "labelSpecialEnd";
            this.labelSpecialEnd.Size = new System.Drawing.Size(42, 20);
            this.labelSpecialEnd.TabIndex = 15;
            this.labelSpecialEnd.Text = "End:";
            // 
            // labelSpecialSpacing
            // 
            this.labelSpecialSpacing.AutoSize = true;
            this.labelSpecialSpacing.Location = new System.Drawing.Point(10, 280);
            this.labelSpecialSpacing.Name = "labelSpecialSpacing";
            this.labelSpecialSpacing.Size = new System.Drawing.Size(127, 20);
            this.labelSpecialSpacing.TabIndex = 13;
            this.labelSpecialSpacing.Text = "Special Spacing:";
            // 
            // LevelForm
            // 
            this.ClientSize = new System.Drawing.Size(428, 394);
            this.Controls.Add(this.labelSpecialSpacing);
            this.Controls.Add(this.labelSpecialEnd);
            this.Controls.Add(this.labelSpecialStart);
            this.Controls.Add(this.numericUpDownSpecialSpacing);
            this.Controls.Add(this.numericUpDownSpecialEnd);
            this.Controls.Add(this.numericUpDownSpecialStart);
            this.Controls.Add(this.labelSpecialRange);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.labelSuffix);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.labelSpacing);
            this.Controls.Add(this.labelLevels);
            this.Controls.Add(this.btnCreateLevels);
            this.Controls.Add(this.numericUpDownSpacing);
            this.Controls.Add(this.numericUpDownLevels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelForm";
            this.Text = "Create Levels";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialSpacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.NumericUpDown numericUpDownLevels;
        public System.Windows.Forms.NumericUpDown numericUpDownSpacing;
        private System.Windows.Forms.Button btnCreateLevels;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.Label labelSpacing;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Label labelSuffix;
        public System.Windows.Forms.TextBox txtPrefix;
        public System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label labelSpecialRange;
        public System.Windows.Forms.NumericUpDown numericUpDownSpecialStart;
        public System.Windows.Forms.NumericUpDown numericUpDownSpecialEnd;
        public System.Windows.Forms.NumericUpDown numericUpDownSpecialSpacing;
        private System.Windows.Forms.Label labelSpecialStart;
        private System.Windows.Forms.Label labelSpecialEnd;
        private System.Windows.Forms.Label labelSpecialSpacing;
    }
}
