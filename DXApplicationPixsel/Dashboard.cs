using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplicationPixsel
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadControl(new DeviceControl());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadControl(new DeviceControl());
        }

        private void LoadControl(UserControl userControl)
        {
            contentPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userControl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadControl(new WorkstationControl());
        }
    }
}
