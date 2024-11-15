namespace lab2
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
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelNodeValue = new System.Windows.Forms.Label();
            this.buttonReadNodeValue = new System.Windows.Forms.Button();
            this.ReadPositionBtn = new System.Windows.Forms.Button();
            this.positionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(428, 32);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(99, 16);
            this.labelConnectionStatus.TabIndex = 0;
            this.labelConnectionStatus.Text = "Не соединено";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(558, 23);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(109, 35);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Соединиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(558, 64);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(109, 34);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Отключиться";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelNodeValue
            // 
            this.labelNodeValue.AutoSize = true;
            this.labelNodeValue.Location = new System.Drawing.Point(225, 230);
            this.labelNodeValue.Name = "labelNodeValue";
            this.labelNodeValue.Size = new System.Drawing.Size(107, 16);
            this.labelNodeValue.TabIndex = 3;
            this.labelNodeValue.Text = "Значение узла";
            // 
            // buttonReadNodeValue
            // 
            this.buttonReadNodeValue.Location = new System.Drawing.Point(350, 213);
            this.buttonReadNodeValue.Name = "buttonReadNodeValue";
            this.buttonReadNodeValue.Size = new System.Drawing.Size(234, 50);
            this.buttonReadNodeValue.TabIndex = 4;
            this.buttonReadNodeValue.Text = "Прочитать значение узла";
            this.buttonReadNodeValue.UseVisualStyleBackColor = true;
            this.buttonReadNodeValue.Click += new System.EventHandler(this.buttonReadNodeValue_Click);
            // 
            // ReadPositionBtn
            // 
            this.ReadPositionBtn.Location = new System.Drawing.Point(350, 305);
            this.ReadPositionBtn.Name = "ReadPositionBtn";
            this.ReadPositionBtn.Size = new System.Drawing.Size(234, 46);
            this.ReadPositionBtn.TabIndex = 5;
            this.ReadPositionBtn.Text = "Прочитать координаты шпинделя";
            this.ReadPositionBtn.UseVisualStyleBackColor = true;
            this.ReadPositionBtn.Click += new System.EventHandler(this.ReadPositionBtn_Click);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(202, 320);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(130, 16);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Запросите данные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.ReadPositionBtn);
            this.Controls.Add(this.buttonReadNodeValue);
            this.Controls.Add(this.labelNodeValue);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelConnectionStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelNodeValue;
        private System.Windows.Forms.Button buttonReadNodeValue;
        private System.Windows.Forms.Button ReadPositionBtn;
        private System.Windows.Forms.Label positionLabel;
    }
}

