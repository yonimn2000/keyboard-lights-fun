namespace YonatanMankovich.KeyboardLightsFun
{
    partial class MainForm
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
            this.repeatsNUD = new System.Windows.Forms.NumericUpDown();
            this.speedNUD = new System.Windows.Forms.NumericUpDown();
            this.repeatsLBL = new System.Windows.Forms.Label();
            this.speedLBL = new System.Windows.Forms.Label();
            this.configGroup = new System.Windows.Forms.GroupBox();
            this.continiousCB = new System.Windows.Forms.CheckBox();
            this.startStopBTN = new System.Windows.Forms.Button();
            this.patternsCB = new System.Windows.Forms.ComboBox();
            this.patternEditBTN = new System.Windows.Forms.Button();
            this.patternShowPB = new System.Windows.Forms.ProgressBar();
            this.toggeableKeyStatesVisualizer = new YonatanMankovich.KeyboardLightsFun.ToggeableKeyStatesVisualizer();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNUD)).BeginInit();
            this.configGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // repeatsNUD
            // 
            this.repeatsNUD.Location = new System.Drawing.Point(52, 19);
            this.repeatsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatsNUD.Name = "repeatsNUD";
            this.repeatsNUD.Size = new System.Drawing.Size(39, 20);
            this.repeatsNUD.TabIndex = 11;
            this.repeatsNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // speedNUD
            // 
            this.speedNUD.Location = new System.Drawing.Point(43, 58);
            this.speedNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNUD.Name = "speedNUD";
            this.speedNUD.Size = new System.Drawing.Size(48, 20);
            this.speedNUD.TabIndex = 12;
            this.speedNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // repeatsLBL
            // 
            this.repeatsLBL.AutoSize = true;
            this.repeatsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatsLBL.Location = new System.Drawing.Point(6, 21);
            this.repeatsLBL.Name = "repeatsLBL";
            this.repeatsLBL.Size = new System.Drawing.Size(47, 13);
            this.repeatsLBL.TabIndex = 13;
            this.repeatsLBL.Text = "Repeats";
            // 
            // speedLBL
            // 
            this.speedLBL.AutoSize = true;
            this.speedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLBL.Location = new System.Drawing.Point(6, 60);
            this.speedLBL.Name = "speedLBL";
            this.speedLBL.Size = new System.Drawing.Size(38, 13);
            this.speedLBL.TabIndex = 14;
            this.speedLBL.Text = "Speed";
            // 
            // configGroup
            // 
            this.configGroup.Controls.Add(this.repeatsNUD);
            this.configGroup.Controls.Add(this.speedNUD);
            this.configGroup.Controls.Add(this.repeatsLBL);
            this.configGroup.Controls.Add(this.speedLBL);
            this.configGroup.Controls.Add(this.continiousCB);
            this.configGroup.Location = new System.Drawing.Point(12, 6);
            this.configGroup.Name = "configGroup";
            this.configGroup.Size = new System.Drawing.Size(99, 85);
            this.configGroup.TabIndex = 15;
            this.configGroup.TabStop = false;
            this.configGroup.Text = "Configuration";
            // 
            // continiousCB
            // 
            this.continiousCB.AutoSize = true;
            this.continiousCB.Location = new System.Drawing.Point(9, 40);
            this.continiousCB.Name = "continiousCB";
            this.continiousCB.Size = new System.Drawing.Size(79, 17);
            this.continiousCB.TabIndex = 15;
            this.continiousCB.Text = "Continuous";
            this.continiousCB.UseVisualStyleBackColor = true;
            this.continiousCB.CheckedChanged += new System.EventHandler(this.ContiniousCB_CheckedChanged);
            // 
            // startStopBTN
            // 
            this.startStopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startStopBTN.Location = new System.Drawing.Point(117, 39);
            this.startStopBTN.Name = "startStopBTN";
            this.startStopBTN.Size = new System.Drawing.Size(74, 24);
            this.startStopBTN.TabIndex = 16;
            this.startStopBTN.Text = "Start";
            this.startStopBTN.UseVisualStyleBackColor = true;
            this.startStopBTN.Click += new System.EventHandler(this.startStopBTN_Click);
            // 
            // patternsCB
            // 
            this.patternsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patternsCB.FormattingEnabled = true;
            this.patternsCB.Location = new System.Drawing.Point(117, 12);
            this.patternsCB.Name = "patternsCB";
            this.patternsCB.Size = new System.Drawing.Size(200, 21);
            this.patternsCB.TabIndex = 17;
            // 
            // patternEditBTN
            // 
            this.patternEditBTN.Location = new System.Drawing.Point(117, 68);
            this.patternEditBTN.Name = "patternEditBTN";
            this.patternEditBTN.Size = new System.Drawing.Size(74, 23);
            this.patternEditBTN.TabIndex = 18;
            this.patternEditBTN.Text = "Edit patterns";
            this.patternEditBTN.UseVisualStyleBackColor = true;
            this.patternEditBTN.Click += new System.EventHandler(this.patternEditBTN_Click);
            // 
            // patternShowPB
            // 
            this.patternShowPB.Location = new System.Drawing.Point(197, 39);
            this.patternShowPB.Name = "patternShowPB";
            this.patternShowPB.Size = new System.Drawing.Size(120, 24);
            this.patternShowPB.TabIndex = 19;
            // 
            // toggeableKeyStatesVisualizer
            // 
            this.toggeableKeyStatesVisualizer.BackColor = System.Drawing.Color.Transparent;
            this.toggeableKeyStatesVisualizer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggeableKeyStatesVisualizer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toggeableKeyStatesVisualizer.Location = new System.Drawing.Point(197, 68);
            this.toggeableKeyStatesVisualizer.Name = "toggeableKeyStatesVisualizer";
            this.toggeableKeyStatesVisualizer.Size = new System.Drawing.Size(120, 23);
            this.toggeableKeyStatesVisualizer.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 101);
            this.Controls.Add(this.toggeableKeyStatesVisualizer);
            this.Controls.Add(this.patternShowPB);
            this.Controls.Add(this.patternEditBTN);
            this.Controls.Add(this.patternsCB);
            this.Controls.Add(this.configGroup);
            this.Controls.Add(this.startStopBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Keyboard Lights Fun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.repeatsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNUD)).EndInit();
            this.configGroup.ResumeLayout(false);
            this.configGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown repeatsNUD;
        private System.Windows.Forms.NumericUpDown speedNUD;
        private System.Windows.Forms.Label repeatsLBL;
        private System.Windows.Forms.Label speedLBL;
        private System.Windows.Forms.GroupBox configGroup;
        private System.Windows.Forms.CheckBox continiousCB;
        private System.Windows.Forms.Button startStopBTN;
        private System.Windows.Forms.ComboBox patternsCB;
        private System.Windows.Forms.Button patternEditBTN;
        private System.Windows.Forms.ProgressBar patternShowPB;
        private ToggeableKeyStatesVisualizer toggeableKeyStatesVisualizer;
    }
}

