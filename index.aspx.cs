using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                SetFocus(txtFirstName);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNumHoursWorked.Text = string.Empty;
            txtHourlyRate.Text = string.Empty;
        }

        protected void btnGetPayCheque_Click(object sender, EventArgs e)
        {
            
            //Declare and Initialize Variables with Data from the Form
            string empFirstName = txtFirstName.Text;
            string empLastName = txtLastName.Text;
            string numHours = txtNumHoursWorked.Text;
            string hourlyRate = txtHourlyRate.Text;
            string output = string.Empty;
            
            decimal dNumHours = Convert.ToDecimal(numHours);
            decimal dHourlyRate = Convert.ToDecimal(hourlyRate);
            
            //Calculate the Gross Pay, Tax to be Paid, Net Pay
            decimal taxRate = 0.24m;
            decimal hoursBeforeOT = 40;
            decimal dOTMultiplier = 1.5m;
            decimal dOTRate = dOTMultiplier * dHourlyRate;
            decimal dOTHours = 0;
            decimal dRegularPay = 0;
            decimal dOTPay = 0;
            decimal dGrossPay = 0;
            decimal dTax = 0;
            decimal dNetPay = 0;


            if (dNumHours <= hoursBeforeOT)
            {
                dGrossPay = dNumHours * dHourlyRate;
            }
            else
            {
                dOTHours = dNumHours - hoursBeforeOT;
                dRegularPay = hoursBeforeOT * dHourlyRate;
                dOTPay = dOTHours * dOTRate;
                dGrossPay = dRegularPay + dOTPay;
            }

                       
            dTax = dGrossPay * taxRate;
            dNetPay = dGrossPay - dTax;

            //Generate and Present the Pay Cheque
            output = "            Employee:      " + empFirstName + " " + empLastName;
            output += Environment.NewLine;
            output += "Total Number of Hours Worked:   " + dNumHours.ToString();
            output += Environment.NewLine;
            output += "Number of OT Hours Worked:   " + dOTHours.ToString();
            output += Environment.NewLine;
            output += "Value of Regular Pay:   " + dRegularPay.ToString();
            output += Environment.NewLine;
            output += "Value of Overtime Pay:   " + dOTPay.ToString();
            output += "         Hourly Pay:      " + dHourlyRate.ToString();
            output += Environment.NewLine;
            output += "          Gross Pay:      " + dGrossPay.ToString();
            output += Environment.NewLine;
            output += "       Tax Deducted:      " + dTax.ToString();
            output += Environment.NewLine;
            output += "            Net Pay:      " + dNetPay.ToString();

            txtOutput.Visible = true;

            txtOutput.Text = output;

        }
    }
}