

using System.Data;
namespace projectCalculator

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private String storeResult = "";



        private void btnZerro_Click(object sender, EventArgs e)
        {

            storeResult = storeResult + btnZerro.Text;
            textBoxResult.Text = storeResult;


        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnOne.Text;
            textBoxResult.Text = storeResult;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnTwo.Text;
            textBoxResult.Text = storeResult;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnThree.Text;
            textBoxResult.Text = storeResult;

        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnFour.Text;
            textBoxResult.Text = storeResult;


        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnFive.Text;
            textBoxResult.Text = storeResult;

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnSix.Text;
            textBoxResult.Text = storeResult;

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnSeven.Text;
            textBoxResult.Text = storeResult;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnEight.Text;
            textBoxResult.Text = storeResult;


        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnNine.Text;
            textBoxResult.Text = storeResult;


        }


        //for Equal(=) button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string formatter = storeResult.ToString();// it means 1+2;here 


            //check format; 1++1, 1.1./1 is not valid.
            //it must be 1+1,1.1/1
            try
            {
                textBoxResult.Text = new DataTable().Compute(formatter, null).ToString();
                storeResult = textBoxResult.Text;
            }
            catch (Exception ex)
            {
                textBoxResult.Text = "syntex Error,check Again";
                storeResult = "";
            }



        }

        //clear all 
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            storeResult = "";

        }

        //Clear entry,
        private void btnClearEntry_Click(object sender, EventArgs e)
        {

            //so storeResult lenght is decrease 1 and elear only 1(last) entry
            if (storeResult.Length > 0)
            {
                storeResult = storeResult.Remove(storeResult.Length - 1, 1);
            }
            textBoxResult.Text = storeResult;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnPlus.Text;
            textBoxResult.Text = storeResult;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnMinus.Text;
            textBoxResult.Text = storeResult;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + "*";
            textBoxResult.Text = storeResult;
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnDivided.Text;
            textBoxResult.Text = storeResult;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            storeResult = storeResult + btnDot.Text;
            textBoxResult.Text = storeResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
