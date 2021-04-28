using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephones
{
    public class Firma
    {
        public string Name { get; private set; }

        public Firma (string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("У фирмы не может отсутствовать имя", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
