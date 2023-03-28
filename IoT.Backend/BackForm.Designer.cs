namespace IoT.Backend
{
    partial class BackForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            btnStartReceiving = new System.Windows.Forms.Button();
            btnStopReceiving = new System.Windows.Forms.Button();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            tbMessageId = new System.Windows.Forms.TextBox();
            tbCorrelationId = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tbReceivedMsg = new System.Windows.Forms.TextBox();
            btnSendToDevice = new System.Windows.Forms.Button();
            tbSentMsg = new System.Windows.Forms.TextBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            tbDTdesired = new System.Windows.Forms.TextBox();
            btnReadDT = new System.Windows.Forms.Button();
            tbDTRead = new System.Windows.Forms.TextBox();
            btnWDesired = new System.Windows.Forms.Button();
            tabDirectMethod = new System.Windows.Forms.TabPage();
            label5 = new System.Windows.Forms.Label();
            tbDirectMethodPayload = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbDirectMethodName = new System.Windows.Forms.TextBox();
            btnSendRequest_DirectMethod = new System.Windows.Forms.Button();
            lbStatus = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tbDeviceId = new System.Windows.Forms.TextBox();
            btnClean = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabDirectMethod.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabDirectMethod);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(672, 2);
            tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(663, 747);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            tabPage1.Controls.Add(tableLayoutPanel4);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Size = new System.Drawing.Size(655, 719);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Receive from/Send to device";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 1, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tbReceivedMsg, 0, 2);
            tableLayoutPanel4.Controls.Add(btnSendToDevice, 1, 0);
            tableLayoutPanel4.Controls.Add(tbSentMsg, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(649, 715);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(btnStartReceiving, 0, 0);
            tableLayoutPanel6.Controls.Add(btnStopReceiving, 0, 1);
            tableLayoutPanel6.Location = new System.Drawing.Point(552, 410);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(94, 100);
            tableLayoutPanel6.TabIndex = 10;
            // 
            // btnStartReceiving
            // 
            btnStartReceiving.Location = new System.Drawing.Point(3, 2);
            btnStartReceiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnStartReceiving.Name = "btnStartReceiving";
            btnStartReceiving.Size = new System.Drawing.Size(80, 41);
            btnStartReceiving.TabIndex = 1;
            btnStartReceiving.Text = "Start receiving";
            btnStartReceiving.UseVisualStyleBackColor = true;
            btnStartReceiving.Click += btnStartReceiving_Click;
            // 
            // btnStopReceiving
            // 
            btnStopReceiving.Location = new System.Drawing.Point(3, 53);
            btnStopReceiving.Name = "btnStopReceiving";
            btnStopReceiving.Size = new System.Drawing.Size(79, 43);
            btnStopReceiving.TabIndex = 2;
            btnStopReceiving.Text = "Stop receiving";
            btnStopReceiving.UseVisualStyleBackColor = true;
            btnStopReceiving.Click += btnStopReceiving_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(tbMessageId, 1, 0);
            tableLayoutPanel5.Controls.Add(tbCorrelationId, 1, 1);
            tableLayoutPanel5.Controls.Add(label3, 0, 1);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new System.Drawing.Size(543, 94);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "MessageId";
            // 
            // tbMessageId
            // 
            tbMessageId.Location = new System.Drawing.Point(274, 2);
            tbMessageId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbMessageId.Name = "tbMessageId";
            tbMessageId.Size = new System.Drawing.Size(266, 23);
            tbMessageId.TabIndex = 5;
            // 
            // tbCorrelationId
            // 
            tbCorrelationId.Dock = System.Windows.Forms.DockStyle.Fill;
            tbCorrelationId.Location = new System.Drawing.Point(274, 29);
            tbCorrelationId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbCorrelationId.Name = "tbCorrelationId";
            tbCorrelationId.Size = new System.Drawing.Size(266, 23);
            tbCorrelationId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 15);
            label3.TabIndex = 8;
            label3.Text = "CorrelationId";
            // 
            // tbReceivedMsg
            // 
            tbReceivedMsg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            tbReceivedMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            tbReceivedMsg.Location = new System.Drawing.Point(3, 409);
            tbReceivedMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbReceivedMsg.Multiline = true;
            tbReceivedMsg.Name = "tbReceivedMsg";
            tbReceivedMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbReceivedMsg.Size = new System.Drawing.Size(543, 304);
            tbReceivedMsg.TabIndex = 4;
            // 
            // btnSendToDevice
            // 
            btnSendToDevice.Location = new System.Drawing.Point(552, 2);
            btnSendToDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSendToDevice.Name = "btnSendToDevice";
            btnSendToDevice.Size = new System.Drawing.Size(77, 44);
            btnSendToDevice.TabIndex = 0;
            btnSendToDevice.Text = "Send To Device";
            btnSendToDevice.UseVisualStyleBackColor = true;
            btnSendToDevice.Click += btnSendToDevice_Click;
            // 
            // tbSentMsg
            // 
            tbSentMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            tbSentMsg.Location = new System.Drawing.Point(3, 102);
            tbSentMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbSentMsg.Multiline = true;
            tbSentMsg.Name = "tbSentMsg";
            tbSentMsg.Size = new System.Drawing.Size(543, 303);
            tbSentMsg.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            tabPage3.Controls.Add(tableLayoutPanel7);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(655, 719);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "DeviceTwin";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel7.Controls.Add(tbDTdesired, 0, 0);
            tableLayoutPanel7.Controls.Add(btnReadDT, 1, 1);
            tableLayoutPanel7.Controls.Add(tbDTRead, 0, 1);
            tableLayoutPanel7.Controls.Add(btnWDesired, 1, 0);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new System.Drawing.Size(655, 719);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // tbDTdesired
            // 
            tbDTdesired.Dock = System.Windows.Forms.DockStyle.Fill;
            tbDTdesired.Location = new System.Drawing.Point(3, 2);
            tbDTdesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbDTdesired.Multiline = true;
            tbDTdesired.Name = "tbDTdesired";
            tbDTdesired.Size = new System.Drawing.Size(549, 355);
            tbDTdesired.TabIndex = 5;
            // 
            // btnReadDT
            // 
            btnReadDT.Location = new System.Drawing.Point(558, 361);
            btnReadDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnReadDT.Name = "btnReadDT";
            btnReadDT.Size = new System.Drawing.Size(94, 22);
            btnReadDT.TabIndex = 1;
            btnReadDT.Text = "read Device Twin";
            btnReadDT.UseVisualStyleBackColor = true;
            btnReadDT.Click += btnRReported_Click;
            // 
            // tbDTRead
            // 
            tbDTRead.BackColor = System.Drawing.SystemColors.InactiveCaption;
            tbDTRead.Dock = System.Windows.Forms.DockStyle.Fill;
            tbDTRead.Location = new System.Drawing.Point(3, 361);
            tbDTRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbDTRead.Multiline = true;
            tbDTRead.Name = "tbDTRead";
            tbDTRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbDTRead.Size = new System.Drawing.Size(549, 356);
            tbDTRead.TabIndex = 6;
            tbDTRead.WordWrap = false;
            // 
            // btnWDesired
            // 
            btnWDesired.Location = new System.Drawing.Point(558, 2);
            btnWDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnWDesired.Name = "btnWDesired";
            btnWDesired.Size = new System.Drawing.Size(94, 22);
            btnWDesired.TabIndex = 0;
            btnWDesired.Text = "write Desired";
            btnWDesired.UseVisualStyleBackColor = true;
            btnWDesired.Click += btnWDesired_Click;
            // 
            // tabDirectMethod
            // 
            tabDirectMethod.BackColor = System.Drawing.Color.SteelBlue;
            tabDirectMethod.Controls.Add(label5);
            tabDirectMethod.Controls.Add(tbDirectMethodPayload);
            tabDirectMethod.Controls.Add(label4);
            tabDirectMethod.Controls.Add(tbDirectMethodName);
            tabDirectMethod.Controls.Add(btnSendRequest_DirectMethod);
            tabDirectMethod.Location = new System.Drawing.Point(4, 24);
            tabDirectMethod.Name = "tabDirectMethod";
            tabDirectMethod.Size = new System.Drawing.Size(655, 719);
            tabDirectMethod.TabIndex = 3;
            tabDirectMethod.Text = "Direct method";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 106);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(128, 15);
            label5.TabIndex = 4;
            label5.Text = "Direct method payload";
            // 
            // tbDirectMethodPayload
            // 
            tbDirectMethodPayload.Location = new System.Drawing.Point(158, 103);
            tbDirectMethodPayload.Multiline = true;
            tbDirectMethodPayload.Name = "tbDirectMethodPayload";
            tbDirectMethodPayload.Size = new System.Drawing.Size(273, 187);
            tbDirectMethodPayload.TabIndex = 3;
            tbDirectMethodPayload.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 15);
            label4.TabIndex = 2;
            label4.Text = "Direct method name";
            // 
            // tbDirectMethodName
            // 
            tbDirectMethodName.Location = new System.Drawing.Point(136, 25);
            tbDirectMethodName.Name = "tbDirectMethodName";
            tbDirectMethodName.Size = new System.Drawing.Size(370, 23);
            tbDirectMethodName.TabIndex = 1;
            tbDirectMethodName.Text = "SetTelemetryInterval";
            // 
            // btnSendRequest_DirectMethod
            // 
            btnSendRequest_DirectMethod.Location = new System.Drawing.Point(534, 16);
            btnSendRequest_DirectMethod.Name = "btnSendRequest_DirectMethod";
            btnSendRequest_DirectMethod.Size = new System.Drawing.Size(75, 94);
            btnSendRequest_DirectMethod.TabIndex = 0;
            btnSendRequest_DirectMethod.Text = "Send request through direct method";
            btnSendRequest_DirectMethod.UseVisualStyleBackColor = true;
            btnSendRequest_DirectMethod.Click += btnSendRequest_DirectMethod_Click;
            // 
            // lbStatus
            // 
            lbStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            lbStatus.Location = new System.Drawing.Point(3, 2);
            lbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lbStatus.Multiline = true;
            lbStatus.Name = "lbStatus";
            lbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            lbStatus.Size = new System.Drawing.Size(663, 747);
            lbStatus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Device ID";
            // 
            // tbDeviceId
            // 
            tbDeviceId.Location = new System.Drawing.Point(65, 2);
            tbDeviceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbDeviceId.Name = "tbDeviceId";
            tbDeviceId.ReadOnly = true;
            tbDeviceId.Size = new System.Drawing.Size(197, 23);
            tbDeviceId.TabIndex = 1;
            tbDeviceId.Text = "iothubx509device1";
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(268, 3);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(88, 22);
            btnClean.TabIndex = 3;
            btnClean.Text = "clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.65218F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1344, 791);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClean, 2, 0);
            tableLayoutPanel2.Controls.Add(tbDeviceId, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1338, 28);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lbStatus, 0, 0);
            tableLayoutPanel3.Controls.Add(tabControl, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 37);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1338, 751);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // BackForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1344, 791);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "BackForm";
            Text = "Backend";
            Load += BackForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tabDirectMethod.ResumeLayout(false);
            tabDirectMethod.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TextBox lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReadDT;
        private System.Windows.Forms.Button btnWDesired;
        private System.Windows.Forms.Button btnStopReceiving;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox tbReceivedMsg;
        private System.Windows.Forms.TextBox tbDTRead;
        private System.Windows.Forms.TextBox tbDTdesired;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMessageId;
        private System.Windows.Forms.TextBox tbCorrelationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendToDevice;
        private System.Windows.Forms.TextBox tbSentMsg;
        private System.Windows.Forms.TabPage tabDirectMethod;
        private System.Windows.Forms.Button btnSendRequest_DirectMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDirectMethodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDirectMethodPayload;
    }
}
