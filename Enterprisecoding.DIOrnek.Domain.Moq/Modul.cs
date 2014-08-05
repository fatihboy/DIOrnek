using Com.Enterprisecoding.DIOrnek.Domain.Depo;
using Com.Enterprisecoding.DIOrnek.Domain.Varlik;
using Moq;
using Ninject.Modules;

namespace Com.Enterprisecoding.DIOrnek.Domain.Moq {
    public sealed class Modul : NinjectModule {
        public override void Load() {
            var gunlukDeposuMock = new Mock<IGunlukDeposu>();
            var ogrenciDeposuMock = new Mock<IOgrenciDeposu>();
            var veriDeposuMock = new Mock<IVeriDeposu>();

            veriDeposuMock.Setup(veriDeposuOrnegi => veriDeposuOrnegi.Kaydet(It.IsAny<object>())).Returns(635428485297202582);

            ogrenciDeposuMock.Setup(ogrenciDeposuOrnegi => ogrenciDeposuOrnegi.Kaydet(It.IsAny<Ogrenci>())).Returns(true);
            
            Bind<IGunlukDeposu>().ToConstant(gunlukDeposuMock.Object);
            Bind<IOgrenciDeposu>().ToConstant(ogrenciDeposuMock.Object);
            Bind<IVeriDeposu>().ToConstant(veriDeposuMock.Object);
        }
    }
}