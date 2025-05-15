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
    public partial class WorkstationControl : UserControl
    {
        private LoadJsonData _loadJsonData;
        public WorkstationControl()
        {
            InitializeComponent();
            string path = Path.Combine(Application.StartupPath, "InterviewData.json");
            _loadJsonData = new LoadJsonData(path);
            var wsDict = _loadJsonData.LoadPanelsInWorkstations();
            if (wsDict != null)
            {
                dataGridViewWorkstations.DataSource = wsDict.Select(k => new { Make = k.Key, Value = k.Value }).ToList();
            }
        }

        private void buttonAddPanel_Click(object sender, EventArgs e)
        {
            if (textBoxPanelName.Text.Length == 0)
            {
                MessageBox.Show("Please enter panel count type");
                return;
            }
            if (textBoxPanelCount.Text.Length == 0)
            {
                MessageBox.Show("Please panel enter count");
                return;
            }
            _loadJsonData.AddPanelType(textBoxPanelName.Text, Convert.ToInt32(textBoxPanelCount.Text));
            var wsDict = _loadJsonData.LoadPanelsInWorkstations();
            if (wsDict != null)
            {
                dataGridViewWorkstations.DataSource = wsDict.Select(k => new { Make = k.Key, Value = k.Value }).ToList();
            }
        }
    }
}
