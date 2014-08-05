using System;
using Com.Enterprisecoding.DIOrnek.Domain.Depo;

namespace Com.Enterprisecoding.DIOrnek.Domain.Imp.Depo {
    internal sealed class GunlukDeposu : IGunlukDeposu {
        public void Debug(string logMesaji, params object[] parametreler) {
            Logla("DEBUG", ConsoleColor.Yellow, string.Format(logMesaji, parametreler));
        }

        public void Error(string logMesaji, Exception istisna) {
            Logla("ERROR", ConsoleColor.Red, logMesaji + Environment.NewLine + istisna);
        }

        private void Logla(string logSeviyesi, ConsoleColor renk, string logMesaji) {
            Console.ForegroundColor = renk;
            Console.WriteLine("[{0}] [{1}] {2}", DateTime.Now, logSeviyesi, logMesaji);
            Console.ResetColor();
        }
    }
}