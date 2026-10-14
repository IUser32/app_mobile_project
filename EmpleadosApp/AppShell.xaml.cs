namespace EmpleadosApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("empleado-form", typeof(Views.EmpleadoFormPage));
        Routing.RegisterRoute("departamento-form", typeof(Views.DepartamentoFormPage));
        Routing.RegisterRoute("cargo-form", typeof(Views.CargoFormPage));
        Routing.RegisterRoute("usuario-form", typeof(Views.UsuarioFormPage));
    }
}
