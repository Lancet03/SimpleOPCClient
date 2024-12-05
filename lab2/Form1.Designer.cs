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
            this.progWorkTime1 = new OPCClientApp.ProgWorkTime();
            this.channelSpindleSpeed1 = new OPCClientApp.ChannelSpindleSpeed();
            this.positionLabelY = new System.Windows.Forms.Label();
            this.positionLabelZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(95, 13);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(78, 13);
            this.labelConnectionStatus.TabIndex = 0;
            this.labelConnectionStatus.Text = "Не соединено";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(9, 6);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(82, 28);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Соединиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(9, 39);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(82, 28);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Отключиться";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelNodeValue
            // 
            this.labelNodeValue.AutoSize = true;
            this.labelNodeValue.Location = new System.Drawing.Point(189, 88);
            this.labelNodeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNodeValue.Name = "labelNodeValue";
            this.labelNodeValue.Size = new System.Drawing.Size(81, 13);
            this.labelNodeValue.TabIndex = 3;
            this.labelNodeValue.Text = "Значение узла";
            // 
            // buttonReadNodeValue
            // 
            this.buttonReadNodeValue.Location = new System.Drawing.Point(9, 74);
            this.buttonReadNodeValue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReadNodeValue.Name = "buttonReadNodeValue";
            this.buttonReadNodeValue.Size = new System.Drawing.Size(176, 41);
            this.buttonReadNodeValue.TabIndex = 4;
            this.buttonReadNodeValue.Text = "Прочитать значение узла";
            this.buttonReadNodeValue.UseVisualStyleBackColor = true;
            this.buttonReadNodeValue.Click += new System.EventHandler(this.buttonReadNodeValue_Click);
            // 
            // ReadPositionBtn
            // 
            this.ReadPositionBtn.Location = new System.Drawing.Point(9, 119);
            this.ReadPositionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadPositionBtn.Name = "ReadPositionBtn";
            this.ReadPositionBtn.Size = new System.Drawing.Size(176, 37);
            this.ReadPositionBtn.TabIndex = 5;
            this.ReadPositionBtn.Text = "Прочитать координаты шпинделя";
            this.ReadPositionBtn.UseVisualStyleBackColor = true;
            this.ReadPositionBtn.Click += new System.EventHandler(this.ReadPositionBtn_Click);
            // 
            // positionLabelX
            // 
            this.positionLabelX.AutoSize = true;
            this.positionLabelX.Location = new System.Drawing.Point(189, 119);
            this.positionLabelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionLabelX.Name = "positionLabelX";
            this.positionLabelX.Size = new System.Drawing.Size(26, 13);
            this.positionLabelX.TabIndex = 6;
            this.positionLabelX.Text = "X = ";
            // 
            // nodesListText
            // 
            this.nodesListText.Location = new System.Drawing.Point(191, 188);
            this.nodesListText.Margin = new System.Windows.Forms.Padding(2);
            this.nodesListText.Name = "nodesListText";
            this.nodesListText.Size = new System.Drawing.Size(401, 266);
            this.nodesListText.TabIndex = 7;
            this.nodesListText.Text = "";
            // 
            // readNodesBtn
            // 
            this.readNodesBtn.Location = new System.Drawing.Point(9, 188);
            this.readNodesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.readNodesBtn.Name = "readNodesBtn";
            this.readNodesBtn.Size = new System.Drawing.Size(176, 24);
            this.readNodesBtn.TabIndex = 8;
            this.readNodesBtn.Text = "Прочитать узлы";
            this.readNodesBtn.UseVisualStyleBackColor = true;
            this.readNodesBtn.Click += new System.EventHandler(this.readNodesBtn_Click);
            // 
            // buttonSubTest
            // 
            this.buttonSubTest.Location = new System.Drawing.Point(194, 13);
            this.buttonSubTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubTest.Name = "buttonSubTest";
            this.buttonSubTest.Size = new System.Drawing.Size(93, 24);
            this.buttonSubTest.TabIndex = 9;
            this.buttonSubTest.Text = "buttonSubTest";
            this.buttonSubTest.UseVisualStyleBackColor = true;
            this.buttonSubTest.Click += new System.EventHandler(this.buttonSubTest_Click);
            // 
            // buttonUnsubTest
            // 
            this.buttonUnsubTest.Location = new System.Drawing.Point(194, 43);
            this.buttonUnsubTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnsubTest.Name = "buttonUnsubTest";
            this.buttonUnsubTest.Size = new System.Drawing.Size(93, 24);
            this.buttonUnsubTest.TabIndex = 10;
            this.buttonUnsubTest.Text = "buttonUnsubTest";
            this.buttonUnsubTest.UseVisualStyleBackColor = true;
            this.buttonUnsubTest.Click += new System.EventHandler(this.buttonUnsubTest_Click);
            // 
            // progWorkTime1
            // 
            this.progWorkTime1.Location = new System.Drawing.Point(371, 23);
            this.progWorkTime1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progWorkTime1.Name = "progWorkTime1";
            this.progWorkTime1.Size = new System.Drawing.Size(201, 145);
            this.progWorkTime1.TabIndex = 11;
            // 
            // channelSpindleSpeed1
            // 
            this.channelSpindleSpeed1.Location = new System.Drawing.Point(79, 462);
            this.channelSpindleSpeed1.Margin = new System.Windows.Forms.Padding(2);
            this.channelSpindleSpeed1.Name = "channelSpindleSpeed1";
            this.channelSpindleSpeed1.Size = new System.Drawing.Size(479, 41);
            this.channelSpindleSpeed1.TabIndex = 12;
            // 
            // positionLabelY
            // 
            this.positionLabelY.AutoSize = true;
            this.positionLabelY.Location = new System.Drawing.Point(189, 132);
            this.positionLabelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionLabelY.Name = "positionLabelY";
            this.positionLabelY.Size = new System.Drawing.Size(26, 13);
            this.positionLabelY.TabIndex = 13;
            this.positionLabelY.Text = "Y = ";
            // 
            // positionLabelZ
            // 
            this.positionLabelZ.AutoSize = true;
            this.positionLabelZ.Location = new System.Drawing.Point(189, 145);
            this.positionLabelZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionLabelZ.Name = "positionLabelZ";
            this.positionLabelZ.Size = new System.Drawing.Size(26, 13);
            this.positionLabelZ.TabIndex = 14;
            this.positionLabelZ.Text = "Z = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 514);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

