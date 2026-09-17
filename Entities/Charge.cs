using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class Charge
    {
        private int _id;
        private string _name;

        public Charge(int id, string name)
        {

            _id = id;
            _name = name;
        }

        public string getDetails()
        {

            string info = "";

            info = "\n Charge ID: " + _id.ToString();
            info += "\n Charge Name: " + _name;
            return info;
        }
    }
}
