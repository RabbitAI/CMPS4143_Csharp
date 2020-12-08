/*
 *          Name: Christian Douglas
 *          Program: Proj3_BinaryConv_Douglas
 *          Date: 9 September, 2020
 *          Purpose: The program reads in a value from the binInputVal
 *          text box that represents a binary numerical value. The 
 *          data then is converted into a int32 integer in the parameter
 *          of the method BinaryConverter. BinaryConverter uses an int
 *          to called numLength to get the length of the number by casting
 *          the variable to a string and saving the length in an integer
 *          called numLength. A local member variable called deci is used
 *          to find the decimal value by taking the modulus of binary's 
 *          value by 10 and then multiplying the value to 2 to the power
 *          of i by using the Pow function from the Math library. The 
 *          value is then added to deci and binary is divided by 10.
 *          Once binary's value is converted to decimal, it is 
 *          converted back to a string and assigned to binary in the
 *          button method. binary is then assigned to deciOutVal text box
 *          and printed in the form window.
 */
using System;
using System.Windows.Forms;

namespace Proj3_BinaryConv_Douglas
{
    public partial class binaryForm : Form
    {
        public binaryForm()
        {
            InitializeComponent();
        }

        private void binaryForm_Load(object sender, EventArgs e)
        {

        }
        
        private void binInputVal_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void deciOutVal_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         *      Method Name: BinaryConverter
         *      Parameters: binary: int
         *      Purpose: Taking an integer value representing a binary value
         *      and converting it to a decimal value;
         */
        private string BinaryConverter(int binary)
        {
            //local variable that represents the decimal value
            double deci = 0;
            //local variable to take the length minus 1 of binary 
            int numLength = Convert.ToString(binary).Length-1;

            //binary value is modulused by 10 getting a 1 or a 0
            //it is then multiplied by 2 to the power of i to get
            //the decimal equivalent and added to deci. Binary is
            //then divided by 10 to get the next value until reaching
            //2 to the power of 0.
            for (int i = 0; i <= numLength; i++)
            {
                deci += (binary % 10) * Math.Pow(2, i);
                binary /= 10;
                
            }
            //deci is converted to an int to remove the decimal point
            deci = (int)deci;
            //assigns deci to binary in convertButt_Click
            return Convert.ToString(deci);
        }

        /*
         *  Method Name: convertButt_Click
         *  Purpose: Method for the button in the form window. Calls
         *  BinaryConverter and converts the local string variable
         *  to a integer to get the decimal value and then prints it 
         *  out to deciOutVal's text box
         */
        private void convertButt_Click(object sender, EventArgs e)
        {
            string binary = binInputVal.Text;   

            binary = BinaryConverter(Convert.ToInt32(binary));
            deciOutVal.Text = binary;
        }

    }
}
