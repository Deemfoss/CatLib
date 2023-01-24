using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CatLib.Services
{
    public class ToolServices
    {
        public static int CaloriesCalc(int weight, string weight_type, string type)
        {
            var wght = (weight_type == "kg") ? Convert.ToDouble(weight) : (Convert.ToDouble(weight) / 2.2);
            var rer = (Math.Pow(wght, 0.75)) * 70;

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
                case "over":
                    rer = rer * 1.1;
                    break;
                case "highActivity":
                    rer = rer * 1.6;
                    break;
                case "pregnancy":
                    rer = rer * 1.8;
                    break;
            }

            return (int)rer;
        }

        public static int CalcAge(int ages, int months)
        {
            int fullAge = 0;
            int middleAges = 0;
            int oldAges = 0;

            if (ages == 1)
            {
                fullAge = 15;
                return fullAge;
            }
            if (ages == 2)
            {
                fullAge = 24;
                return fullAge;
            }

            if (ages > 2)
            {
                for (int i = 0; i < ages; i++)
                {
                    if (i > 2 && i < 16)
                    {
                        middleAges++;
                    }

                    if (i >= 16)
                    {
                        oldAges++;
                    }

                }

                middleAges = (middleAges + 1) * 4;
                oldAges = oldAges * 3;

                if (months > 0)
                {
                    months = Convert.ToInt32(months * 1.3);
                }

                fullAge = middleAges + oldAges + 24 + months;
            }

            if (ages == 0 && months > 0)
            {
                if (months <= 1)
                {
                    fullAge = 1;
                }

                if (months == 2)
                {
                    fullAge = 2;
                }

                if (months > 2)
                {
                    fullAge = System.Convert.ToInt32(months * 1.6);
                }
            }

            return fullAge;
        }
        public static int CalcFood(int productCal, int kCal)
        {
            var foodWeight = 100 * productCal / kCal;
            return foodWeight;
        }

    }
}

