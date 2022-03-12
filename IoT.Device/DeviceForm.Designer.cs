namespace IoT.Device
{
    partial class Device
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
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStatusSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbStartReceiving = new System.Windows.Forms.TextBox();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.tbAssignedHub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(123, 13);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(567, 27);
            this.tbMsg.TabIndex = 0;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(696, 12);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(94, 29);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send msg to IoT";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 29);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStatusSend
            // 
            this.lbStatusSend.Multiline = true;
            this.lbStatusSend.Height = 20;
            this.lbStatusSend.Location = new System.Drawing.Point(23, 65);
            this.lbStatusSend.Name = "lbStatusSend";
            this.lbStatusSend.Size = new System.Drawing.Size(767, 564);
            this.lbStatusSend.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 669);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSendMsg);
            this.tabPage1.Controls.Add(this.tbMsg);
            this.tabPage1.Controls.Add(this.lbStatusSend);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send to IoT Hub";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbStartReceiving);
            this.tabPage2.Controls.Add(this.btnStartReceiving);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receive from IoT Hub";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbStartReceiving
            // 
            this.lbStartReceiving.Multiline = true;
            this.lbStartReceiving.Height = 20;
            this.lbStartReceiving.Location = new System.Drawing.Point(6, 64);
            this.lbStartReceiving.Name = "lbStartReceiving";
            this.lbStartReceiving.Size = new System.Drawing.Size(798, 564);
            this.lbStartReceiving.TabIndex = 1;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(10, 20);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(94, 29);
            this.btnStartReceiving.TabIndex = 0;
            this.btnStartReceiving.Text = "Receive";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(206, 15);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(181, 27);
            this.tbDeviceId.TabIndex = 0;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // tbAssignedHub
            // 
            this.tbAssignedHub.Location = new System.Drawing.Point(523, 15);
            this.tbAssignedHub.Name = "tbAssignedHub";
            this.tbAssignedHub.ReadOnly = true;
            this.tbAssignedHub.Size = new System.Drawing.Size(303, 27);
            this.tbAssignedHub.TabIndex = 0;
            this.tbAssignedHub.Text = "anton-iot-hub-first.azure-devices.net";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Device Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Hub";
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 741);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbAssignedHub);
            this.Controls.Add(this.tbDeviceId);
            this.Name = "Device";
            this.Text = "Device";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox lbStatusSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.TextBox tbAssignedHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TextBox lbStartReceiving;
    }
}
