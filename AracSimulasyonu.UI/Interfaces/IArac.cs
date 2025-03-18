using AracSimulasyonu.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSimulasyonu.UI.Interfaces
{
    public interface IArac
    {
        string Model { get; }
        //todo enumı eklee
        AracTipi Tip { get; }
        decimal GunlukUcret { get; }
        bool MusaitMi { get; set; }
        string AracBilgisiGoster();

    }
}
