using AracSimulasyonu.UI.Core;
using AracSimulasyonu.UI.Enums;
using AracSimulasyonu.UI.Interfaces;
using System.Reflection;
using System.Text.Json;

namespace AracSimulasyonu.UI
{
    public partial class Form1 : Form
    {
        private List<IArac> Araclar;
        private List<KiralamaBilgisi> KiralananAraclar = new List<KiralamaBilgisi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araclar = new List<IArac>
                   {
                        new Araba("BMW 320i", AracTipi.Sedan, 1500m),
                        new Araba("Jeep Wrangler", AracTipi.SUV, 2000m),
                        new Araba("Ford Focus", AracTipi.Hatchback, 1000m),
                        new Araba("Mercedes C Coupe", AracTipi.Coupe, 1800m),
                        new Araba("Mazda MX-5", AracTipi.Cabriolet, 2200m),
                        new Araba("Ford F-150", AracTipi.Pickup, 2500m),
                        new Araba("Volvo V60", AracTipi.StationWagon, 1600m)
                   };
            foreach (var arac in Araclar)
            {
                cmbArac.Items.Add(arac.AracBilgisiGoster());
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (cmbArac.SelectedIndex == -1 || !int.TryParse(txtGunSayisi.Text, out int gunSayisi) || gunSayisi < 0)
            {
                MessageBox.Show("Lütfen geçerli bir  araç seciniz veya geçerli bir araç süresi giriniz");
                return;
            }
            IArac secilenArac = Araclar[cmbArac.SelectedIndex];

            if (!secilenArac.MusaitMi)
            {
                MessageBox.Show("Bu araç þuanda kirada !!!");
                return;
            }
            decimal toplamUcret = secilenArac.GunlukUcret * gunSayisi;

            if (gunSayisi >= 5)
            {
                toplamUcret *= 0.9m;
            }

            KiralamaBilgisi yeniKiralama = new KiralamaBilgisi
            {
                AracModel = secilenArac.Model,
                GunSayisi = gunSayisi,
                ToplamUcret = toplamUcret
            };

            KiralananAraclar.Add(yeniKiralama);
            lstKiralamaGecmisi.Items.Add(yeniKiralama);

            secilenArac.MusaitMi = false;

            cmbArac.Items[cmbArac.SelectedIndex] = $"{secilenArac.Model}-{secilenArac.Tip} Gunluk Ucret - {secilenArac.GunlukUcret}-Kiralandý";

            lblSonuc.Text = $"Toplam Ucret:{toplamUcret}";

        }
        private void JsonVeriKaydet()
        {
            try
            {
                //projenin bulunduðu yolu alýcam
                string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                //projenin içine girmek için 
                string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "Data");
                string dosyaYolu = Path.Combine(hedefDizin, "data.json");

                //Data klasorum var mý 
                if (!Directory.Exists(hedefDizin))
                {
                    //eðer yoksa oluþtur
                    Directory.CreateDirectory(hedefDizin);
                }
                List<KiralamaBilgisi> mevcutVeriler = new List<KiralamaBilgisi>();
                //.json uzantýlý bir data.json var mý 
                if (!File.Exists(dosyaYolu))
                {
                    mevcutVeriler = new List<KiralamaBilgisi>();
                }
                else
                {
                    string eskiJson = File.ReadAllText(dosyaYolu);
                    //eski bir verim var ise elimdeki liste tipine göre tekrardan jsondan listeye çevirdim.
                    var veriListesi = JsonSerializer.Deserialize<List<KiralamaBilgisi>>(eskiJson);

                    if (veriListesi == null)
                    {
                        return;
                    }
                    mevcutVeriler = veriListesi;
                }

                mevcutVeriler.AddRange(KiralananAraclar);

                var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true };
                string yeniJson = JsonSerializer.Serialize(mevcutVeriler, jsonAyarlar);
                File.WriteAllText(dosyaYolu, yeniJson);



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnJsonConvert_Click(object sender, EventArgs e)
        {
            JsonVeriKaydet();
        }
    }
}
