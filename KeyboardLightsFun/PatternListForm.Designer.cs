namespace YonatanMankovich.KeyboardLightsFun
{
    partial class PatternListForm
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
            this.patternsLB = new System.Windows.Forms.ListBox();
            this.editBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // patternsLB
            // 
            this.patternsLB.AllowDrop = true;
            this.patternsLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternsLB.FormattingEnabled = true;
            this.patternsLB.Location = new System.Drawing.Point(12, 12);
            this.patternsLB.Name = "patternsLB";
            this.patternsLB.Size = new System.Drawing.Size(180, 108);
            this.patternsLB.TabIndex = 0;
            this.patternsLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.patternsLB_DragDrop);
            this.patternsLB.DragOver += new System.Windows.Forms.DragEventHandler(this.patternsLB_DragOver);
            this.patternsLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patternsLB_MouseDown);
            // 
            // editBTN
            // 
            this.editBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBTN.Location = new System.Drawing.Point(3, 3);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(53, 24);
            this.editBTN.TabIndex = 0;
            this.editBTN.Text = "Edit";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBTN.Location = new System.Drawing.Point(62, 3);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(54, 24);
            this.addBTN.TabIndex = 1;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBTN.Location = new System.Drawing.Point(3, 3);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(84, 29);
            this.saveBTN.TabIndex = 0;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.editBTN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBTN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeBTN, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 126);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // removeBTN
            // 
            this.removeBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBTN.Location = new System.Drawing.Point(122, 3);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(55, 24);
            this.removeBTN.TabIndex = 2;
            this.removeBTN.Text = "Remove";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveBTN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelBTN, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 35);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cancelBTN
            // 
            this.cancelBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBTN.Location = new System.Drawing.Point(93, 3);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(84, 29);
            this.cancelBTN.TabIndex = 1;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // PatternListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 203);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.patternsLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(219, 177);
            this.Name = "PatternListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pattern List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatternListForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox patternsLB;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cancelBTN;
    }
}