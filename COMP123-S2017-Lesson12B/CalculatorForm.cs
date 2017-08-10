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
 * Version: 0.7- Refactored the CalculatorButton_Click event handler
 */ 
namespace COMP123_S2017_Lesson12B
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _isDecimalClicked;
        private string _currentOperator;
        private List<double> _operandList;
        // PUBLIC PROPERTIES
        public List<double> OperandList
        {
            get
            {
                return this._operandList;
            }
            set
            {
                this._operandList = value;
            }
        }
        public string CurrentOperator
        {
            get
            {
                return this._currentOperator;
            }
            set
            {
                this._currentOperator = value;
            }
        }
        public bool IsDecimalClicked
        {
            get
            {
                return this._isDecimalClicked;
            }
            set
            {
                this._isDecimalClicked = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the Calculator Form class
        /// </summary>
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
            if((this.IsDecimalClicked) &&  (calculatorButton.Text == "."))
            {
                    return;
                
            }
            if(calculatorButton.Text == ".")
            {
                this.IsDecimalClicked = true;
            }

            if (ResultTextBox.Text == "0")
            {
                if (calculatorButton.Text == ".")
                {
                    ResultTextBox.Text += calculatorButton.Text;
                }
                else
                {
                    ResultTextBox.Text = calculatorButton.Text;
                }
            }
            else
            {
                ResultTextBox.Text += calculatorButton.Text;
            }



            // Debug.WriteLine("A Calculator Button was clicked");
        }
        /// <summary>
        /// This is a shared event handler for the FormClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button;// downcasting
            switch (operatorButton.Text)
            {
                case "c":
                    this._clear();
                    break;
            }
        }
        /// <summary>
        /// This is the private clear method. It resets / Clear the calculator
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            ResultTextBox.Text = "0";

            this.OperandList = new List<double>();

        }

        /// <summary>
        /// This is the event handler for the "Load" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this._clear();
        }
    }
}
