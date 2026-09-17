using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class Judge
    {
        private int _id;
        private string _name;

        public Judge(int id, string name)
        {

            _id = id;
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
    }
}
