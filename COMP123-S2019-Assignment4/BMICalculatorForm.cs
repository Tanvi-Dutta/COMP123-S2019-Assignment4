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
    public partial class BMICalculatorForm : Form
    {
        //private instance variables(Fields)
        double _weight;
        double _height;
        double _BMI = 0.0;

        /// <summary>
        /// This is the default constructor
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for BMICalculateForm_Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            //disabling the button when the form loads
            CalculateButton.Enabled = false;
        }

        /// <summary>
        /// This is the event handler which calculates the BMI and displays it in the Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //converting the text received into double and storing them in a variable
            _weight = Convert.ToDouble(WeightTextBox.Text);
            _height = Convert.ToDouble(HeightTextBox.Text);

            //calculating BMI according to the imperial units
            if(ImperialRadioButton.Checked == true)
            {
                _BMI = (_weight * 703) / (_height * _height);
            }

            //calculating BMI according to the metric units
            if(MetricRadioButton.Checked == true)
            {
                _BMI = (_weight) / (_height*_height);
            }

            //Determing the BMI results based on the scale
            if(_BMI < 18.5)
            {
                BMIDisplayTextBox.Text = $"{_BMI:f2} \n and you are underweight";
            }
            else if(_BMI >= 18.5 && _BMI <= 24.9)
            {
                BMIDisplayTextBox.Text = $"{_BMI:f2} \n and you are Normal";
            }
            else if(_BMI >= 25 && _BMI <= 29.9)
            {
                BMIDisplayTextBox.Text = $"{_BMI:f2} \n and you are Overweight";
            }
            else
            {
                BMIDisplayTextBox.Text = $"{_BMI:f2} \n and you are Obese";
            }
        }

        /// <summary>
        /// This is the event handler for the weightTextBox TextChanged event.
        /// It enables the calculate button whenever something is entered in
        /// the weightTextBox and it also checks if the data entered in HeightTextBox
        /// and WeightTextBox are float
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(WeightTextBox.Text);
                CalculateButton.Enabled = true;
            }
            catch 
            {

                CalculateButton.Enabled = false;
            }
            
        }

        /// <summary>
        /// This is the event handler for HeightTextBox TextChanged Event
        /// It checks whether the data entered in HeightTextBox is of double
        /// data type or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(HeightTextBox.Text);
                CalculateButton.Enabled = true;
            }
            catch 
            {
                CalculateButton.Enabled = false;
                
            }
        }

        /// <summary>
        /// This is a form closing event for BMI calculator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the reset button 
        /// it resets the BMI app to its original state when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialRadioButton.Checked = true;
            MetricRadioButton.Checked = false;
            HeightTextBox.Text = " ";
            WeightTextBox.Text = " ";
            BMIDisplayTextBox.Text = " ";
        }
    }
}
