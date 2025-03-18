using AracSimulasyonu.UI.Enums;
using AracSimulasyonu.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSimulasyonu.UI.Core
{
    public class Araba : IArac
    {
        public Araba(string model, AracTipi tip, decimal gunlukUcret)
        {
            Model = model;
            Tip = tip;
            GunlukUcret = gunlukUcret;
        }

        public string Model { get; }

        public AracTipi Tip { get; }

        public decimal GunlukUcret { get; }

        public bool MusaitMi { get; set; } = true;
     
        public string AracBilgisiGoster()
        {
            return $"{Model} - {Tip} - {GunlukUcret} - Listelendi ";
        }
    }
}
