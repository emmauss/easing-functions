namespace EaseDemonstration
{
    partial class frmMain
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
            this.inLabel = new System.Windows.Forms.Label();
            this.grpEaseIn = new System.Windows.Forms.GroupBox();
            this.grpEaseOut = new System.Windows.Forms.GroupBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.grpEaseInOut = new System.Windows.Forms.GroupBox();
            this.inOutLabel = new System.Windows.Forms.Label();
            this.btnEaseIn = new System.Windows.Forms.Button();
            this.btnEaseOut = new System.Windows.Forms.Button();
            this.btnEaseInOut = new System.Windows.Forms.Button();
            this.comboEaseSelection = new System.Windows.Forms.ComboBox();
            this.btnPerformAll = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblEaseDuration = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpEaseIn.SuspendLayout();
            this.grpEaseOut.SuspendLayout();
            this.grpEaseInOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabel.Location = new System.Drawing.Point(6, 26);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(18, 19);
            this.inLabel.TabIndex = 0;
            this.inLabel.Text = "|";
            // 
            // grpEaseIn
            // 
            this.grpEaseIn.Controls.Add(this.inLabel);
            this.grpEaseIn.Location = new System.Drawing.Point(50, 54);
            this.grpEaseIn.Name = "grpEaseIn";
            this.grpEaseIn.Size = new System.Drawing.Size(845, 63);
            this.grpEaseIn.TabIndex = 6;
            this.grpEaseIn.TabStop = false;
            this.grpEaseIn.Text = "Ease In";
            // 
            // grpEaseOut
            // 
            this.grpEaseOut.Controls.Add(this.outLabel);
            this.grpEaseOut.Location = new System.Drawing.Point(50, 123);
            this.grpEaseOut.Name = "grpEaseOut";
            this.grpEaseOut.Size = new System.Drawing.Size(845, 63);
            this.grpEaseOut.TabIndex = 8;
            this.grpEaseOut.TabStop = false;
            this.grpEaseOut.Text = "Ease Out";
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(6, 26);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(18, 19);
            this.outLabel.TabIndex = 0;
            this.outLabel.Text = "|";
            // 
            // grpEaseInOut
            // 
            this.grpEaseInOut.Controls.Add(this.inOutLabel);
            this.grpEaseInOut.Location = new System.Drawing.Point(50, 192);
            this.grpEaseInOut.Name = "grpEaseInOut";
            this.grpEaseInOut.Size = new System.Drawing.Size(845, 63);
            this.grpEaseInOut.TabIndex = 10;
            this.grpEaseInOut.TabStop = false;
            this.grpEaseInOut.Text = "Ease In-Out";
            // 
            // inOutLabel
            // 
            this.inOutLabel.AutoSize = true;
            this.inOutLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOutLabel.Location = new System.Drawing.Point(6, 26);
            this.inOutLabel.Name = "inOutLabel";
            this.inOutLabel.Size = new System.Drawing.Size(18, 19);
            this.inOutLabel.TabIndex = 0;
            this.inOutLabel.Text = "|";
            // 
            // btnEaseIn
            // 
            this.btnEaseIn.Location = new System.Drawing.Point(12, 69);
            this.btnEaseIn.Name = "btnEaseIn";
            this.btnEaseIn.Size = new System.Drawing.Size(32, 42);
            this.btnEaseIn.TabIndex = 5;
            this.btnEaseIn.Text = "GO";
            this.btnEaseIn.UseVisualStyleBackColor = true;
            this.btnEaseIn.Click += new System.EventHandler(this.BtnEaseIn_Click);
            // 
            // btnEaseOut
            // 
            this.btnEaseOut.Location = new System.Drawing.Point(12, 138);
            this.btnEaseOut.Name = "btnEaseOut";
            this.btnEaseOut.Size = new System.Drawing.Size(32, 42);
            this.btnEaseOut.TabIndex = 7;
            this.btnEaseOut.Text = "GO";
            this.btnEaseOut.UseVisualStyleBackColor = true;
            this.btnEaseOut.Click += new System.EventHandler(this.BtnEaseOut_Click);
            // 
            // btnEaseInOut
            // 
            this.btnEaseInOut.Location = new System.Drawing.Point(12, 207);
            this.btnEaseInOut.Name = "btnEaseInOut";
            this.btnEaseInOut.Size = new System.Drawing.Size(32, 42);
            this.btnEaseInOut.TabIndex = 9;
            this.btnEaseInOut.Text = "GO";
            this.btnEaseInOut.UseVisualStyleBackColor = true;
            this.btnEaseInOut.Click += new System.EventHandler(this.BtnEaseInOut_Click);
            // 
            // comboEaseSelection
            // 
            this.comboEaseSelection.FormattingEnabled = true;
            this.comboEaseSelection.Items.AddRange(new object[] {
            "Linear",
            "Sine",
            "Quadratic",
            "Cubic",
            "Quartic",
            "Circular"});
            this.comboEaseSelection.Location = new System.Drawing.Point(12, 12);
            this.comboEaseSelection.Name = "comboEaseSelection";
            this.comboEaseSelection.Size = new System.Drawing.Size(188, 21);
            this.comboEaseSelection.TabIndex = 0;
            this.comboEaseSelection.SelectedIndexChanged += new System.EventHandler(this.ComboEaseSelection_SelectedIndexChanged);
            // 
            // btnPerformAll
            // 
            this.btnPerformAll.Location = new System.Drawing.Point(206, 11);
            this.btnPerformAll.Name = "btnPerformAll";
            this.btnPerformAll.Size = new System.Drawing.Size(117, 23);
            this.btnPerformAll.TabIndex = 1;
            this.btnPerformAll.Text = "Perform All Eases";
            this.btnPerformAll.UseVisualStyleBackColor = true;
            this.btnPerformAll.Click += new System.EventHandler(this.BtnPerformAll_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(775, 12);
            this.numDuration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 4;
            this.numDuration.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDuration.ValueChanged += new System.EventHandler(this.NumDuration_ValueChanged);
            // 
            // lblEaseDuration
            // 
            this.lblEaseDuration.AutoSize = true;
            this.lblEaseDuration.Location = new System.Drawing.Point(673, 14);
            this.lblEaseDuration.Name = "lblEaseDuration";
            this.lblEaseDuration.Size = new System.Drawing.Size(96, 13);
            this.lblEaseDuration.TabIndex = 3;
            this.lblEaseDuration.Text = "Ease Duration (ms)";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(329, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 268);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblEaseDuration);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.btnPerformAll);
            this.Controls.Add(this.comboEaseSelection);
            this.Controls.Add(this.btnEaseInOut);
            this.Controls.Add(this.btnEaseOut);
            this.Controls.Add(this.btnEaseIn);
            this.Controls.Add(this.grpEaseInOut);
            this.Controls.Add(this.grpEaseOut);
            this.Controls.Add(this.grpEaseIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Ease Demonstration";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpEaseIn.ResumeLayout(false);
            this.grpEaseIn.PerformLayout();
            this.grpEaseOut.ResumeLayout(false);
            this.grpEaseOut.PerformLayout();
            this.grpEaseInOut.ResumeLayout(false);
            this.grpEaseInOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.GroupBox grpEaseIn;
        private System.Windows.Forms.GroupBox grpEaseOut;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.GroupBox grpEaseInOut;
        private System.Windows.Forms.Label inOutLabel;
        private System.Windows.Forms.Button btnEaseIn;
        private System.Windows.Forms.Button btnEaseOut;
        private System.Windows.Forms.Button btnEaseInOut;
        private System.Windows.Forms.ComboBox comboEaseSelection;
        private System.Windows.Forms.Button btnPerformAll;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblEaseDuration;
        private System.Windows.Forms.Button btnStop;
    }
}

