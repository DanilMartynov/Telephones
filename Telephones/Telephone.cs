using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephones
{
    public class Telephone
    {
        public Firma Firma { get; private set; }
        public string Modele { get; private set; }
        public int Stoimost { get; private set; }


        public Telephone(string modele, int stoimost)
        {

            if (string.IsNullOrEmpty(modele))
            {
                throw new ArgumentException("У телефоне не может отсутствовать модель", nameof(modele));
            }

            if (stoimost < 0)
            {
                throw new ArgumentException("Стоимость не может быть ниже нуля", nameof(stoimost));
            }

            Modele = modele;
            Stoimost = stoimost;
        }

        public Telephone(string modele, int stoimost, Firma firma): this (modele, stoimost)
        {
            Firma = firma ?? throw new ArgumentException(nameof(firma));

        }


        public override string ToString()
        {
            return $"Модель: {Modele} , Стоимость: {Stoimost} , Фирма: {Firma} ";
        }

        


    }
}
