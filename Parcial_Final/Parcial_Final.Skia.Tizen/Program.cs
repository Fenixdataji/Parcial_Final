using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Parcial_Final.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Parcial_Final.App(), args);
            host.Run();
        }
    }
}
