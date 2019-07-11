using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Arashdeep Wander 991495450
namespace Assignment1
{
    public partial class Form1 : Form
    {
        List<employee> empList = new List<employee>(); //List of employee objects
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { //when form loads, sets focus and disables text boxes
            txtEmpName.Focus();
            txtGrossEarn.Enabled = false;
            txtLessFWT.Enabled = false;
            txtNetEarn.Enabled = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        { //when clear is clicked, clears text from text boxes 
            txtEmpName.Clear();
            txtHourWage.Clear();
            txtHourWorked.Clear();
            txtGrossEarn.Clear();
            txtLessFWT.Clear();
            txtNetEarn.Clear();
            lblError.Text = "";
            txtEmpName.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        { // calls the close function
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { //pop up message appears asking user if they really want to close
            string msg = Properties.Resources.CLOSE_FORM; //message from resources
            string caption = "Closing Form...";
            DialogResult result = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) // if user selects no, program doesn't close
            {
                e.Cancel = true;
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {// when calculate button is clicked
            Validate v = new Validate(); //creating class objects
            employee emp = new employee();

            lblError.Text = ""; //error label

            string name = "";
            double wage = 0;
            double hour = 0;

            int check = 0; //used for validation
            int index = -1; //used for updating existing account

            //if boxes are empty, ERROR
            if (!string.IsNullOrEmpty(txtEmpName.Text) && !string.IsNullOrEmpty(txtHourWage.Text) && !string.IsNullOrEmpty(txtHourWorked.Text))
            {
                if (v.validateName(txtEmpName.Text)) //validate name
                {
                    name = txtEmpName.Text;
                    check++;
                }
                else //display error
                { //changes label for error, pulls string from resources
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = Properties.Resources.NAME_ERROR;
                }
                if (v.validateNumber(txtHourWage.Text) && v.validateNumber(txtHourWorked.Text))
                { //validate numbers
                    wage=Convert.ToDouble(txtHourWage.Text);
                    hour=Convert.ToDouble(txtHourWorked.Text);
                    check++;
                }
                else //display error
                { //changes label for error, pulls string from resources
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = Properties.Resources.NUM_ERROR;
                }

            }
            else //display error if boxes empty
            { //changes label for error, pulls string from resources
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = Properties.Resources.EMPTY_ERROR;
            }

            if (check == 2) //if validation is succesful
            {
                foreach(var employ in empList) //find index of employee in list, IF one exists
                {
                    if (employ.EmpName == name)
                    {
                        index = empList.IndexOf(employ);
                    }
                }

                if (index > -1) //if employee exists, update records
                {
                    empList[index].Hours = hour;
                    empList[index].Wage = wage;
                    txtGrossEarn.Text = emp.calcGross();
                    txtLessFWT.Text = emp.calcTax();
                    txtNetEarn.Text = emp.calcNet();
                }
                else // if not, create new employee
                {
                    emp.EmpName = name;
                    emp.Hours = hour;
                    emp.Wage = wage;

                    txtGrossEarn.Text = emp.calcGross();
                    txtLessFWT.Text = emp.calcTax();
                    txtNetEarn.Text = emp.calcNet();

                    empList.Add(emp); // add new employee to list
                }
                //used for combo box update
                BindingSource bs = new BindingSource();
                bs.DataSource = empList;
                cmbEmployees.DataSource = bs;
                cmbEmployees.DisplayMember = "empName";
                cmbEmployees.ValueMember = "emp.EmpName";
                cmbEmployees.Text = name; // changes combo box name to one entered
            }
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        { //combo box
            foreach (var employ in empList) //loops through employee list
            {
                if (employ.EmpName == cmbEmployees.Text.ToString()) //displays information for selected employee
                {
                    txtEmpName.Text = employ.EmpName;
                    txtHourWage.Text = employ.Wage.ToString();
                    txtHourWorked.Text = employ.Hours.ToString();
                    txtGrossEarn.Text = employ.calcGross();
                    txtLessFWT.Text = employ.calcTax();
                    txtNetEarn.Text = employ.calcNet();
                }
            }
        }
    }
    
}
