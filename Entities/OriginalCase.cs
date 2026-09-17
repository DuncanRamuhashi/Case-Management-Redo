using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class OriginalCase
    {
        private int _id;
        private string _caseNumber;
        private string _name;
        private string _location;
        private int _year;

        public OriginalCase(int id, string caseNumber, string name, string location, int year)
        {
            _id = id;
            _caseNumber = caseNumber;
            _name = name;
            _location = location;
            _year = year;

        }
        public string getCaseNumber()
        {
            return _caseNumber;
        }
        public string getInformation()
        {

            string info = "";


            info += "\n Case Number: " + _caseNumber;
            info += "\n Case Name: " + _name;
            info += "\n Case Location: " + _location;
            info += "\n Case Year: " + _year;

            return info;

        }
    }
}
