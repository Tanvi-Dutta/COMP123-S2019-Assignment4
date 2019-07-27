using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
///  Author's Name: Tanvi
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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event will enable the timer to display the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = true;
        }

        /// <summary>
        /// This is tick event
        /// It shows the BMICalculatorForm and hides the SplashScreenForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            Program.Forms[FormNames.BMICALCULATOR_FORM].Show();
            this.Hide();
        }
    }
}
