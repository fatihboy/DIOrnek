using Com.Enterprisecoding.DIOrnek.Domain.Depo;
using Com.Enterprisecoding.DIOrnek.Domain.Varlik;
using Ninject;
using System;

namespace Com.Enterprisecoding.DIOrnek {
    class Program {
        static void Main() {
            var ogrenci = new Ogrenci {
                No = 12345,
                Adi = "Fatih",
                Soyadi = "Boy",
                Bolum = "Bilgisayar Mühendisliği"
            };

            var kernel = new StandardKernel();

            kernel.Load("DIOrnek.Domain.Moq.dll"); // Domain implemantasyonu için bu satırı commentleyip alttaki coment'i açınız.
            //kernel.Load("DIOrnek.Domain.Imp.dll");

            var ogrenciDeposu = kernel.Get<IOgrenciDeposu>();


            var kayitBasariliMi = ogrenciDeposu.Kaydet(ogrenci);
            Console.WriteLine(kayitBasariliMi ? "Öğrenci başarıyla kaydedildi" : "Öğrenci kaydedilemedi");
        }
    }
}