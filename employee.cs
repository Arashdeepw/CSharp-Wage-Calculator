using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class employee
    { //employee class
        private string empName; //name
        private double wage; //wage
        private double hours; //hours worked
        //used for calulations
        private double sum;
        private double tax;
        private double net;

        public string EmpName //name get and set
        {
            get => empName;
            set => empName = value;
        }
        public double Wage //wage get and set
        {
            get => wage;
            set => wage = value;
        }
        public double Hours //hours get and set
        {
            get => hours;
            set => hours = value;
        }

        public string calcGross() // calculate Gross
        {
            if (hours > 40) // overtime pay
            {
                sum = wage * 40;
                sum += ((hours - 40) * (wage * 1.5));
            }
            else //regular 40 hour
                sum = wage * hours;

            return "$" + Math.Round(sum,2); // return string with total
        }

        public string calcTax() //calculate tax
        {
            tax = sum * 0.15;
            return "$" + Math.Round(tax, 2); // return string with total
        }

        public string calcNet() // calculate net pay
        {
            net = sum - tax;
            return "$" + Math.Round(net, 2); //return string with total
        }

    }
}
