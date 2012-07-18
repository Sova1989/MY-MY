using Ninject.Modules;
using example.Core;
using example.Domain;

namespace example.Ninject
{
    public class MainNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DataBaseContext>().ToMethod(it => new DataBaseContext());
            this.Bind<IUserProcessor>().To<UserProcessor>();
        }
    }
}