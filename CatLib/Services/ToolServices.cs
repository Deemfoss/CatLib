using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatLib.Services
{
    public class ToolServices
    {
        public static int CaloriesCalc(string weight, string weight_type, string type)
        {
            var wght = (weight_type == "kg") ? Convert.ToDouble(weight) : (Convert.ToDouble(weight) / 2.2);
            var rer= (Math.Pow(wght, 0.75)) * 70;

            switch (type)
            {
                case "neutered":
                    rer = rer * 1.2;
                    break;
                case "intact":
                    rer = rer * 1.4;
                    break;
                case "obesse":
                    rer = rer * 1;
                    break;
                case "loss":
                    rer = rer * 0.8;
                    break;
                case "kittens":
                    rer = rer * 2.5;
                    break;
            }

            return (int)rer;
        }
    }
}
