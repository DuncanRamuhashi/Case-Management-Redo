using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class Court
    {
        private int _id;
        private string _name;
        private string _location;

        public Court(int id, string name, string location)
        {

            _id = id;
            _name = name;
            _location = location;
        }


        public string getCourtInfo()
        {

            string info = "";

            info = "\n Court ID: " + _id.ToString();
            info += "\n Court Name: " + _name;
            info += "\n Court Location: " + _location;
            return info;
        }
    }
    }
