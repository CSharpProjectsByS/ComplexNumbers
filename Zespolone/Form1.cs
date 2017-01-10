using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zespolone
{
    public partial class Form1 : Form
    {
        private ComplexNumber complexNumber1;
        private ComplexNumber complexNumber2;
        private ComplexNumber complexNumberResult;
        private Helper helper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            complexNumber1 = new ComplexNumber(0, 0);
            complexNumber2 = new ComplexNumber(0, 0);
            complexNumberResult = new ComplexNumber(0, 0);

            helper = new Zespolone.Helper();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            initValueNumber1And2();
            complexNumberResult = complexNumber1 + complexNumber2;

            float rPart = complexNumberResult.getRealPart();
            float iPart = complexNumberResult.getImaginaryPart();

            SetNumberResult(rPart, iPart);
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            initValueNumber1And2();
            complexNumberResult = complexNumber1 - complexNumber2;

            float rPart = complexNumberResult.getRealPart();
            float iPart = complexNumberResult.getImaginaryPart();

            SetNumberResult(rPart, iPart);
        }

        private void MuliplicationButton_Click(object sender, EventArgs e)
        {
            initValueNumber1And2();
            complexNumberResult = complexNumber1 * complexNumber2;

            float rPart = complexNumberResult.getRealPart();
            float iPart = complexNumberResult.getImaginaryPart();

            SetNumberResult(rPart, iPart);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            initValueNumber1And2();
            if (!helper.isAllValueEqaulsZero(complexNumber2))
            {
                complexNumberResult = complexNumber1 / complexNumber2;

                float rPart = complexNumberResult.getRealPart();
                float iPart = complexNumberResult.getImaginaryPart();

                SetNumberResult(rPart, iPart);
            }
            else
            {
                MessageBox.Show("Nie można dzielić przez zero");
            }
        }



        private void initValueNumber1And2()
        {
            complexNumber1 = initNumber(ReNumber1, ImNumber1);
            complexNumber2 = initNumber(ReNumber2, ImNumber2);
        }

        private ComplexNumber initNumber(TextBox tb1, TextBox tb2)
        {
            float rPart = helper.initComplexValue(tb1);
            float iPart = helper.initComplexValue(tb2);

            return new ComplexNumber(rPart, iPart);
        }

        private void SetNumberResult(float rPart, float iPart)
        {
            helper.setTextBoxValue(ReResult, rPart);
            helper.setTextBoxValue(ImResult, iPart);
        }

        private void ReNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            initValueNumber1And2();
            String message = "";
            if (complexNumber1 == complexNumber2)
            {
                message = "Liczby są sobie równe.";
            }
            else
            {
                message = "Liczby nie są sobie równe.";
            }

            MessageBox.Show(this, message);
        }

    }
}
