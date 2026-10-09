using Case_Management_Redo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class Defendant :Person
    {

        public Defendant(string id, string name) : base(id, name)
        {


        }
        public string getDetails()
        {
            string info = "";
            info = "\n Defendant ID: " + getId();
            info += "\n Defendant Name: " + getName();
            return info;
        }
    }
}
