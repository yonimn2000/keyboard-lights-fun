namespace YonatanMankovich.KeyboardLightsFun
{
    partial class PatternEditorForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patternGV = new System.Windows.Forms.DataGridView();
            this.NumLockColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CapsLockColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ScrollLockColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.previewBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previewSpeedNUD = new System.Windows.Forms.NumericUpDown();
            this.previewGB = new System.Windows.Forms.GroupBox();
            this.toggeableKeyStatesVisualizer = new YonatanMankovich.KeyboardLightsFun.ToggeableKeyStatesVisualizer();
            ((System.ComponentModel.ISupportInitialize)(this.patternGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewSpeedNUD)).BeginInit();
            this.previewGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(15, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(125, 20);
            this.nameTB.TabIndex = 0;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pattern name:";
            // 
            // patternGV
            // 
            this.patternGV.AllowUserToResizeColumns = false;
            this.patternGV.AllowUserToResizeRows = false;
            this.patternGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.patternGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patternGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumLockColumn,
            this.CapsLockColumn,
            this.ScrollLockColumn});
            this.patternGV.Location = new System.Drawing.Point(15, 51);
            this.patternGV.Name = "patternGV";
            this.patternGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.patternGV.Size = new System.Drawing.Size(125, 172);
            this.patternGV.TabIndex = 2;
            this.patternGV.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.patternGV_DefaultValuesNeeded);
            // 
            // NumLockColumn
            // 
            this.NumLockColumn.HeaderText = "N";
            this.NumLockColumn.Name = "NumLockColumn";
            this.NumLockColumn.Width = 21;
            // 
            // CapsLockColumn
            // 
            this.CapsLockColumn.HeaderText = "C";
            this.CapsLockColumn.Name = "CapsLockColumn";
            this.CapsLockColumn.Width = 21;
            // 
            // ScrollLockColumn
            // 
            this.ScrollLockColumn.HeaderText = "S";
            this.ScrollLockColumn.Name = "ScrollLockColumn";
            this.ScrollLockColumn.Width = 21;
            // 
            // saveBTN
            // 
            this.saveBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBTN.Location = new System.Drawing.Point(3, 3);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(56, 26);
            this.saveBTN.TabIndex = 3;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBTN.Location = new System.Drawing.Point(65, 3);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(57, 26);
            this.cancelBTN.TabIndex = 4;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveBTN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelBTN, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 334);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(125, 32);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // previewBTN
            // 
            this.previewBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBTN.Location = new System.Drawing.Point(6, 19);
            this.previewBTN.Name = "previewBTN";
            this.previewBTN.Size = new System.Drawing.Size(113, 23);
            this.previewBTN.TabIndex = 6;
            this.previewBTN.Text = "Start";
            this.previewBTN.UseVisualStyleBackColor = true;
            this.previewBTN.Click += new System.EventHandler(this.previewBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speed";
            // 
            // previewSpeedNUD
            // 
            this.previewSpeedNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.previewSpeedNUD.Location = new System.Drawing.Point(50, 45);
            this.previewSpeedNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.previewSpeedNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.previewSpeedNUD.Name = "previewSpeedNUD";
            this.previewSpeedNUD.Size = new System.Drawing.Size(69, 20);
            this.previewSpeedNUD.TabIndex = 8;
            this.previewSpeedNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // previewGB
            // 
            this.previewGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewGB.Controls.Add(this.previewBTN);
            this.previewGB.Controls.Add(this.previewSpeedNUD);
            this.previewGB.Controls.Add(this.label2);
            this.previewGB.Location = new System.Drawing.Point(15, 229);
            this.previewGB.Name = "previewGB";
            this.previewGB.Size = new System.Drawing.Size(125, 72);
            this.previewGB.TabIndex = 9;
            this.previewGB.TabStop = false;
            this.previewGB.Text = "Preview";
            // 
            // toggeableKeyStatesVisualizer
            // 
            this.toggeableKeyStatesVisualizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggeableKeyStatesVisualizer.BackColor = System.Drawing.Color.Transparent;
            this.toggeableKeyStatesVisualizer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggeableKeyStatesVisualizer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toggeableKeyStatesVisualizer.Location = new System.Drawing.Point(15, 307);
            this.toggeableKeyStatesVisualizer.Name = "toggeableKeyStatesVisualizer";
            this.toggeableKeyStatesVisualizer.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toggeableKeyStatesVisualizer.Size = new System.Drawing.Size(125, 21);
            this.toggeableKeyStatesVisualizer.TabIndex = 10;
            // 
            // PatternEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 378);
            this.Controls.Add(this.toggeableKeyStatesVisualizer);
            this.Controls.Add(this.previewGB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.patternGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(168, 300);
            this.Name = "PatternEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pattern Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatternEditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patternGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewSpeedNUD)).EndInit();
            this.previewGB.ResumeLayout(false);
            this.previewGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patternGV;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NumLockColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CapsLockColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ScrollLockColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button previewBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown previewSpeedNUD;
        private System.Windows.Forms.GroupBox previewGB;
        private ToggeableKeyStatesVisualizer toggeableKeyStatesVisualizer;
    }
}