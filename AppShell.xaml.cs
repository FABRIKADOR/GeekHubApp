namespace GeekHubApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Rutas para navegacion manual
        Routing.RegisterRoute("dragonball", typeof(DragonBallPage));
        Routing.RegisterRoute("naruto", typeof(NarutoPage));
        Routing.RegisterRoute("strangerthings", typeof(StrangerThingsPage));
        Routing.RegisterRoute("mario", typeof(MarioBrosPage));
    }
}
