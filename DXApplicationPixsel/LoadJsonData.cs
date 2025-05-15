using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplicationPixsel;

namespace DXApplicationProj
{
    public class LoadJsonData
    {
        private RootObject _rootObject;
        private readonly string _filePath;

        public LoadJsonData(string filePath)
        {
            _filePath = filePath;
            try
            {
                string json = File.ReadAllText(filePath);
                _rootObject = JsonSerializer.Deserialize<RootObject>(json);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to read data");
                _rootObject = null;
            }
        }

        public Dictionary<string, int> LoadDeviceTypes() {
            return _rootObject.deviceTypes.countByType;
        }

        public Dictionary<string, int> LoadPanelsInWorkstations() { 
            return _rootObject.panelsInWorkstations.workStationCountByPanel;
        }

        public void AddDeviceType(string type, int count) {
            if (_rootObject.deviceTypes.countByType.ContainsKey(type)){
                _rootObject.deviceTypes.countByType[type] += count;
            }
            else
            {
                _rootObject.deviceTypes.countByType[type] = count;
            }
            Save();
        }

        public void AddPanelType(string type, int count)
        {
            if (_rootObject.panelsInWorkstations.workStationCountByPanel.ContainsKey(type))
            {
                _rootObject.panelsInWorkstations.workStationCountByPanel[type] += count;
            }
            else
            {
                _rootObject.panelsInWorkstations.workStationCountByPanel[type] = count;
            }
            Save();
        }

        private void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(_rootObject, options);
            File.WriteAllText(_filePath, json);
        }

    }
}
