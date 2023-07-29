namespace SinifYoklamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<OgrenciAdi> OgrenciListesi = new();

            OgrenciListesi.Add(new OgrenciAdi() { SinifNumarasi = 100, Adi = "Kumru", SiniftaMi = true });
            OgrenciListesi.Add(new OgrenciAdi() { SinifNumarasi = 120, Adi = "Uğur",  SiniftaMi = false});
            OgrenciListesi.Add(new OgrenciAdi() { SinifNumarasi = 125, Adi = "Nilsu", SiniftaMi = true });
            OgrenciListesi.Add(new OgrenciAdi() { SinifNumarasi = 110, Adi = "Altan", SiniftaMi = true });
            OgrenciListesi.Add(new OgrenciAdi() { SinifNumarasi = 113, Adi = "Andaç", SiniftaMi = false});
            OgrenciListesi.Add(new OgrenciAdi() { SinifNumarasi = 130, Adi = "Bensu", SiniftaMi = false});

            Console.WriteLine("Sinif Yoklaması Uygulamasına Hoş Geldiniz!");
            Console.WriteLine("İşlem Listesi");
            Console.WriteLine("1- Sınıf Listesi");
            Console.WriteLine("2- Yoklama");
            Console.WriteLine("3- Gelmeyenlerin Listesi");
            Console.WriteLine("4- Çıkış");
            

            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");
                int secim = int.Parse(Console.ReadLine());

                if(secim==1)
                {
                    foreach (var OgrenciAdi in OgrenciListesi)
                    {
                        Console.WriteLine($"SinifNumarası : {OgrenciAdi.SinifNumarasi}, Adi : {OgrenciAdi.Adi}, SiniftaMi: {OgrenciAdi.SiniftaMi}");
                    }
                    Console.WriteLine("---------------------");
                    continue;
                }
                else if (secim==2)
                {
                    Console.WriteLine("Sınıf Listesi :  ");

                    foreach (var OgrenciAdi in OgrenciListesi)
                    {
                        Console.WriteLine(OgrenciAdi.SinifNumarasi + "-----" + OgrenciAdi.Adi + "------" + "true/false");
                        OgrenciAdi.SiniftaMi = bool.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("------------------------");
                    continue;
                }
                else if (secim==3)
                {
                    Console.WriteLine("Gelmeyenler Listesi:");
                    var notSiniftaMi = OgrenciListesi.Where(p => p.SiniftaMi == false).ToList();

                    foreach (var OgrenciAdi in notSiniftaMi)
                    {
                        Console.WriteLine(OgrenciAdi.SinifNumarasi + "-----" + OgrenciAdi.Adi + " gelmedi!");
                    }
                    Console.WriteLine("-----------------------");
                    continue;
                }
                else if (secim ==4)
                {
                    Console.WriteLine("İyi Dersler (-_-)");
                    break;
                }

            }



        }
    }
    class OgrenciAdi
    {
        public int SinifNumarasi;
        public string Adi;
        public bool SiniftaMi ;

    }
    
}