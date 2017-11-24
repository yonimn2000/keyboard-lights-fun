namespace KeyboardLights
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
            this.repeatsUD = new System.Windows.Forms.NumericUpDown();
            this.speedUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.configGroup = new System.Windows.Forms.GroupBox();
            this.continiousCB = new System.Windows.Forms.CheckBox();
            this.startStopBTN = new System.Windows.Forms.Button();
            this.patternsCollection = new System.Windows.Forms.ComboBox();
            this.ReverseCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUD)).BeginInit();
            this.configGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // repeatsUD
            // 
            this.repeatsUD.Location = new System.Drawing.Point(52, 19);
            this.repeatsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatsUD.Name = "repeatsUD";
            this.repeatsUD.Size = new System.Drawing.Size(39, 20);
            this.repeatsUD.TabIndex = 11;
            this.repeatsUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // speedUD
            // 
            this.speedUD.Location = new System.Drawing.Point(43, 63);
            this.speedUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedUD.Name = "speedUD";
            this.speedUD.Size = new System.Drawing.Size(48, 20);
            this.speedUD.TabIndex = 12;
            this.speedUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Repeats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Speed";
            // 
            // configGroup
            // 
            this.configGroup.Controls.Add(this.repeatsUD);
            this.configGroup.Controls.Add(this.speedUD);
            this.configGroup.Controls.Add(this.label2);
            this.configGroup.Controls.Add(this.label3);
            this.configGroup.Controls.Add(this.continiousCB);
            this.configGroup.Location = new System.Drawing.Point(12, 6);
            this.configGroup.Name = "configGroup";
            this.configGroup.Size = new System.Drawing.Size(99, 91);
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
            this.continiousCB.CheckedChanged += new System.EventHandler(this.continiousCB_CheckedChanged);
            // 
            // startStopBTN
            // 
            this.startStopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopBTN.Location = new System.Drawing.Point(117, 62);
            this.startStopBTN.Name = "startStopBTN";
            this.startStopBTN.Size = new System.Drawing.Size(99, 35);
            this.startStopBTN.TabIndex = 16;
            this.startStopBTN.Text = "Start";
            this.startStopBTN.UseVisualStyleBackColor = true;
            this.startStopBTN.Click += new System.EventHandler(this.startStopBTN_Click);
            // 
            // patternsCollection
            // 
            this.patternsCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patternsCollection.FormattingEnabled = true;
            this.patternsCollection.Items.AddRange(new object[] {
            "Random",
            "All"});
            this.patternsCollection.Location = new System.Drawing.Point(117, 12);
            this.patternsCollection.Name = "patternsCollection";
            this.patternsCollection.Size = new System.Drawing.Size(99, 21);
            this.patternsCollection.TabIndex = 17;
            this.patternsCollection.SelectedIndexChanged += new System.EventHandler(this.patternsCollection_SelectedIndexChanged);
            // 
            // ReverseCB
            // 
            this.ReverseCB.AutoSize = true;
            this.ReverseCB.Enabled = false;
            this.ReverseCB.Location = new System.Drawing.Point(117, 39);
            this.ReverseCB.Name = "ReverseCB";
            this.ReverseCB.Size = new System.Drawing.Size(103, 17);
            this.ReverseCB.TabIndex = 18;
            this.ReverseCB.Text = "Reverse Pattern";
            this.ReverseCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(225, 107);
            this.Controls.Add(this.ReverseCB);
            this.Controls.Add(this.patternsCollection);
            this.Controls.Add(this.configGroup);
            this.Controls.Add(this.startStopBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lights";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repeatsUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUD)).EndInit();
            this.configGroup.ResumeLayout(false);
            this.configGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown repeatsUD;
        private System.Windows.Forms.NumericUpDown speedUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox configGroup;
        private System.Windows.Forms.CheckBox continiousCB;
        private System.Windows.Forms.Button startStopBTN;
        private System.Windows.Forms.ComboBox patternsCollection;
        private System.Windows.Forms.CheckBox ReverseCB;
    }
}

