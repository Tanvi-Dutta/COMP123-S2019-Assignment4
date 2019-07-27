using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author's Name: Tanvi
/// Author's StudentNumber: #301044096
/// Date last Modified: 7/26/2019
/// Program Description: This program allows the user to calculate their BMI either 
/// Imperial or metric units.
/// Revision History:
/// 26 July,2019- Made the basic structure of the calculator
/// 26 July,2019-Completed the assignment
/// </summary>
namespace COMP123_S2019_Assignment4
{
    static class Program
    {

        //creating a dictionary
        public static Dictionary<FormNames, Form> Forms;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASHSCREEN_FORM, new SplashScreenForm());
            Forms.Add(FormNames.BMICALCULATOR_FORM, new BMICalculatorForm());

            
            Application.Run(new SplashScreenForm());
        }
    }
}
