using System;
using System.Collections.Generic;
using System.Text;

namespace gun3Odev3
{
    class MusteriManager
    {
        public void Add ()
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void Delete (Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void List(Musteri[] musteriler)
        {
            foreach (var Musteri in musteriler)
            {
                Console.WriteLine("adı: {0} soyadı: {1} id: {2} \n",Musteri.Adi,Musteri.Soyadi,Musteri.Id);
            }
        }
    }
}
