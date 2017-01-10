using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zespolone
{
    class Helper
    {
        
        public float initComplexValue(TextBox textBox)
        {
            float value = 0;
            if (!isEmptyTextBox(textBox))
            {
                value = float.Parse(textBox.Text);
            }

            return value;
        }

        private bool isEmptyTextBox(TextBox textBox)
        {
            bool isEmpty = false;
            if (textBox.Text == "")
            {
                isEmpty = true;
            }

            return isEmpty;
        }

        public void setTextBoxValue(TextBox tB, float value)
        {
            String valStr = Convert.ToString(value);
            tB.Text = valStr;
        }

        public bool isAllValueEqaulsZero(ComplexNumber cN)
        {
            bool isAllValueEqaulsZero = false;
            float rPart = cN.getRealPart();
            float iPart = cN.getImaginaryPart();
            if (rPart == 0 && iPart == 0 )
            {
                isAllValueEqaulsZero = true;
            }

            return isAllValueEqaulsZero;
        }
 

    }
}
