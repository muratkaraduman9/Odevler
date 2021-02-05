using System;

namespace gun3Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi= "Murat";
            musteri1.Soyadi = "Karaduman";
            musteri1.Id = 15783;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahmet Selim";
            musteri2.Soyadi = "Kaya";
            musteri2.Id = 1157;
            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            int secim = 0;
            bool a = true;
            while (a!=false)
            {
                Console.WriteLine("İşlem seçiniz\n"+ "1.Ekleme"+ "2.Silme" + "3.Listeleme" + "4.Çıkış");
                secim= Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Ekleniyor...\n");
                        musteriManager.Add();
                        break;
                    case 2:
                        Console.WriteLine("Silinecek müşteri adını giriniz: ");
                        string Silmus = Console.ReadLine();
                        if (Silmus == "Murat")
                        {
                            Console.WriteLine("Siliniyor...");
                            musteriManager.Delete(musteri1);
                            break;
                        }
                        else if(Silmus=="Ahmet Selim")
                        {
                            Console.WriteLine("Siliniyor...");
                            musteriManager.Delete(musteri2);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sistemimizde {0} isimli müşteri bulunmamakta. " +Silmus );
                            break;
                        }
                    case 3:
                        musteriManager.List(musteriler);
                        break;

                    case 4:
                        a = false;
                        break;

                }
            }
            
        }
    }
}
