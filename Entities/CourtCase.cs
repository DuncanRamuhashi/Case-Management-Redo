using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class CourtCase
    {
        private int _id;
        private string _courtCaseNumber;
        private string _status;
        //Aggregation
        private OriginalCase _originalCase;
        private Court _court;
        private Judge _judge;
        private Prosecutor _prosecutor;

        //Composition
        private List<Charge> _charges;
        private Dictionary<string, Defendant> _defendant;


        public CourtCase(int id, string courtCaseNUmber, List<string> charges, Dictionary<string, string> defendants)
        {

            _id = id;
            _courtCaseNumber = courtCaseNUmber;

            _charges = new List<Charge>();
            foreach (var charge in charges)
            {
                _charges.Add(new Charge(charges.IndexOf(charge), charge.ToString()));
            }
            _defendant = new Dictionary<string, Defendant>();
            foreach (var defendant in defendants)
            {
                _defendant.Add(defendant.Key, new Defendant(defendant.Key, defendant.Value));
            }

        }
        public void assignOriginalCase(OriginalCase originalCase)
        {
            _originalCase = originalCase;
        }
        public void assignCourt(int id, string name, string location)
        {
            _court = new Court(id, name, location);
        }
        public void assignJudge(int id, string name)
        {
            _judge = new Judge(id, name);
        }
        public void assignProsecutor(int id, string name)
        {
            _prosecutor = new Prosecutor(id, name);
        }

        public void updateStatus(string status)
        {
            _status = status;
        }
        public string displayCaseInfo()
        {
            string info = "";
            info += _originalCase.getInformation();
            info += "\n Court Case Number: " + _courtCaseNumber;
            info += "\n Court Info: " + _court.getCourtInfo();
            info += "\n Judge Name: " + _judge.getName();
            info += "\n Prosecutor Name: " + _prosecutor.getName();
            foreach (var charge in _charges)
            {
                info += charge.getDetails();
            }
            foreach (var defendant in _defendant.Values)
            {
                info += defendant.getDetails();
            }
            info += "\n Status: " + _status;
            return info;
        }
    }
}
