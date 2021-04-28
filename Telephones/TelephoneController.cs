using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephones
{
    public class TelephoneController
    {
        private List<Telephone> telephones { get; set; } = new List<Telephone>();

        private string[] tel = new string[] {"H213", "S4245"};

        public TelephoneController()
        {
            FirmaController firmaController = new FirmaController();
            foreach (var item in tel)
            {
                Firma firma = RandFirma(firmaController);
                int stoimost = RandStoimost();
                Telephone telephone = new Telephone(item, stoimost, firma);
                telephones.Add(telephone);
            }
        }

        public List<Telephone> Telephones()
        {
            return telephones;
        }


        private int RandStoimost()
        {
            Random random = new Random();
            int stoim = random.Next(10000, 100000);
            return stoim;
        }

        private Firma RandFirma(FirmaController firmaController)
        {
            Random random = new Random();
            return firmaController.GetFirms()[random.Next(0, firmaController.GetFirms().Count)];
        }
        public void AddTelephone(string modele, int stoimost, string firma, FirmaController firmscontroller)
        {
            foreach (Firma itemfirma in firmscontroller.GetFirms())
            {
                if(itemfirma.Name == firma)
                {
                    telephones.Add(new Telephone(modele, stoimost, itemfirma));
                    return;
                }
                else
                {
                    firmscontroller.Add(firma);
                    Firma newFirma = firmscontroller.GetFirmabyName(firma);

                    telephones.Add(new Telephone(modele, stoimost, newFirma));
                    return;
                }
            }
            
        }

    }
}
