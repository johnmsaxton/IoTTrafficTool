
namespace IoTTrafficTool
{
    partial class frmMain
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
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.udTempBase = new System.Windows.Forms.NumericUpDown();
            this.lblTempBase = new System.Windows.Forms.Label();
            this.lblHumidityBase = new System.Windows.Forms.Label();
            this.udHumidityBase = new System.Windows.Forms.NumericUpDown();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gbConfiguration = new System.Windows.Forms.GroupBox();
            this.udHumidityThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblHumidityThreshold = new System.Windows.Forms.Label();
            this.udTempThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblTempThreshold = new System.Windows.Forms.Label();
            this.udNumEvents = new System.Windows.Forms.NumericUpDown();
            this.lblNumEvents = new System.Windows.Forms.Label();
            this.udSleepTime = new System.Windows.Forms.NumericUpDown();
            this.lblSleepTime = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblNumDevices = new System.Windows.Forms.Label();
            this.udNumDevices = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udTempBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHumidityBase)).BeginInit();
            this.gbConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHumidityThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTempThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSleepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConnection
            // 
            this.txtConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConnection.Location = new System.Drawing.Point(0, 59);
            this.txtConnection.Multiline = true;
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(935, 75);
            this.txtConnection.TabIndex = 0;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnection.Location = new System.Drawing.Point(0, 36);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(132, 20);
            this.lblConnection.TabIndex = 1;
            this.lblConnection.Text = "Connection String";
            // 
            // udTempBase
            // 
            this.udTempBase.Location = new System.Drawing.Point(150, 149);
            this.udTempBase.Name = "udTempBase";
            this.udTempBase.Size = new System.Drawing.Size(90, 27);
            this.udTempBase.TabIndex = 2;
            this.udTempBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udTempBase.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblTempBase
            // 
            this.lblTempBase.AutoSize = true;
            this.lblTempBase.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTempBase.Location = new System.Drawing.Point(5, 148);
            this.lblTempBase.Name = "lblTempBase";
            this.lblTempBase.Size = new System.Drawing.Size(85, 20);
            this.lblTempBase.TabIndex = 3;
            this.lblTempBase.Text = "Temp. Base";
            // 
            // lblHumidityBase
            // 
            this.lblHumidityBase.AutoSize = true;
            this.lblHumidityBase.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHumidityBase.Location = new System.Drawing.Point(351, 148);
            this.lblHumidityBase.Name = "lblHumidityBase";
            this.lblHumidityBase.Size = new System.Drawing.Size(103, 20);
            this.lblHumidityBase.TabIndex = 4;
            this.lblHumidityBase.Text = "Humidty Base";
            // 
            // udHumidityBase
            // 
            this.udHumidityBase.Location = new System.Drawing.Point(497, 144);
            this.udHumidityBase.Name = "udHumidityBase";
            this.udHumidityBase.Size = new System.Drawing.Size(90, 27);
            this.udHumidityBase.TabIndex = 5;
            this.udHumidityBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udHumidityBase.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 276);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(935, 377);
            this.txtOutput.TabIndex = 6;
            // 
            // gbConfiguration
            // 
            this.gbConfiguration.BackColor = System.Drawing.SystemColors.Control;
            this.gbConfiguration.Controls.Add(this.udNumDevices);
            this.gbConfiguration.Controls.Add(this.lblNumDevices);
            this.gbConfiguration.Controls.Add(this.txtDeviceName);
            this.gbConfiguration.Controls.Add(this.lblDeviceName);
            this.gbConfiguration.Controls.Add(this.udHumidityThreshold);
            this.gbConfiguration.Controls.Add(this.lblHumidityThreshold);
            this.gbConfiguration.Controls.Add(this.udTempThreshold);
            this.gbConfiguration.Controls.Add(this.lblTempThreshold);
            this.gbConfiguration.Controls.Add(this.udNumEvents);
            this.gbConfiguration.Controls.Add(this.lblNumEvents);
            this.gbConfiguration.Controls.Add(this.udSleepTime);
            this.gbConfiguration.Controls.Add(this.lblSleepTime);
            this.gbConfiguration.Controls.Add(this.lblTempBase);
            this.gbConfiguration.Controls.Add(this.lblConnection);
            this.gbConfiguration.Controls.Add(this.lblHumidityBase);
            this.gbConfiguration.Controls.Add(this.udHumidityBase);
            this.gbConfiguration.Controls.Add(this.txtConnection);
            this.gbConfiguration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gbConfiguration.Location = new System.Drawing.Point(12, 5);
            this.gbConfiguration.Name = "gbConfiguration";
            this.gbConfiguration.Size = new System.Drawing.Size(935, 265);
            this.gbConfiguration.TabIndex = 7;
            this.gbConfiguration.TabStop = false;
            this.gbConfiguration.Text = "Configuration";
            // 
            // udHumidityThreshold
            // 
            this.udHumidityThreshold.Location = new System.Drawing.Point(497, 184);
            this.udHumidityThreshold.Name = "udHumidityThreshold";
            this.udHumidityThreshold.Size = new System.Drawing.Size(90, 27);
            this.udHumidityThreshold.TabIndex = 13;
            this.udHumidityThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udHumidityThreshold.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblHumidityThreshold
            // 
            this.lblHumidityThreshold.AutoSize = true;
            this.lblHumidityThreshold.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHumidityThreshold.Location = new System.Drawing.Point(351, 188);
            this.lblHumidityThreshold.Name = "lblHumidityThreshold";
            this.lblHumidityThreshold.Size = new System.Drawing.Size(140, 20);
            this.lblHumidityThreshold.TabIndex = 12;
            this.lblHumidityThreshold.Text = "Humidty Threshold";
            // 
            // udTempThreshold
            // 
            this.udTempThreshold.Location = new System.Drawing.Point(138, 184);
            this.udTempThreshold.Name = "udTempThreshold";
            this.udTempThreshold.Size = new System.Drawing.Size(90, 27);
            this.udTempThreshold.TabIndex = 11;
            this.udTempThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udTempThreshold.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // lblTempThreshold
            // 
            this.lblTempThreshold.AutoSize = true;
            this.lblTempThreshold.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTempThreshold.Location = new System.Drawing.Point(4, 188);
            this.lblTempThreshold.Name = "lblTempThreshold";
            this.lblTempThreshold.Size = new System.Drawing.Size(122, 20);
            this.lblTempThreshold.TabIndex = 10;
            this.lblTempThreshold.Text = "Temp. Threshold";
            // 
            // udNumEvents
            // 
            this.udNumEvents.Location = new System.Drawing.Point(840, 184);
            this.udNumEvents.Name = "udNumEvents";
            this.udNumEvents.Size = new System.Drawing.Size(90, 27);
            this.udNumEvents.TabIndex = 9;
            this.udNumEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumEvents.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNumEvents
            // 
            this.lblNumEvents.AutoSize = true;
            this.lblNumEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumEvents.Location = new System.Drawing.Point(767, 188);
            this.lblNumEvents.Name = "lblNumEvents";
            this.lblNumEvents.Size = new System.Drawing.Size(66, 20);
            this.lblNumEvents.TabIndex = 8;
            this.lblNumEvents.Text = "# Events";
            // 
            // udSleepTime
            // 
            this.udSleepTime.Location = new System.Drawing.Point(840, 144);
            this.udSleepTime.Name = "udSleepTime";
            this.udSleepTime.Size = new System.Drawing.Size(90, 27);
            this.udSleepTime.TabIndex = 7;
            this.udSleepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSleepTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblSleepTime
            // 
            this.lblSleepTime.AutoSize = true;
            this.lblSleepTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSleepTime.Location = new System.Drawing.Point(730, 148);
            this.lblSleepTime.Name = "lblSleepTime";
            this.lblSleepTime.Size = new System.Drawing.Size(104, 20);
            this.lblSleepTime.TabIndex = 6;
            this.lblSleepTime.Text = "Sleep (in secs)";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(413, 672);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 29);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create IoT Traffic";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeviceName.Location = new System.Drawing.Point(4, 228);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(100, 20);
            this.lblDeviceName.TabIndex = 14;
            this.lblDeviceName.Text = "Device Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(138, 228);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(449, 27);
            this.txtDeviceName.TabIndex = 15;
            this.txtDeviceName.Text = "temp";
            // 
            // lblNumDevices
            // 
            this.lblNumDevices.AutoSize = true;
            this.lblNumDevices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumDevices.Location = new System.Drawing.Point(759, 228);
            this.lblNumDevices.Name = "lblNumDevices";
            this.lblNumDevices.Size = new System.Drawing.Size(74, 20);
            this.lblNumDevices.TabIndex = 16;
            this.lblNumDevices.Text = "# Devices";
            // 
            // udNumDevices
            // 
            this.udNumDevices.Location = new System.Drawing.Point(840, 224);
            this.udNumDevices.Name = "udNumDevices";
            this.udNumDevices.Size = new System.Drawing.Size(90, 27);
            this.udNumDevices.TabIndex = 17;
            this.udNumDevices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumDevices.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 718);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.udTempBase);
            this.Controls.Add(this.gbConfiguration);
            this.Name = "frmMain";
            this.Text = "IoT Traffic Tool";
            ((System.ComponentModel.ISupportInitialize)(this.udTempBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHumidityBase)).EndInit();
            this.gbConfiguration.ResumeLayout(false);
            this.gbConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHumidityThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTempThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSleepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.NumericUpDown udTempBase;
        private System.Windows.Forms.Label lblTempBase;
        private System.Windows.Forms.Label lblHumidityBase;
        private System.Windows.Forms.NumericUpDown udHumidityBase;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox gbConfiguration;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown udSleepTime;
        private System.Windows.Forms.Label lblSleepTime;
        private System.Windows.Forms.NumericUpDown udNumEvents;
        private System.Windows.Forms.Label lblNumEvents;
        private System.Windows.Forms.NumericUpDown udHumidityThreshold;
        private System.Windows.Forms.Label lblHumidityThreshold;
        private System.Windows.Forms.NumericUpDown udTempThreshold;
        private System.Windows.Forms.Label lblTempThreshold;
        private System.Windows.Forms.NumericUpDown udNumDevices;
        private System.Windows.Forms.Label lblNumDevices;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblDeviceName;
    }
}

