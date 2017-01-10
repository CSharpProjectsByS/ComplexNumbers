using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zespolone
{
    class ComplexNumber
    {
        private float realPart;
        private float imaginaryPart;

        public ComplexNumber(float realPart, float imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public float getRealPart()
        {
            return realPart;
        }

        public float getImaginaryPart()
        {
            return imaginaryPart;   
        }

        public void setRealPart(float realPart)
        {
            this.realPart = realPart;
        }

        public void setImaginaryPart(float imaginaryPart)
        {
            this.imaginaryPart = imaginaryPart;
        }

        public static ComplexNumber operator + (ComplexNumber number1, ComplexNumber number2)
        {
            float rPart = number1.realPart + number2.realPart;
            float iPart = number1.imaginaryPart + number2.imaginaryPart;

            return new ComplexNumber(rPart, iPart); 
        }

        public static ComplexNumber operator - (ComplexNumber number1, ComplexNumber number2)
        {
            float rPart = number1.realPart - number2.realPart;
            float iPart = number1.imaginaryPart - number2.imaginaryPart;

            return new ComplexNumber(rPart, iPart);
        }

        public static bool operator == (ComplexNumber number1, ComplexNumber number2)
        {
            bool isEqual = false;
            if (number1.realPart == number2.realPart)
            {
                if (number1.imaginaryPart == number2.imaginaryPart)
                {
                    isEqual = true;
                }
            }

            return isEqual;
        }

        public static bool operator != (ComplexNumber number1, ComplexNumber number2)
        {
            bool isNotEqual = false;
            if (number1.realPart == number2.realPart)
            {
                if (number1.imaginaryPart != number2.imaginaryPart)
                {
                    isNotEqual = true;
                }
            }
            else
            {
                isNotEqual = true;
            }

            return isNotEqual;
        }

        public static ComplexNumber operator * (ComplexNumber number1, ComplexNumber number2)
        {
            float rPart = number1.realPart * number2.realPart;

            if (number1.imaginaryPart != 0 && number2.imaginaryPart != 0)
            {
                rPart -= number1.imaginaryPart * number2.imaginaryPart;
            }

            float iPart = number1.realPart * number2.imaginaryPart;
            iPart += number1.imaginaryPart * number2.realPart;

            return new ComplexNumber(rPart, iPart);
        }

        public static ComplexNumber operator / (ComplexNumber number1, ComplexNumber number2)
        {
            float iPartN2 = 0;
            if (number2.imaginaryPart != 0) {
                iPartN2 = (-number2.imaginaryPart);
            }

            float rPart = number1.realPart * number2.realPart;

            if (number1.imaginaryPart != 0 && number2.imaginaryPart != 0)
            {
                rPart -= number1.imaginaryPart * iPartN2;
            }

            float iPart = number1.realPart * iPartN2;
            iPart += number1.imaginaryPart * number2.realPart;

            float divider = (number2.realPart * number2.realPart);
            if (iPartN2 != 0)
            {
                divider -= -(iPartN2 * iPartN2); 
            }

            rPart /= divider;
            iPart /= divider;

            return new ComplexNumber(rPart, iPart);
        }




    }
}
