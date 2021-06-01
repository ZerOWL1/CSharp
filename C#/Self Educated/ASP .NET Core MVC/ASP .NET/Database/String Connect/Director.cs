using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5._Repsitory_and_Generic_Repository_Pattern.Models.NewFolder
{
    public class Director : IEnumerable
    {
        private int dID;
        private string dName;
        private string dNation;

        public Director()
        {

        }
        public Director(int dId, string dName, string dNation)
        {
            dID = dId;
            this.dName = dName;
            this.dNation = dNation;
        }
        public int DID { get => dID; set => dID = value; }
        public string DName { get => dName; set => dName = value; }
        public string DNation { get => dNation; set => dNation = value; }

        public override string ToString()
        {
            return 
                "DID: " + this.dID +
                "DirectorName: " + this.dName +
                "DirectorNation: " + this.dNation;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
