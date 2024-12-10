using Lab_Tiaraju.View;

namespace Lab_Tiaraju
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
            Routing.RegisterRoute(nameof(ComercialView), typeof(ComercialView));
            Routing.RegisterRoute(nameof(LojaVirtualView), typeof(LojaVirtualView));
            Routing.RegisterRoute(nameof(TIView), typeof(TIView));
            Routing.RegisterRoute(nameof(SAPView), typeof(SAPView));
            Routing.RegisterRoute(nameof(MagentoView), typeof(MagentoView));

        }
    }
}
