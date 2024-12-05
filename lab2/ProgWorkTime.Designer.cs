namespace OPCClientApp
{
    partial class ProgWorkTime
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWorkTime = new System.Windows.Forms.Label();
            this.labelProgWorkTime = new System.Windows.Forms.Label();
            this.progressBarProgPercent = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelWorkTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProgWorkTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBarProgPercent, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelWorkTime
            // 
            this.labelWorkTime.AutoSize = true;
            this.labelWorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkTime.Location = new System.Drawing.Point(3, 0);
            this.labelWorkTime.Name = "labelWorkTime";
            this.labelWorkTime.Size = new System.Drawing.Size(318, 82);
            this.labelWorkTime.TabIndex = 0;
            this.labelWorkTime.Text = "Время работы";
            this.labelWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProgWorkTime
            // 
            this.labelProgWorkTime.AutoSize = true;
            this.labelProgWorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgWorkTime.Location = new System.Drawing.Point(3, 82);
            this.labelProgWorkTime.Name = "labelProgWorkTime";
            this.labelProgWorkTime.Size = new System.Drawing.Size(318, 82);
            this.labelProgWorkTime.TabIndex = 1;
            this.labelProgWorkTime.Text = "Время выполнения программы";
            this.labelProgWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarProgPercent
            // 
            this.progressBarProgPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarProgPercent.Location = new System.Drawing.Point(3, 167);
            this.progressBarProgPercent.Name = "progressBarProgPercent";
            this.progressBarProgPercent.Size = new System.Drawing.Size(318, 77);
            this.progressBarProgPercent.Step = 1;
            this.progressBarProgPercent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarProgPercent.TabIndex = 2;
            // 
            // ProgWorkTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProgWorkTime";
            this.Size = new System.Drawing.Size(324, 247);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelWorkTime;
        private System.Windows.Forms.Label labelProgWorkTime;
        private System.Windows.Forms.ProgressBar progressBarProgPercent;
    }
}
