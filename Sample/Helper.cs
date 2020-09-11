using Braincase.USGS.DEM;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sample
{
    public class Helper
    {
        //public static void MapBRecord(BRecord _bRecord)
        //{
        //    _bRecord.elevations
        //}

        public static Color GetGreenYellowRedByPropotion(double value ,double max)
        {
            const int Space = 255 * 2;
            double propotion = value / max;
            if(propotion <= 0.5)
            {
                return Color.FromArgb((int)(propotion * Space), 255, 0);
            }
            else
            {
                return Color.FromArgb(255, (int)(propotion * Space) - 255, 0);
            }
        }
    }
}
