using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Instantiate_Click(object sender, EventArgs e)
        {
            // Parse the string value from textBoxes into Integers
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);

            // Instantiate a new twoNumbers object with argument A and B
            TwoNumbers twoNumbers = new TwoNumbers(A, B);

            textBox3.ForeColor = Color.Black;
            textBox3.Text = $"New Two Numbers Object Created. First Number: {A}   Second Number: {B}  ";
        }

        private void FirstNumber_Click(object sender, EventArgs e)
        {

        }

        private void SecondNumber_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void IsEqual_Click(object sender, EventArgs e)
        {

        }

        private void GCD_Click(object sender, EventArgs e)
        {

        }

        private void AddNumbers_Click(object sender, EventArgs e)
        {

        }

        private void ToString_Click(object sender, EventArgs e)
        {

        }
    }


    public class TwoNumbers
    {
        // Private integer Fields only accessable from Public Properties or Methods
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
            return ReturnA();
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
