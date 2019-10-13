namespace YonatanMankovich.KeyboardLightsFun
{
    partial class ToggeableKeyStatesVisualizer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visualizerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visualizerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualizerPanel
            // 
            this.visualizerPanel.ColumnCount = 3;
            this.visualizerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerPanel.Controls.Add(this.panel3, 2, 0);
            this.visualizerPanel.Controls.Add(this.panel2, 1, 0);
            this.visualizerPanel.Controls.Add(this.panel1, 0, 0);
            this.visualizerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizerPanel.Location = new System.Drawing.Point(3, 0);
            this.visualizerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.visualizerPanel.Name = "visualizerPanel";
            this.visualizerPanel.RowCount = 1;
            this.visualizerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.visualizerPanel.Size = new System.Drawing.Size(295, 98);
            this.visualizerPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(199, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 92);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(101, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 92);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 92);
            this.panel1.TabIndex = 0;
            // 
            // ToggeableKeyStatesVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.visualizerPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ToggeableKeyStatesVisualizer";
            this.Size = new System.Drawing.Size(298, 98);
            this.visualizerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel visualizerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
