using Microsoft.Owin;
using Owin;

namespace Lisa.Civilization
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}