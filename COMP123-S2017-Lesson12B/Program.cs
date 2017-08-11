using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Bal Krishna Dhakal
 * StudentID: 300916314
 * Date: August 8, 2017
 * Desciption: Calculator Demo Project
 * Version: 0.3-Created an instance of yhe calculatorForm object
 */ 
namespace COMP123_S2017_Lesson12B
{
   public static class Program
    {
        // Create Reference to Forms +++++++++++++++++++++++++++++++++++++++++++++++++
        public static CalculatorForm calculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      public  static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instantiate a new object of type calculatorForm

            calculatorForm = new CalculatorForm(); 
            Application.Run(new SplashForm());
        }
    }
}
