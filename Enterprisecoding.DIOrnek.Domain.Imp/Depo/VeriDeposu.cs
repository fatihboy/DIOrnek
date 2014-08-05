using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Com.Enterprisecoding.DIOrnek.Domain.Depo;

namespace Com.Enterprisecoding.DIOrnek.Domain.Imp.Depo {
    internal sealed class VeriDeposu : IVeriDeposu {
        public long Kaydet(object veri) {
            var recordId = DateTime.Now.Ticks;
            using (var stream = File.Open("VeriDosyasi-" + recordId + ".txt", FileMode.Create)) {
                var binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(stream, veri);
                stream.Close();
            }

            return recordId;
        }
    }
}