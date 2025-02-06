using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TwoNumbers
{
    public partial class Form1 : Form
    {
        // Declare a refference to TwoNumbers to be accessed by Form Class Methods
        private TwoNumbers newTwoNumbers;

        public Form1()
        {
            InitializeComponent();
        }

        // OnClick event handler, parse string into integer from textBoxes and create new twoNumbers object using integer arguments 
        public void Instantiate_Click(object sender, EventArgs e)
        {

            textBox3.ForeColor = Color.Red;
            textBox3.Text = $"Please enter Positive Numbers in both text boxes";

            int A, B;
            bool isTextBox1Valid = int.TryParse(textBox1.Text, out A);
            bool isTextBox2Valid = int.TryParse(textBox2.Text, out B);

            // If there is data in either textBox1 or textBox2 do this
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text)) {

                // If there is integers in both textBoxes do this, else display error message
                if (isTextBox1Valid && isTextBox2Valid) {

                    // If A & B are both Positive integers do this, else display error message
                    if (A > 0 && B > 0) {

                        textBox3.ForeColor = Color.Black;
                        //// Instantiate a new twoNumbers object with argument A and B
                        newTwoNumbers = new TwoNumbers(A, B);
                        textBox3.Text = $"newTwoNumbers Object Created, 1st number: {A}  2nd number: {B}";
                        ClearTextBox();

                    } else {
                        // Error message, textBox1 or textBox2 contains a Negative integer 
                        string err = $"Please enter Positive Numbers in both text boxes";
                        textBox3.ForeColor = Color.Red;
                        textBox3.Text = err;
                        ClearTextBox();

                    }

                } else {
                    // Error message, textBox1 & textBox2 do not contain integers
                    string err = $"Please enter Numbers in both text boxes";
                    textBox3.ForeColor = Color.Red;
                    textBox3.Text = err;
                    ClearTextBox();

                }   // EO if  
            }   // EO if Outer
        }   // EO Instantiate_Click()

        public void FirstNumber_Click(object sender, EventArgs e)
        {
            if (newTwoNumbers != null) {

                textBox3.ForeColor = Color.Black;
                textBox3.Text = $"The 1st number is {newTwoNumbers.A} ";
                ClearTextBox();

            } else {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before checking the 1st Number";
                ClearTextBox();

            }
        }

        private void SecondNumber_Click(object sender, EventArgs e)
        {
            if (newTwoNumbers != null) {

                textBox3.ForeColor = Color.Black;
                textBox3.Text = $"The 2nd number is {newTwoNumbers.B} ";
                ClearTextBox();

            } else {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before checking the 2nd Number";
                ClearTextBox();

            }
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (newTwoNumbers != null) {
                textBox3.ForeColor = Color.Black;
                textBox3.Text = $"The highest number is : {newTwoNumbers.ReturnLargestNumber()} ";
                ClearTextBox();

            } else {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before checking the Maximum";
                ClearTextBox();
            }
        }

        private void IsEqual_Click(object sender, EventArgs e)
        {
            if (newTwoNumbers != null) {
                textBox3.ForeColor = Color.Black;
                textBox3.Text = $"Are both numbers equal?  {newTwoNumbers.ReturnIfEqual()} ";
                ClearTextBox();

            } else {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before checking Equality";
                ClearTextBox();
            }
        }

        private void GCD_Click(object sender, EventArgs e)
        {
            if (newTwoNumbers != null) {
                textBox3.ForeColor = Color.Black;
                textBox3.Text = $"The GCD of {newTwoNumbers.A} & {newTwoNumbers.B} = {newTwoNumbers.GCD()} ";
                ClearTextBox();

            } else {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before checking the GCD";
                ClearTextBox();
            }
        }

        private void AddNumbers_Click(object sender, EventArgs e)
        {

            if (newTwoNumbers == null) {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before Adding more numbers";
                ClearTextBox();

            } else {

                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Enter numbers to add: {newTwoNumbers.A} + ? , {newTwoNumbers.B} + ?";

                int A, B;
                bool isTextBox1Valid = int.TryParse(textBox1.Text, out A);
                bool isTextBox2Valid = int.TryParse(textBox2.Text, out B);


                // If there is data in either textBox1 or textBox2 do this
                if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text)) {

                    // If there is integers in both textBoxes do this, else display error message
                    if (isTextBox1Valid && isTextBox2Valid) {

                        // If A & B are both Positive integers do this, else display error message
                        if (A > 0 && B > 0) {

                            textBox3.ForeColor = Color.Black;
                            textBox3.Text = $"{newTwoNumbers.AddNumbers(A, B)}";
                            ClearTextBox();

                        } else {
                            // Error message, textBox1 or textBox2 contains a Negative integer 
                            string err = $"Please enter Positive Numbers in both text boxes";
                            textBox3.ForeColor = Color.Red;
                            textBox3.Text = err;
                            ClearTextBox();
                        }

                    } else {
                        // Error message, textBox1 & textBox2 do not contain integers
                        string err = $"Please enter Numbers in both text boxes";
                        textBox3.ForeColor = Color.Red;
                        textBox3.Text = err;
                        ClearTextBox();
                    }   // EO if  

                }   // EO if Outer
            }   // EO if null

        }   // EO AddNumbers_Click()

        private void ToString_Click(object sender, EventArgs e)
        {
            if (newTwoNumbers != null) {
                textBox3.ForeColor = Color.Black;
                textBox3.Text = newTwoNumbers.ToString();
            } else {
                textBox3.ForeColor = Color.Red;
                textBox3.Text = $"Create a Two Numbers Object before checking everything";
                ClearTextBox();
            }
        }   // EO ToString_Click()

        private void ClearTextBox()
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

    }   // EO Form1 Class


    public class TwoNumbers
        {
        // Private Fields only accessable from Public Properties or Methods
        private int _a, _b;

        // Property
        public int A 
        {
            get { return _a; }
        }

        public int B
        { 
            get { return _b; }
        }


        // Constructor
        public TwoNumbers(int A, int B)
        {
            _a = A;
            _b = B;
        }


        // Method to return the Larger Number of int A and int B
        public int ReturnLargestNumber()
        {
            if (_a > _b) {
                return _a;
            } else {
                return _b;
            }
        }

        // Method to return whether two numbers are Equal
        public bool ReturnIfEqual()
        {
            if (_a == _b) {
                return true;
            } else {
                return false;
            }
        }

        // Method to return the GCD (Greatest Common Divisor) of int A and int B using Euclids Algorithm (Subtraction)
        public int GCD()
        {
            int A = _a;
            int B = _b;

            // Euclids Algorithm
            while (A != B) {
                if (A > B) {
                    A = A - B;
                } else {
                    B = B - A;
                }
            }
            return A;
        }

        // Method that accepts two integers as arguments, and adds the first to the first stored and second to second stored
        public string AddNumbers(int A, int B)
        {
            int first = A + _a;
            int second = B + _b;
          
            return $"{_a} + {A} = {first} , {_b} + {B} = {second}";
        }

        // Method called ToString that returns a string showing the state of the object 
        public override string ToString()
        {
            return $"First Number:  {_a} \n Second Number:  {_b} \n Max:  {ReturnLargestNumber()} \n Equal:  {ReturnIfEqual()} \n GCD:  {GCD()} ";
        }

        }   // EO TwoNumbers Class
}   // EO namespace
