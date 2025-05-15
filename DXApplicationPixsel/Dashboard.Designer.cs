namespace DXApplicationPixsel
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new System.Windows.Forms.Panel();
            contentPanel = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(contentPanel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(948, 406);
            panel1.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Location = new System.Drawing.Point(158, 75);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new System.Drawing.Size(790, 331);
            contentPanel.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(simpleButton2);
            panel3.Controls.Add(simpleButton1);
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(158, 331);
            panel3.TabIndex = 1;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
            simpleButton2.Appearance.Options.UseForeColor = true;
            simpleButton2.Location = new System.Drawing.Point(23, 92);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton2.Size = new System.Drawing.Size(100, 51);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Workstations";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new System.Drawing.Point(23, 25);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new System.Drawing.Size(100, 51);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Devices";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(svgImageBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(948, 75);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
            label4.Location = new System.Drawing.Point(421, 26);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(141, 29);
            label4.TabIndex = 4;
            label4.Text = "Dashboard";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(652, 44);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(172, 19);
            label3.TabIndex = 3;
            label3.Text = "kyosidavid@gmail.com";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(733, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 19);
            label2.TabIndex = 2;
            label2.Text = "David Kyosi";
            // 
            // svgImageBox1
            // 
            svgImageBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            svgImageBox1.Location = new System.Drawing.Point(844, 12);
            svgImageBox1.Name = "svgImageBox1";
            svgImageBox1.Size = new System.Drawing.Size(92, 51);
            svgImageBox1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("svgImageBox1.SvgImage");
            svgImageBox1.TabIndex = 1;
            svgImageBox1.Text = "svgImageBox1";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 34);
            label1.TabIndex = 0;
            label1.Text = "LOGO";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(948, 406);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel contentPanel;
    }
}

