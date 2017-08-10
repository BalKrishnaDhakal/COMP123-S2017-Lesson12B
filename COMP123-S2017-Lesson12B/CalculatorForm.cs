using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
/*
 * Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Date: August 3, 2017
 * Desciption: Calculator Demo Project
 * Version: 0.4-Created a shared event handler for the operator Buttons
 */ 
namespace COMP123_S2017_Lesson12B
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the shared event handler for the calculator Buttons
        /// Not including the operator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button; // downcasting
            ResultTextBox.Text += calculatorButton.Text;

           // Debug.WriteLine("A Calculator Button was clicked");
        }
        /// <summary>
        /// This is a shared event handler for the FormClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
