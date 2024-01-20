using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GA_FieldsProperties_MatthewVargas
{
    internal class Person
    {

        private string _name; //Sometimes it's important for private information to be private, in this case it's a name, but could very well be a password or email



        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else

                    throw new ArgumentException(("name cannot be null or empty"));
            }
        }
        public string ReadOnlyName
        {
            get { return _name; }
        }

        public string WriteOnlyName
        {
            set { _name = value; }
        }

    }
}
