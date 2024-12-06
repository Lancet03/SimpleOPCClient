namespace OPCClientApp
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
            this.positionLabelX = new System.Windows.Forms.Label();
            this.nodesListText = new System.Windows.Forms.RichTextBox();
            this.readNodesBtn = new System.Windows.Forms.Button();
            this.buttonSubTest = new System.Windows.Forms.Button();
            this.buttonUnsubTest = new System.Windows.Forms.Button();
            this.positionLabelY = new System.Windows.Forms.Label();
            this.positionLabelZ = new System.Windows.Forms.Label();
            this.channelSpindleSpeed1 = new OPCClientApp.ChannelSpindleSpeed();
            this.progWorkTime1 = new OPCClientApp.ProgWorkTime();
            this.SuspendLayout();
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(127, 16);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(99, 16);
            this.labelConnectionStatus.TabIndex = 0;
            this.labelConnectionStatus.Text = "Не соединено";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 7);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(109, 34);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Соединиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 48);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelNodeValue.Location = new System.Drawing.Point(252, 108);
            this.labelNodeValue.Name = "labelNodeValue";
            this.labelNodeValue.Size = new System.Drawing.Size(107, 16);
            this.labelNodeValue.TabIndex = 3;
            this.labelNodeValue.Text = "Значение узла";
            // 
            // buttonReadNodeValue
            // 
            this.buttonReadNodeValue.Location = new System.Drawing.Point(12, 91);
            this.buttonReadNodeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReadNodeValue.Name = "buttonReadNodeValue";
            this.buttonReadNodeValue.Size = new System.Drawing.Size(235, 50);
            this.buttonReadNodeValue.TabIndex = 4;
            this.buttonReadNodeValue.Text = "Прочитать значение узла";
            this.buttonReadNodeValue.UseVisualStyleBackColor = true;
            this.buttonReadNodeValue.Click += new System.EventHandler(this.buttonReadNodeValue_Click);
            // 
            // ReadPositionBtn
            // 
            this.ReadPositionBtn.Location = new System.Drawing.Point(12, 146);
            this.ReadPositionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadPositionBtn.Name = "ReadPositionBtn";
            this.ReadPositionBtn.Size = new System.Drawing.Size(235, 46);
            this.ReadPositionBtn.TabIndex = 5;
            this.ReadPositionBtn.Text = "Прочитать координаты шпинделя";
            this.ReadPositionBtn.UseVisualStyleBackColor = true;
            this.ReadPositionBtn.Click += new System.EventHandler(this.ReadPositionBtn_Click);
            // 
            // positionLabelX
            // 
            this.positionLabelX.AutoSize = true;
            this.positionLabelX.Location = new System.Drawing.Point(252, 146);
            this.positionLabelX.Name = "positionLabelX";
            this.positionLabelX.Size = new System.Drawing.Size(28, 16);
            this.positionLabelX.TabIndex = 6;
            this.positionLabelX.Text = "X = ";
            // 
            // nodesListText
            // 
            this.nodesListText.Location = new System.Drawing.Point(255, 231);
            this.nodesListText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nodesListText.Name = "nodesListText";
            this.nodesListText.Size = new System.Drawing.Size(533, 326);
            this.nodesListText.TabIndex = 7;
            this.nodesListText.Text = "";
            // 
            // readNodesBtn
            // 
            this.readNodesBtn.Location = new System.Drawing.Point(12, 231);
            this.readNodesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readNodesBtn.Name = "readNodesBtn";
            this.readNodesBtn.Size = new System.Drawing.Size(235, 30);
            this.readNodesBtn.TabIndex = 8;
            this.readNodesBtn.Text = "Прочитать узлы";
            this.readNodesBtn.UseVisualStyleBackColor = true;
            this.readNodesBtn.Click += new System.EventHandler(this.readNodesBtn_Click);
            // 
            // buttonSubTest
            // 
            this.buttonSubTest.Location = new System.Drawing.Point(259, 16);
            this.buttonSubTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubTest.Name = "buttonSubTest";
            this.buttonSubTest.Size = new System.Drawing.Size(217, 30);
            this.buttonSubTest.TabIndex = 9;
            this.buttonSubTest.Text = "Подписаться на изменения";
            this.buttonSubTest.UseVisualStyleBackColor = true;
            this.buttonSubTest.Click += new System.EventHandler(this.buttonSubTest_Click);
            // 
            // buttonUnsubTest
            // 
            this.buttonUnsubTest.Location = new System.Drawing.Point(259, 53);
            this.buttonUnsubTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnsubTest.Name = "buttonUnsubTest";
            this.buttonUnsubTest.Size = new System.Drawing.Size(217, 30);
            this.buttonUnsubTest.TabIndex = 10;
            this.buttonUnsubTest.Text = "Отписаться от изменений";
            this.buttonUnsubTest.UseVisualStyleBackColor = true;
            this.buttonUnsubTest.Click += new System.EventHandler(this.buttonUnsubTest_Click);
            // 
            // positionLabelY
            // 
            this.positionLabelY.AutoSize = true;
            this.positionLabelY.Location = new System.Drawing.Point(252, 162);
            this.positionLabelY.Name = "positionLabelY";
            this.positionLabelY.Size = new System.Drawing.Size(29, 16);
            this.positionLabelY.TabIndex = 13;
            this.positionLabelY.Text = "Y = ";
            // 
            // positionLabelZ
            // 
            this.positionLabelZ.AutoSize = true;
            this.positionLabelZ.Location = new System.Drawing.Point(252, 178);
            this.positionLabelZ.Name = "positionLabelZ";
            this.positionLabelZ.Size = new System.Drawing.Size(28, 16);
            this.positionLabelZ.TabIndex = 14;
            this.positionLabelZ.Text = "Z = ";
            // 
            // channelSpindleSpeed1
            // 
            this.channelSpindleSpeed1.Location = new System.Drawing.Point(105, 569);
            this.channelSpindleSpeed1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.channelSpindleSpeed1.Name = "channelSpindleSpeed1";
            this.channelSpindleSpeed1.Size = new System.Drawing.Size(639, 50);
            this.channelSpindleSpeed1.TabIndex = 12;
            // 
            // progWorkTime1
            // 
            this.progWorkTime1.Location = new System.Drawing.Point(495, 28);
            this.progWorkTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progWorkTime1.Name = "progWorkTime1";
            this.progWorkTime1.Size = new System.Drawing.Size(268, 178);
            this.progWorkTime1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 633);
            this.Controls.Add(this.positionLabelZ);
            this.Controls.Add(this.positionLabelY);
            this.Controls.Add(this.channelSpindleSpeed1);
            this.Controls.Add(this.progWorkTime1);
            this.Controls.Add(this.buttonUnsubTest);
            this.Controls.Add(this.buttonSubTest);
            this.Controls.Add(this.readNodesBtn);
            this.Controls.Add(this.nodesListText);
            this.Controls.Add(this.positionLabelX);
            this.Controls.Add(this.ReadPositionBtn);
            this.Controls.Add(this.buttonReadNodeValue);
            this.Controls.Add(this.labelNodeValue);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelConnectionStatus);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SimpleOPCClient";
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
        private System.Windows.Forms.Label positionLabelX;
        private System.Windows.Forms.RichTextBox nodesListText;
        private System.Windows.Forms.Button readNodesBtn;
        private System.Windows.Forms.Button buttonSubTest;
        private System.Windows.Forms.Button buttonUnsubTest;
        private ProgWorkTime progWorkTime1;
        private ChannelSpindleSpeed channelSpindleSpeed1;
        private System.Windows.Forms.Label positionLabelY;
        private System.Windows.Forms.Label positionLabelZ;
    }
}

