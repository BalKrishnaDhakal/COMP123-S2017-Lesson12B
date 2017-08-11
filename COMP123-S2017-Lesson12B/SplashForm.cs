using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Date: August 8, 2017
 * Desciption: Calculator Demo Project
 * Version: 0.4- Created a public property as an Alias to Program.Calculatorform
 */ 
namespace COMP123_S2017_Lesson12B
{
    public partial class SplashForm : Form
    {
        // PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++
        private CalculatorForm _calculatorForm;

        // PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++
        public CalculatorForm CalculatorForm
        {
            get
            {
                return Program.calculatorForm;
            }
        }
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// This is the main constructors for the SplashForm
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Thick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
           
           this. CalculatorForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = false; // turn timer off
        }
    }
}
