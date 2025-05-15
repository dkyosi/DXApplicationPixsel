using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplicationPixsel
{
    public class PanelsInWorkstations
    {
        public int totalCount {  get; set; }
        public Dictionary<string,int> workStationCountByPanel { get; set; }
    }
}
