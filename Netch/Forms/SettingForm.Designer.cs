﻿namespace Netch.Forms
{
	partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.PortGroupBox = new System.Windows.Forms.GroupBox();
            this.AllowDevicesCheckBox = new System.Windows.Forms.CheckBox();
            this.HTTPPortLabel = new System.Windows.Forms.Label();
            this.HTTPPortTextBox = new System.Windows.Forms.TextBox();
            this.Socks5PortLabel = new System.Windows.Forms.Label();
            this.Socks5PortTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPGroupBox = new System.Windows.Forms.GroupBox();
            this.TUNTAPUseCustomDNSCheckBox = new System.Windows.Forms.CheckBox();
            this.TUNTAPDNSLabel = new System.Windows.Forms.Label();
            this.TUNTAPDNSTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPGatewayLabel = new System.Windows.Forms.Label();
            this.TUNTAPGatewayTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPNetmaskLabel = new System.Windows.Forms.Label();
            this.TUNTAPNetmaskTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPAddressLabel = new System.Windows.Forms.Label();
            this.TUNTAPAddressTextBox = new System.Windows.Forms.TextBox();
            this.ControlButton = new System.Windows.Forms.Button();
            this.GlobalBypassIPsButton = new System.Windows.Forms.Button();
            this.PortGroupBox.SuspendLayout();
            this.TUNTAPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortGroupBox
            // 
            this.PortGroupBox.Controls.Add(this.AllowDevicesCheckBox);
            this.PortGroupBox.Controls.Add(this.HTTPPortLabel);
            this.PortGroupBox.Controls.Add(this.HTTPPortTextBox);
            this.PortGroupBox.Controls.Add(this.Socks5PortLabel);
            this.PortGroupBox.Controls.Add(this.Socks5PortTextBox);
            this.PortGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PortGroupBox.Name = "PortGroupBox";
            this.PortGroupBox.Size = new System.Drawing.Size(420, 106);
            this.PortGroupBox.TabIndex = 0;
            this.PortGroupBox.TabStop = false;
            this.PortGroupBox.Text = "Local Port";
            // 
            // AllowDevicesCheckBox
            // 
            this.AllowDevicesCheckBox.AutoSize = true;
            this.AllowDevicesCheckBox.Location = new System.Drawing.Point(120, 80);
            this.AllowDevicesCheckBox.Name = "AllowDevicesCheckBox";
            this.AllowDevicesCheckBox.Size = new System.Drawing.Size(206, 21);
            this.AllowDevicesCheckBox.TabIndex = 13;
            this.AllowDevicesCheckBox.Text = "Allow other Devices to connect";
            this.AllowDevicesCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllowDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // HTTPPortLabel
            // 
            this.HTTPPortLabel.AutoSize = true;
            this.HTTPPortLabel.Location = new System.Drawing.Point(9, 54);
            this.HTTPPortLabel.Name = "HTTPPortLabel";
            this.HTTPPortLabel.Size = new System.Drawing.Size(38, 17);
            this.HTTPPortLabel.TabIndex = 3;
            this.HTTPPortLabel.Text = "HTTP";
            // 
            // HTTPPortTextBox
            // 
            this.HTTPPortTextBox.Location = new System.Drawing.Point(120, 51);
            this.HTTPPortTextBox.Name = "HTTPPortTextBox";
            this.HTTPPortTextBox.Size = new System.Drawing.Size(294, 23);
            this.HTTPPortTextBox.TabIndex = 2;
            this.HTTPPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Socks5PortLabel
            // 
            this.Socks5PortLabel.AutoSize = true;
            this.Socks5PortLabel.Location = new System.Drawing.Point(9, 25);
            this.Socks5PortLabel.Name = "Socks5PortLabel";
            this.Socks5PortLabel.Size = new System.Drawing.Size(49, 17);
            this.Socks5PortLabel.TabIndex = 1;
            this.Socks5PortLabel.Text = "Socks5";
            // 
            // Socks5PortTextBox
            // 
            this.Socks5PortTextBox.Location = new System.Drawing.Point(120, 22);
            this.Socks5PortTextBox.Name = "Socks5PortTextBox";
            this.Socks5PortTextBox.Size = new System.Drawing.Size(294, 23);
            this.Socks5PortTextBox.TabIndex = 0;
            this.Socks5PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGroupBox
            // 
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPUseCustomDNSCheckBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPDNSLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPDNSTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPGatewayLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPGatewayTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPNetmaskLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPNetmaskTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPAddressLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPAddressTextBox);
            this.TUNTAPGroupBox.Location = new System.Drawing.Point(12, 123);
            this.TUNTAPGroupBox.Name = "TUNTAPGroupBox";
            this.TUNTAPGroupBox.Size = new System.Drawing.Size(420, 165);
            this.TUNTAPGroupBox.TabIndex = 3;
            this.TUNTAPGroupBox.TabStop = false;
            this.TUNTAPGroupBox.Text = "TUN/TAP";
            // 
            // TUNTAPUseCustomDNSCheckBox
            // 
            this.TUNTAPUseCustomDNSCheckBox.AutoSize = true;
            this.TUNTAPUseCustomDNSCheckBox.Location = new System.Drawing.Point(120, 138);
            this.TUNTAPUseCustomDNSCheckBox.Name = "TUNTAPUseCustomDNSCheckBox";
            this.TUNTAPUseCustomDNSCheckBox.Size = new System.Drawing.Size(127, 21);
            this.TUNTAPUseCustomDNSCheckBox.TabIndex = 12;
            this.TUNTAPUseCustomDNSCheckBox.Text = "Use Custom DNS";
            this.TUNTAPUseCustomDNSCheckBox.UseVisualStyleBackColor = true;
            this.TUNTAPUseCustomDNSCheckBox.CheckedChanged += new System.EventHandler(this.TUNTAPUseCustomDNSCheckBox_CheckedChanged);
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.Location = new System.Drawing.Point(9, 112);
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.Size = new System.Drawing.Size(34, 17);
            this.TUNTAPDNSLabel.TabIndex = 7;
            this.TUNTAPDNSLabel.Text = "DNS";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.Location = new System.Drawing.Point(120, 109);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.Size = new System.Drawing.Size(294, 23);
            this.TUNTAPDNSTextBox.TabIndex = 10;
            this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Location = new System.Drawing.Point(9, 83);
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.Size = new System.Drawing.Size(57, 17);
            this.TUNTAPGatewayLabel.TabIndex = 5;
            this.TUNTAPGatewayLabel.Text = "Gateway";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Location = new System.Drawing.Point(120, 80);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.Size = new System.Drawing.Size(294, 23);
            this.TUNTAPGatewayTextBox.TabIndex = 8;
            this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            this.TUNTAPNetmaskLabel.AutoSize = true;
            this.TUNTAPNetmaskLabel.Location = new System.Drawing.Point(9, 54);
            this.TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            this.TUNTAPNetmaskLabel.Size = new System.Drawing.Size(60, 17);
            this.TUNTAPNetmaskLabel.TabIndex = 3;
            this.TUNTAPNetmaskLabel.Text = "Netmask";
            // 
            // TUNTAPNetmaskTextBox
            // 
            this.TUNTAPNetmaskTextBox.Location = new System.Drawing.Point(120, 51);
            this.TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            this.TUNTAPNetmaskTextBox.Size = new System.Drawing.Size(294, 23);
            this.TUNTAPNetmaskTextBox.TabIndex = 6;
            this.TUNTAPNetmaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Location = new System.Drawing.Point(9, 25);
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.Size = new System.Drawing.Size(56, 17);
            this.TUNTAPAddressLabel.TabIndex = 1;
            this.TUNTAPAddressLabel.Text = "Address";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Location = new System.Drawing.Point(120, 22);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.Size = new System.Drawing.Size(294, 23);
            this.TUNTAPAddressTextBox.TabIndex = 4;
            this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(357, 294);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(75, 23);
            this.ControlButton.TabIndex = 16;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // GlobalBypassIPsButton
            // 
            this.GlobalBypassIPsButton.Location = new System.Drawing.Point(12, 294);
            this.GlobalBypassIPsButton.Name = "GlobalBypassIPsButton";
            this.GlobalBypassIPsButton.Size = new System.Drawing.Size(128, 23);
            this.GlobalBypassIPsButton.TabIndex = 14;
            this.GlobalBypassIPsButton.Text = "Global Bypass IPs";
            this.GlobalBypassIPsButton.UseVisualStyleBackColor = true;
            this.GlobalBypassIPsButton.Click += new System.EventHandler(this.GlobalBypassIPsButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(444, 331);
            this.Controls.Add(this.PortGroupBox);
            this.Controls.Add(this.GlobalBypassIPsButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.TUNTAPGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.PortGroupBox.ResumeLayout(false);
            this.PortGroupBox.PerformLayout();
            this.TUNTAPGroupBox.ResumeLayout(false);
            this.TUNTAPGroupBox.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.GroupBox PortGroupBox;
        private System.Windows.Forms.Label HTTPPortLabel;
        private System.Windows.Forms.TextBox HTTPPortTextBox;
        private System.Windows.Forms.Label Socks5PortLabel;
        private System.Windows.Forms.TextBox Socks5PortTextBox;
        private System.Windows.Forms.GroupBox TUNTAPGroupBox;
		private System.Windows.Forms.TextBox TUNTAPAddressTextBox;
		private System.Windows.Forms.Label TUNTAPAddressLabel;
		private System.Windows.Forms.TextBox TUNTAPNetmaskTextBox;
		private System.Windows.Forms.Label TUNTAPNetmaskLabel;
		private System.Windows.Forms.TextBox TUNTAPGatewayTextBox;
		private System.Windows.Forms.Label TUNTAPGatewayLabel;
		private System.Windows.Forms.Label TUNTAPDNSLabel;
		private System.Windows.Forms.TextBox TUNTAPDNSTextBox;
		private System.Windows.Forms.Button ControlButton;
		private System.Windows.Forms.Button GlobalBypassIPsButton;
		private System.Windows.Forms.CheckBox TUNTAPUseCustomDNSCheckBox;
        private System.Windows.Forms.CheckBox AllowDevicesCheckBox;
    }
}