using System;
namespace MethodOverloading
{

    public class MethodOverloadAdd
    {
        public static int Add(int numX, int numY)
        {
            return numX + numY;
        }

        public static decimal Add(decimal numX, decimal numY)
        {
            return numX + numY;
        }

        public static string Add(int numX, int numY, bool moneyBool)
        {
            var money = (numX + numY);

            if (moneyBool == true && money == 1)
            {
                return $"{money} dollar";
            }
            else if (moneyBool == true && money > 1)
            {
                return $"{money} dollars";
            }
            else
            {
                return "Insufficient Funds";
            }

        }

    }
}

