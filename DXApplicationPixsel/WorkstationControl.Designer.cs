namespace DXApplicationPixsel
{
    partial class WorkstationControl
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
            panel3 = new System.Windows.Forms.Panel();
            buttonAddPanel = new System.Windows.Forms.Button();
            textBoxPanelCount = new System.Windows.Forms.TextBox();
            textBoxPanelName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dataGridViewWorkstations = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkstations).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1053, 211);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonAddPanel);
            panel3.Controls.Add(textBoxPanelCount);
            panel3.Controls.Add(textBoxPanelName);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(13, 26);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(432, 170);
            panel3.TabIndex = 1;
            // 
            // buttonAddPanel
            // 
            buttonAddPanel.Location = new System.Drawing.Point(62, 107);
            buttonAddPanel.Name = "buttonAddPanel";
            buttonAddPanel.Size = new System.Drawing.Size(317, 40);
            buttonAddPanel.TabIndex = 3;
            buttonAddPanel.Text = "Add";
            buttonAddPanel.UseVisualStyleBackColor = true;
            buttonAddPanel.Click += buttonAddPanel_Click;
            // 
            // textBoxPanelCount
            // 
            textBoxPanelCount.Location = new System.Drawing.Point(62, 70);
            textBoxPanelCount.Name = "textBoxPanelCount";
            textBoxPanelCount.PlaceholderText = "Enter panel count eg 10";
            textBoxPanelCount.Size = new System.Drawing.Size(318, 31);
            textBoxPanelCount.TabIndex = 2;
            // 
            // textBoxPanelName
            // 
            textBoxPanelName.Location = new System.Drawing.Point(62, 33);
            textBoxPanelName.Name = "textBoxPanelName";
            textBoxPanelName.PlaceholderText = "Enter panel count type";
            textBoxPanelName.Size = new System.Drawing.Size(318, 31);
            textBoxPanelName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(62, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Station";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewWorkstations);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 211);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1053, 350);
            panel2.TabIndex = 1;
            // 
            // dataGridViewWorkstations
            // 
            dataGridViewWorkstations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWorkstations.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewWorkstations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewWorkstations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkstations.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewWorkstations.Location = new System.Drawing.Point(0, 0);
            dataGridViewWorkstations.Name = "dataGridViewWorkstations";
            dataGridViewWorkstations.RowHeadersWidth = 62;
            dataGridViewWorkstations.Size = new System.Drawing.Size(1053, 350);
            dataGridViewWorkstations.TabIndex = 0;
            // 
            // WorkstationControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WorkstationControl";
            Size = new System.Drawing.Size(1053, 561);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkstations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewWorkstations;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddPanel;
        private System.Windows.Forms.TextBox textBoxPanelCount;
        private System.Windows.Forms.TextBox textBoxPanelName;
        private System.Windows.Forms.Label label1;
    }
}
