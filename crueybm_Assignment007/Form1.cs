/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/12/2017
 * Assignment: 007
 * Description: This program takes two arrays of binary numbers, then verifies that they only contain 0 and 1 and are the same length.
 * The binary numbers are then converted to strings, and added using base 2.  A Windows Form is created, and reacts to the user's
 * input to find a resulting sum.
 * The resulting sum is then converted back into an int array, checked for length, and returned to the main.
 * Citations: https://stackoverflow.com/questions/5074575/what-is-the-best-way-in-c-sharp-to-convert-string-into-int
 * https://stackoverflow.com/questions/37805179/how-can-i-make-a-textbox-accepts-only-numeric-values
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crueybm_Assignment007
{
    public partial class frmAssignment07 : Form
    {
        public frmAssignment07()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            tbResult.Clear();                                               //Clears tbResult TextBox upon button click
            tbWarning.Clear();                                              //Clears tbWarning TextBox upon button click
            string input1 = string.Join<char>(",", tbBinaryString1.Text);   //Declares and sets input1 to the value entered to tbBinaryString1, then converts it to a comma-separated string
            string input2 = string.Join<char>(",", tbBinaryString2.Text);   //Declares and sets input2 to the value entered to tbBinaryString2, then converts it to a comma-separated string
            int[] arr1 = input1.Split(',').Select(int.Parse).ToArray();     //Declares and sets arr1 to the converted value of input1, and splits it to an array
            int[] arr2 = input2.Split(',').Select(int.Parse).ToArray();     //Declares and sets arr2 to the converted value of input2, and splits it to an array
            int[] sum = AddBinary(arr1, arr2);                              //Calls upon the AddBinary method, using arr1 and arr2 as arguments
            String final = string.Join("", sum);                            //Converts and joins the sum[] array into a string 
            tbResult.Text = final;                                          //Sets the tbResult TextBox to the value of final
        }

        public int[] AddBinary(int[] op1, int[] op2)
        {
            int[] result;                          //Declares result array.
            if (op1.Length != op2.Length)    //Verifies that the two binary arrays are the same length.
            {
                tbWarning.Text = "Binary strings are not the same length!";     //Sets tbWarning to the exception message
                throw new Exception("Binary strings are not the same length");  //Throws the resulting exception.
            }
            for (int i = 0; i < op1.Length; i++)   //Begins a for loop to check array consistency.
            {
                if (op1[i] > 1 || op2[i] > 1)      //Verifies that the numbers in the binary arrays are no greater than 0 or 1
                {
                    tbWarning.Text = "Number greater than 1 detected!";             //Sets tbWarning to the exception message
                    throw new Exception("Number greater than 1 detected");          //Throws the resulting exception.
                }
            }

            string tmp1 = string.Join("", op1);         //Converts the int op1 array into a string.
            string tmp2 = string.Join("", op2);         //Converts the int op2 array into a string.
            int tmp11 = Convert.ToInt32(tmp1, 2);       //Converts the tmp1 string into a base 2 integer.
            int tmp22 = Convert.ToInt32(tmp2, 2);       //Converts the tmp2 string into a base 2 integer.
            string res = Convert.ToString(tmp11 + tmp22, 2).PadLeft(op1.Length, '0');
            //Adds the tmp1 and tmp2 binary integers, converts the sum into a string, and then pads the left of the string with 0.
            string res1 = string.Join<char>(",", res);  //Inserts commas into the res string for the next step.
            result = res1.Split(',').Select(int.Parse).ToArray();
            //Changes the binary sum into an int array.
            if (result.Length != op1.Length)            //Checks the result array against the original array to verify length.
            {
                tbWarning.Text = "Result length does not match Operand Length!";        //Sets tbWarning to the exception message
                throw new Exception("Result Length does not match Operand Length");     //Throws the resulting exception
            } else
            {
                tbWarning.Text = "Operation successful!";       //Sets tbWarning to a success message
            }
            return result;   //Returns the resulting array to the main
        }

        private void tbBinaryString1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBinaryString2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
