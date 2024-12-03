﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcPCM_Connect_Global
{
    public static class FractionConverter
    {
        public static string Convert(decimal value)
        {
            // get the whole value of the fraction
            decimal mWhole = Math.Truncate(value);

            // get the fractional value
            decimal mFraction = value - mWhole;

            // initialize a numerator and denomintar
            uint mNumerator = 0;
            uint mDenomenator = 1;

            // ensure that there is actual a fraction
            if (mFraction > 0m)
            {
                // convert the value to a string so that you can count the number of decimal places there are
                string strFraction = mFraction.ToString().Remove(0, 2);

                // store teh number of decimal places
                uint intFractLength = (uint)strFraction.Length;

                // set the numerator to have the proper amount of zeros
                mNumerator = (uint)Math.Pow(10, intFractLength);

                // parse the fraction value to an integer that equals [fraction value] * 10^[number of decimal places]
                uint.TryParse(strFraction, out mDenomenator);

                // get the greatest common divisor for both numbers
                uint gcd = GreatestCommonDivisor(mDenomenator, mNumerator);

                // divide the numerator and the denominator by the gratest common divisor
                mNumerator = mNumerator / gcd;
                mDenomenator = mDenomenator / gcd;
            }

            // create a string builder
            StringBuilder mBuilder = new StringBuilder();

            // add the whole number if it's greater than 0
            if (mWhole > 0m)
            {
                mBuilder.Append(mWhole);
            }

            // add the fraction if it's greater than 0m
            if (mFraction > 0m)
            {
                if (mBuilder.Length > 0)
                {
                    mBuilder.Append(" ");
                }

                mBuilder.Append(mDenomenator);
                mBuilder.Append("/");
                mBuilder.Append(mNumerator);
            }

            return mBuilder.ToString();
        }

        public static decimal Convert(string value)
        {
            return 0m;
        }

        private static uint GreatestCommonDivisor(uint valA, uint valB)
        {
            // return 0 if both values are 0 (no GSD)
            if (valA == 0 &&
              valB == 0)
            {
                return 0;
            }
            // return value b if only a == 0
            else if (valA == 0 &&
                  valB != 0)
            {
                return valB;
            }
            // return value a if only b == 0
            else if (valA != 0 && valB == 0)
            {
                return valA;
            }
            // actually find the GSD
            else
            {
                uint first = valA;
                uint second = valB;

                while (first != second)
                {
                    if (first > second)
                    {
                        first = first - second;
                    }
                    else
                    {
                        second = second - first;
                    }
                }

                return first;
            }

        }
    }
}