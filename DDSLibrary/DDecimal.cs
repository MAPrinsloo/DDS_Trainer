using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSLibrary
{
    public class DDecimal
    {
        private Random Random = new Random();
        public DDecimal() 
        {

        }
        //Longest dewey decimal value is 331.892829225209712743090511
        //Assigned byte to min & max fraction length as it will not be longer than 255 digits
        //fractionLength will not be > maxFractionLength.
        public string GenerateDD(byte minFractionLength,byte maxFractionLength) 
        {
            byte numberLength = 3;
            byte fractionLength = (byte)Random.Next(minValue: minFractionLength, maxValue: maxFractionLength);
            byte minNumber = 0;
            byte maxNumber = 10;
            String number = "";
            String fraction = "";

            //Generating main number
            for (int i = 0; i < numberLength; i++)
            {
                number = number + Convert.ToString(Random.Next(minValue: minNumber, maxValue: maxNumber));
            }

            //Generating fractional part
            if (fractionLength == 0)
            {
                fraction = "";
            }
            if (fractionLength > 0)
            {
                fraction = ".";
            }
            for (byte i = 0; i < fractionLength; i++)
            {
                int randomNumber = Random.Next(minValue: minNumber, maxValue: maxNumber);

                if ((randomNumber == 0) & (i+1 == fractionLength))
                {
                    minNumber = 1;
                    randomNumber = Random.Next(minValue: minNumber, maxValue: maxNumber);
                }
                
                fraction = fraction + Convert.ToString(randomNumber);
            }
            
            return number+fraction;
        }
    }
}
