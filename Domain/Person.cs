using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        int id;
        string fisrtName;
        string lastName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FisrtName
        {
            get { return fisrtName; }
            set { fisrtName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return FisrtName + " " + LastName;
        }
    }
}
