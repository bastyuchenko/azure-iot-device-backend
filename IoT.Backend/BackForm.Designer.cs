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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.btnStopReceiving = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMessageId = new System.Windows.Forms.TextBox();
            this.tbCorrelationId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReceivedMsg = new System.Windows.Forms.TextBox();
            this.btnSendToDevice = new System.Windows.Forms.Button();
            this.tbSentMsg = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tbDTdesired = new System.Windows.Forms.TextBox();
            this.btnReadDT = new System.Windows.Forms.Button();
            this.tbDTRead = new System.Windows.Forms.TextBox();
            this.btnWDesired = new System.Windows.Forms.Button();
            this.tabDirectMethod = new System.Windows.Forms.TabPage();
            this.btnSendRequest_DirectMethod = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabDirectMethod.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabDirectMethod);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(768, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(759, 996);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 963);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Receive from/Send to device";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbReceivedMsg, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnSendToDevice, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbSentMsg, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(745, 957);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnStartReceiving, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnStopReceiving, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(634, 549);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(107, 133);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(3, 3);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(91, 55);
            this.btnStartReceiving.TabIndex = 1;
            this.btnStartReceiving.Text = "Start receiving";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // btnStopReceiving
            // 
            this.btnStopReceiving.Location = new System.Drawing.Point(3, 70);
            this.btnStopReceiving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopReceiving.Name = "btnStopReceiving";
            this.btnStopReceiving.Size = new System.Drawing.Size(90, 57);
            this.btnStopReceiving.TabIndex = 2;
            this.btnStopReceiving.Text = "Stop receiving";
            this.btnStopReceiving.UseVisualStyleBackColor = true;
            this.btnStopReceiving.Click += new System.EventHandler(this.btnStopReceiving_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbMessageId, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbCorrelationId, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(625, 125);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MessageId";
            // 
            // tbMessageId
            // 
            this.tbMessageId.Location = new System.Drawing.Point(315, 3);
            this.tbMessageId.Name = "tbMessageId";
            this.tbMessageId.Size = new System.Drawing.Size(303, 27);
            this.tbMessageId.TabIndex = 5;
            // 
            // tbCorrelationId
            // 
            this.tbCorrelationId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCorrelationId.Location = new System.Drawing.Point(315, 36);
            this.tbCorrelationId.Name = "tbCorrelationId";
            this.tbCorrelationId.Size = new System.Drawing.Size(307, 27);
            this.tbCorrelationId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CorrelationId";
            // 
            // tbReceivedMsg
            // 
            this.tbReceivedMsg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbReceivedMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReceivedMsg.Location = new System.Drawing.Point(3, 548);
            this.tbReceivedMsg.Multiline = true;
            this.tbReceivedMsg.Name = "tbReceivedMsg";
            this.tbReceivedMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReceivedMsg.Size = new System.Drawing.Size(625, 406);
            this.tbReceivedMsg.TabIndex = 4;
            // 
            // btnSendToDevice
            // 
            this.btnSendToDevice.Location = new System.Drawing.Point(634, 3);
            this.btnSendToDevice.Name = "btnSendToDevice";
            this.btnSendToDevice.Size = new System.Drawing.Size(88, 59);
            this.btnSendToDevice.TabIndex = 0;
            this.btnSendToDevice.Text = "Send To Device";
            this.btnSendToDevice.UseVisualStyleBackColor = true;
            this.btnSendToDevice.Click += new System.EventHandler(this.btnSendToDevice_Click);
            // 
            // tbSentMsg
            // 
            this.tbSentMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSentMsg.Location = new System.Drawing.Point(3, 136);
            this.tbSentMsg.Multiline = true;
            this.tbSentMsg.Name = "tbSentMsg";
            this.tbSentMsg.Size = new System.Drawing.Size(625, 406);
            this.tbSentMsg.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(751, 963);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeviceTwin";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel7.Controls.Add(this.tbDTdesired, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnReadDT, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.tbDTRead, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnWDesired, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(751, 963);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // tbDTdesired
            // 
            this.tbDTdesired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDTdesired.Location = new System.Drawing.Point(3, 3);
            this.tbDTdesired.Multiline = true;
            this.tbDTdesired.Name = "tbDTdesired";
            this.tbDTdesired.Size = new System.Drawing.Size(631, 475);
            this.tbDTdesired.TabIndex = 5;
            // 
            // btnReadDT
            // 
            this.btnReadDT.Location = new System.Drawing.Point(640, 484);
            this.btnReadDT.Name = "btnReadDT";
            this.btnReadDT.Size = new System.Drawing.Size(107, 29);
            this.btnReadDT.TabIndex = 1;
            this.btnReadDT.Text = "read Device Twin";
            this.btnReadDT.UseVisualStyleBackColor = true;
            this.btnReadDT.Click += new System.EventHandler(this.btnRReported_Click);
            // 
            // tbDTRead
            // 
            this.tbDTRead.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDTRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDTRead.Location = new System.Drawing.Point(3, 484);
            this.tbDTRead.Multiline = true;
            this.tbDTRead.Name = "tbDTRead";
            this.tbDTRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDTRead.Size = new System.Drawing.Size(631, 476);
            this.tbDTRead.TabIndex = 6;
            this.tbDTRead.WordWrap = false;
            // 
            // btnWDesired
            // 
            this.btnWDesired.Location = new System.Drawing.Point(640, 3);
            this.btnWDesired.Name = "btnWDesired";
            this.btnWDesired.Size = new System.Drawing.Size(107, 29);
            this.btnWDesired.TabIndex = 0;
            this.btnWDesired.Text = "write Desired";
            this.btnWDesired.UseVisualStyleBackColor = true;
            this.btnWDesired.Click += new System.EventHandler(this.btnWDesired_Click);
            // 
            // tabDirectMethod
            // 
            this.tabDirectMethod.BackColor = System.Drawing.Color.SteelBlue;
            this.tabDirectMethod.Controls.Add(this.btnSendRequest_DirectMethod);
            this.tabDirectMethod.Location = new System.Drawing.Point(4, 29);
            this.tabDirectMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDirectMethod.Name = "tabDirectMethod";
            this.tabDirectMethod.Size = new System.Drawing.Size(751, 963);
            this.tabDirectMethod.TabIndex = 3;
            this.tabDirectMethod.Text = "Direct method";
            // 
            // btnSendRequest_DirectMethod
            // 
            this.btnSendRequest_DirectMethod.Location = new System.Drawing.Point(610, 21);
            this.btnSendRequest_DirectMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendRequest_DirectMethod.Name = "btnSendRequest_DirectMethod";
            this.btnSendRequest_DirectMethod.Size = new System.Drawing.Size(86, 125);
            this.btnSendRequest_DirectMethod.TabIndex = 0;
            this.btnSendRequest_DirectMethod.Text = "Send request through direct method";
            this.btnSendRequest_DirectMethod.UseVisualStyleBackColor = true;
            this.btnSendRequest_DirectMethod.Click += new System.EventHandler(this.btnSendRequest_DirectMethod_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Location = new System.Drawing.Point(3, 3);
            this.lbStatus.Multiline = true;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lbStatus.Size = new System.Drawing.Size(759, 996);
            this.lbStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device ID";
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(82, 3);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(225, 27);
            this.tbDeviceId.TabIndex = 1;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(313, 4);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(101, 29);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.65218F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1536, 1055);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClean, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbDeviceId, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1530, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbStatus, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1530, 1002);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1536, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BackForm";
            this.Text = "Backend";
            this.Load += new System.EventHandler(this.BackForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabDirectMethod.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
