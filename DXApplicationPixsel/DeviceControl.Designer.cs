namespace DXApplicationPixsel
{
    partial class DeviceControl
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
            panel1 = new System.Windows.Forms.Panel();
            textBoxDiv = new System.Windows.Forms.TextBox();
            buttonDelete = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            buttonAddDevice = new System.Windows.Forms.Button();
            textBoxDeviceCount = new System.Windows.Forms.TextBox();
            textBoxDeviceCountType = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dataGridViewDevices = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevices).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDiv);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1035, 188);
            panel1.TabIndex = 0;
            // 
            // textBoxDiv
            // 
            textBoxDiv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBoxDiv.Location = new System.Drawing.Point(828, 68);
            textBoxDiv.Name = "textBoxDiv";
            textBoxDiv.PlaceholderText = "Enter device type";
            textBoxDiv.Size = new System.Drawing.Size(184, 31);
            textBoxDiv.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonDelete.Location = new System.Drawing.Point(828, 130);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(184, 34);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete Device";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonAddDevice);
            panel3.Controls.Add(textBoxDeviceCount);
            panel3.Controls.Add(textBoxDeviceCountType);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(10, 16);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(432, 166);
            panel3.TabIndex = 0;
            // 
            // buttonAddDevice
            // 
            buttonAddDevice.Location = new System.Drawing.Point(62, 107);
            buttonAddDevice.Name = "buttonAddDevice";
            buttonAddDevice.Size = new System.Drawing.Size(317, 40);
            buttonAddDevice.TabIndex = 3;
            buttonAddDevice.Text = "Add";
            buttonAddDevice.UseVisualStyleBackColor = true;
            buttonAddDevice.Click += buttonAddDevice_Click;
            // 
            // textBoxDeviceCount
            // 
            textBoxDeviceCount.Location = new System.Drawing.Point(62, 70);
            textBoxDeviceCount.Name = "textBoxDeviceCount";
            textBoxDeviceCount.PlaceholderText = "Enter count eg 10";
            textBoxDeviceCount.Size = new System.Drawing.Size(318, 31);
            textBoxDeviceCount.TabIndex = 2;
            // 
            // textBoxDeviceCountType
            // 
            textBoxDeviceCountType.Location = new System.Drawing.Point(62, 33);
            textBoxDeviceCountType.Name = "textBoxDeviceCountType";
            textBoxDeviceCountType.PlaceholderText = "Ente device count type";
            textBoxDeviceCountType.Size = new System.Drawing.Size(318, 31);
            textBoxDeviceCountType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(62, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Device";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewDevices);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 188);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(10);
            panel2.Size = new System.Drawing.Size(1035, 437);
            panel2.TabIndex = 1;
            // 
            // dataGridViewDevices
            // 
            dataGridViewDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDevices.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewDevices.GridColor = System.Drawing.Color.LightGray;
            dataGridViewDevices.Location = new System.Drawing.Point(10, 10);
            dataGridViewDevices.Name = "dataGridViewDevices";
            dataGridViewDevices.RowHeadersWidth = 62;
            dataGridViewDevices.Size = new System.Drawing.Size(1015, 417);
            dataGridViewDevices.TabIndex = 0;
            // 
            // DeviceControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DeviceControl";
            Size = new System.Drawing.Size(1035, 625);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeviceCount;
        private System.Windows.Forms.TextBox textBoxDeviceCountType;
        private System.Windows.Forms.Button buttonAddDevice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDiv;
    }
}
