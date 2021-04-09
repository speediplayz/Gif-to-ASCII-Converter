namespace ASCII_Gif_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConsole = new System.Windows.Forms.Label();
            this.chkBraille = new System.Windows.Forms.CheckBox();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkInvert = new System.Windows.Forms.CheckBox();
            this.chkTextFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(67, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(168, 20);
            this.txtDir.TabIndex = 2;
            this.txtDir.Text = "C:\\";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 3;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 269);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(223, 61);
            this.cmdStart.TabIndex = 4;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font Size";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(67, 64);
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(168, 20);
            this.numFontSize.TabIndex = 7;
            this.numFontSize.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numInterval
            // 
            this.numInterval.DecimalPlaces = 2;
            this.numInterval.Location = new System.Drawing.Point(67, 90);
            this.numInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(168, 20);
            this.numInterval.TabIndex = 8;
            this.numInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Interval";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(12, 333);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(46, 13);
            this.lblConsole.TabIndex = 5;
            this.lblConsole.Text = "Pending";
            // 
            // chkBraille
            // 
            this.chkBraille.AutoSize = true;
            this.chkBraille.Location = new System.Drawing.Point(15, 116);
            this.chkBraille.Name = "chkBraille";
            this.chkBraille.Size = new System.Drawing.Size(54, 17);
            this.chkBraille.TabIndex = 10;
            this.chkBraille.Text = "Braille";
            this.chkBraille.UseVisualStyleBackColor = true;
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(67, 139);
            this.numAlpha.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(168, 20);
            this.numAlpha.TabIndex = 11;
            this.numAlpha.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alpha Min";
            // 
            // numThreshold
            // 
            this.numThreshold.Location = new System.Drawing.Point(67, 165);
            this.numThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(168, 20);
            this.numThreshold.TabIndex = 12;
            this.numThreshold.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Threshold";
            // 
            // chkInvert
            // 
            this.chkInvert.AutoSize = true;
            this.chkInvert.Location = new System.Drawing.Point(15, 193);
            this.chkInvert.Name = "chkInvert";
            this.chkInvert.Size = new System.Drawing.Size(105, 17);
            this.chkInvert.TabIndex = 14;
            this.chkInvert.Text = "Start From White";
            this.chkInvert.UseVisualStyleBackColor = true;
            // 
            // chkTextFile
            // 
            this.chkTextFile.AutoSize = true;
            this.chkTextFile.Location = new System.Drawing.Point(15, 233);
            this.chkTextFile.Name = "chkTextFile";
            this.chkTextFile.Size = new System.Drawing.Size(66, 17);
            this.chkTextFile.TabIndex = 15;
            this.chkTextFile.Text = "Text File";
            this.chkTextFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 357);
            this.Controls.Add(this.chkTextFile);
            this.Controls.Add(this.chkInvert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numThreshold);
            this.Controls.Add(this.numAlpha);
            this.Controls.Add(this.chkBraille);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ASCII Gif Maker";
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.CheckBox chkBraille;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkInvert;
        private System.Windows.Forms.CheckBox chkTextFile;
    }
}

