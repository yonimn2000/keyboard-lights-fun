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
            this.patternPreviewBW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.patternGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewSpeedNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
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
            this.patternGV.Size = new System.Drawing.Size(125, 200);
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveBTN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelBTN, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 313);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(125, 32);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // previewBTN
            // 
            this.previewBTN.Location = new System.Drawing.Point(15, 284);
            this.previewBTN.Name = "previewBTN";
            this.previewBTN.Size = new System.Drawing.Size(125, 23);
            this.previewBTN.TabIndex = 6;
            this.previewBTN.Text = "Start preview";
            this.previewBTN.UseVisualStyleBackColor = true;
            this.previewBTN.Click += new System.EventHandler(this.previewBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preview speed:";
            // 
            // previewSpeedNUD
            // 
            this.previewSpeedNUD.Location = new System.Drawing.Point(99, 258);
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
            this.previewSpeedNUD.Size = new System.Drawing.Size(41, 20);
            this.previewSpeedNUD.TabIndex = 8;
            this.previewSpeedNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // patternPreviewBW
            // 
            this.patternPreviewBW.WorkerReportsProgress = true;
            this.patternPreviewBW.WorkerSupportsCancellation = true;
            this.patternPreviewBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.patternPreviewBW_DoWork);
            this.patternPreviewBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.patternPreviewBW_ProgressChanged);
            this.patternPreviewBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.patternPreviewBW_RunWorkerCompleted);
            // 
            // PatternEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 355);
            this.Controls.Add(this.previewSpeedNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.previewBTN);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.patternGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PatternEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pattern Editor";
            ((System.ComponentModel.ISupportInitialize)(this.patternGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewSpeedNUD)).EndInit();
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
        private System.ComponentModel.BackgroundWorker patternPreviewBW;
    }
}