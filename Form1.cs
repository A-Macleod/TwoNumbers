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
        private Timer messageTimer;

        public Form1()
        {
            InitializeComponent();

        }


        // OnClick event handler, parse string into integer from textBoxes and create new twoNumbers object using integer arguments 
        public void Instantiate_Click(object sender, EventArgs e)
        {
            // Parse the string value from textBoxes into Integers
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);

            // Instantiate a new twoNumbers object with argument A and B
            newTwoNumbers = new TwoNumbers(A, B);

            // Output to textBox success
            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"newTwoNumbers Object Created, 1st Number: {A}  2nd Number: {B}";

            textBox1.Text = null;
            textBox2.Text = null;
        }

        public void FirstNumber_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"The 1st number is {newTwoNumbers.ReturnA()} ";

            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void SecondNumber_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"The 2nd number is {newTwoNumbers.ReturnB()} ";

            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"The highest number entered is : {newTwoNumbers.ReturnLargestNumber()} ";

            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void IsEqual_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"Are both numbers equal? = {newTwoNumbers.ReturnIfEqual()} ";

            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void GCD_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"The GCD of {newTwoNumbers.ReturnA()} & {newTwoNumbers.ReturnB()} = {newTwoNumbers.GCD()} ";

            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void AddNumbers_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Red;
            textBox3.Text = $"Enter numbers to add: {newTwoNumbers.ReturnA()} + ? , {newTwoNumbers.ReturnB()} + ?";

            int A, B;
            bool isTextBox1Valid = int.TryParse(textBox1.Text, out A);
            bool isTextBox2Valid = int.TryParse(textBox2.Text, out B);


            // If there is data in either textBox1 or textBox2 do this
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text)) {

                // If there is integers in both textBoxes
                if (isTextBox1Valid && isTextBox2Valid) {

                    // If the numbers are both Positive
                    if (A > 0 && B > 0 ) {

                        int first = newTwoNumbers.ReturnA() + A;
                        int second = newTwoNumbers.ReturnB() + B;

                        textBox3.ForeColor = Color.Black;
                        textBox3.Text = $"{newTwoNumbers.ReturnA()} + {A} = {first}  ,  {newTwoNumbers.ReturnB()} + {B} = {second}";

                    } else {

                        // Error message, textBox1 or textBox2 contains a Negative integer 
                        string err = $"Please enter Positive Numbers in both text boxes";
                        textBox3.ForeColor = Color.Red;
                        textBox3.Text = err;
                        textBox1.Text = null;
                        textBox2.Text = null;
                    }

                } else {

                    // Error message, textBox1 & textBox2 do not contain integers
                    string err = $"Please enter Numbers in both text boxes";
                    textBox3.ForeColor = Color.Red;
                    textBox3.Text = err;
                    textBox1.Text = null;
                    textBox2.Text = null;

                }   // EO if  
            }   // EO if

        }   // EO AddNumbers_Click

        private void ToString_Click(object sender, EventArgs e)
        {
            string toString = $"1st No: {newTwoNumbers.ReturnA()} , 2nd No: {newTwoNumbers.ReturnB()} , Highest No: {newTwoNumbers.ReturnLargestNumber()} , Equal: {newTwoNumbers.ReturnIfEqual()} , GCD: {newTwoNumbers.GCD()}";
            textBox3.ForeColor= Color.Black;
            textBox3.Text = toString ;
        }

    }   // EO Form1 Class


    public class TwoNumbers
        {
        // Private Fields only accessable from Public Properties or Methods
        private int _a, _b;





        // Constructor
        public TwoNumbers(int A, int B)
        {
            _a = A;
            _b = B;
        }


        // Method to return int A
        public int ReturnA()
        {
            return _a;
        }

        // Method to return int B
        public int ReturnB()
        {
            return _b;
        }

        // Method to return the Larger Number of int A and int B
        public int ReturnLargestNumber()
        {
            if (ReturnA() > ReturnB()) {
                return _a;
            } else {
                return _b;
            }
        }

        // Method to return whether two numbers are Equal
        public bool ReturnIfEqual()
        {
            if (ReturnA() == ReturnB()) {
                return true;
            } else {
                return false;
            }
        }

        // Method to return the GCD (Greatest Common Divisor) of int A and int B using Euclids Algorithm (Subtraction)
        public int GCD()
        {
            int A = ReturnA();
            int B = ReturnB();

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
            int first = A + ReturnA();
            int second = B + ReturnB();

            return $"{first} , {second}";
        }

        // Method called ToString that returns a string showing the state of the object 
        public override string ToString()
        {
            return $"First Number:  {ReturnA()} \n Second Number:  {ReturnB()} \n Max:  {ReturnLargestNumber()} \n Equal:  {ReturnIfEqual()} \n GCD:  {GCD()} ";
        }





         


        
        }   // EO TwoNumbers Class
}   // EO namespace
