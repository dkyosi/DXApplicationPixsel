using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplicationProj;

namespace DXApplicationPixsel
{
    public partial class DeviceControl : UserControl
    {
        private LoadJsonData _loadJsonData;
        public DeviceControl()
        {
            InitializeComponent();
            string path = Path.Combine(Application.StartupPath, "InterviewData.json");
            _loadJsonData = new LoadJsonData(path);
            var deviceDict = _loadJsonData.LoadDeviceTypes();
            if (deviceDict != null)
            {
                dataGridViewDevices.DataSource = deviceDict.Select(k => new { Make = k.Key, Value = k.Value }).ToList();
            }
        }

        private void buttonAddDevice_Click(object sender, EventArgs e)
        {
            if (textBoxDeviceCountType.Text.Length == 0)
            {
                MessageBox.Show("Please enter device count type");
                return;
            }
            if (textBoxDeviceCount.Text.Length == 0)
            {
                MessageBox.Show("Please enter count");
                return;
            }
            _loadJsonData.AddDeviceType(textBoxDeviceCountType.Text, Convert.ToInt32(textBoxDeviceCount.Text));
            var deviceDict = _loadJsonData.LoadDeviceTypes();
            if (deviceDict != null)
            {
                dataGridViewDevices.DataSource = deviceDict.Select(k => new { Make = k.Key, Value = k.Value }).ToList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDil.Text.Length == 0) {
                MessageBox.Show("Please enter item to delete");
                return;
            }
            _loadJsonData.DeleteDeviceType(textBoxDil.Text);
        }
    }
}
