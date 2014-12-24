using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Helper_Classes
{
    public static  class CalculatorClass
    {
        public static double ComputeAverage(params double[] ListOfNumbers)
        {
            double xAver = 0;
            xAver = (from n in ListOfNumbers
                      select n).Average();
            return xAver;
        }

        public static double ComputeSumDoubleValues(params double[] ListOfDoubleNumbers)
        {
            double TheSum = 0;
            double i = 0;
            foreach (double i_loopVariable in ListOfDoubleNumbers)
            {
                i = i_loopVariable;
                TheSum += i;
            }
            return TheSum;
        }




        public static int FindTheMinValue(params int[] ListOfNumbers)
        {
            var TheMinOne = (from c in ListOfNumbers
                             select c).Min();

            return TheMinOne;
        }



        public static int FindTheMaxValue(params int[] ListOfNumbers)
        {
            var TheMaxOne = (from c in ListOfNumbers
                             select c).Max();

            return TheMaxOne;
        }




        public static int ComputeSumIntegerValues(params int[] ListOfIntegerNumbers)
        {
            var TheSum = 0;
            var i = 0;
            foreach (int i_loopVariable in ListOfIntegerNumbers)
            {
                i = i_loopVariable;
                TheSum += i;
            }
            return TheSum;
        }




        private static readonly Random GetRandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int MaxNumber)
        {
            lock (syncLock)
            {
                return GetRandom.Next(MaxNumber);
            }
        }
    }
}
