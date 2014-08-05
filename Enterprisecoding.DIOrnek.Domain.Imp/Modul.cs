using Com.Enterprisecoding.DIOrnek.Domain.Depo;
using Com.Enterprisecoding.DIOrnek.Domain.Imp.Depo;
using Ninject.Modules;

namespace Com.Enterprisecoding.DIOrnek.Domain.Imp {
    public sealed class Modul : NinjectModule {
        public override void Load() {
            Bind<IGunlukDeposu>().To<GunlukDeposu>().InSingletonScope();
            Bind<IOgrenciDeposu>().To<OgrenciDeposu>().InSingletonScope();
            Bind<IVeriDeposu>().To<VeriDeposu>().InSingletonScope();

        }
    }
}