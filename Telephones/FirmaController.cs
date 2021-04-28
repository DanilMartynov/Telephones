using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephones
{
    public class FirmaController
    {
        private List<Firma> firms = new List<Firma>();

        private string[] fir = new string[] { "Honor", "Samsyng" };

        public FirmaController()
        {
            foreach (var item in fir)
            {
                firms.Add(new Firma(item));
            }
        }

        public List<Firma> GetFirms ()
        {
            return firms;
        }
        public void Add(string nFirm)
        {
            foreach (Firma firma in firms)
            {
                if(firma.Name == nFirm)
                {
                    throw new ArgumentException("Это название уже есть");
                }
            }
            firms.Add(new Firma(nFirm));

        }

        public Firma GetFirmabyName(string name)
        {
            foreach(Firma firma in firms)
            {
                if(firma.Name == name)
                {
                    return firma;
                }
            }
            return null;
        }
    }
}
