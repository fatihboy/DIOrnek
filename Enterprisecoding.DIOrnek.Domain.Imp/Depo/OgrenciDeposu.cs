using System;
using Com.Enterprisecoding.DIOrnek.Domain.Depo;
using Com.Enterprisecoding.DIOrnek.Domain.Varlik;

namespace Com.Enterprisecoding.DIOrnek.Domain.Imp.Depo {
    internal sealed class OgrenciDeposu : IOgrenciDeposu {
        public readonly IVeriDeposu veriDeposu;
        private readonly IGunlukDeposu gunlukDeposu;

        public OgrenciDeposu(IVeriDeposu veriDeposu, IGunlukDeposu gunlukDeposu) {
            this.veriDeposu = veriDeposu;
            this.gunlukDeposu = gunlukDeposu;
        }

        public bool Kaydet(Ogrenci ogrenci) {
            try {
                gunlukDeposu.Debug("Öğrenci kaydı yapılıyor...");

                var referansId = veriDeposu.Kaydet(ogrenci);

                gunlukDeposu.Debug("Öğrenci kaydı yapıldı. Referans Id : {0}", referansId);

                return true;
            }
            catch (Exception istisna) {
                gunlukDeposu.Error("Öğrenci kaydı sırasında beklenmeyen bir hata oluştu : {0}", istisna);
            }

            return false;
        }
    }
}