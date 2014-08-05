using System;

namespace Com.Enterprisecoding.DIOrnek.Domain.Depo {
    public interface IGunlukDeposu {
        void Debug(string logMesaji, params object[] parametreler);
        void Error(string logMesaji, Exception istisna);
    }
}