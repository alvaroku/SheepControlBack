using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils
{
    public class Utils
    {
        public static string CalculateDoseRecomended(string indicatedDose,float weight)
        {
            float quantityVolume = float.Parse(indicatedDose.Split("/")[0].Split("|")[0]);
            string unitVolume = indicatedDose.Split("/")[0].Split("|")[1];

            float quantityWeight = float.Parse(indicatedDose.Split("/")[1].Split("|")[0]);

            float doseRecomended = (weight * quantityVolume) / quantityWeight;

            return doseRecomended + "" + unitVolume;
        }
    }
}
