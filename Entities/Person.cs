using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo.Entities
{
    internal abstract class Person
    {
        private string _id;
        private string _name;

        public Person(string id, string name)
        {
            _id = id;
            _name = name;
        }
        public string getId()
        {
            return _id;
        }
        public string getName()
        {
            return _name;
        }
    }
}
