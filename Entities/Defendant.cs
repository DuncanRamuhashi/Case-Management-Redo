using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class Defendant
    {
        private string _id;  //ID number
        private string _name;

        public Defendant(string id, string name)
        {

            _id = id;
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
        public string getDetails()
        {

            string info = "";

            info = "\n Defendant ID: " + _id.ToString();
            info += "\n Defendant Name: " + _name;
            return info;
        }
    }
}
