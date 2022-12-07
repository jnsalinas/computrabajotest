using System.Windows.Input;
using ComputrabajoTest.App.ViewModels;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace ComputrabajoTest.App;

public partial class MainPage : ContentPage
{

    int count = 0;
    private readonly IFingerprint fingerprint;

    public MainPage(IFingerprint fingerprint)
    {
        InitializeComponent();
        this.fingerprint = fingerprint;

        //consulta los usuarios de forma asincronica, mientras el usuario hace
        //login con el faceid o fingerid con el fin de que cuando inicie sesion el
        //performance de la appp le muestre los usuarios inmediatamente 
        UserVM userVM = new UserVM();
        userVM.GetUsersCommand.Execute(null);
        this.BindingContext = userVM;
    }

    /// <summary>
    /// clicked biometric button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnBiometricClicked(object sender, EventArgs e)
    {
        var request = new AuthenticationRequestConfiguration("Validación Biométrica", "Accede a la App a través de tu identidad");
        var result = await fingerprint.AuthenticateAsync(request);

        if (result.Authenticated)
        {
            await DisplayAlert("Autenticado!", "Acceso Permitido", "OK");

            Views.Users users = new Views.Users();
            var userVM = this.BindingContext as UserVM;
            users.BindingContext = userVM;

            await Navigation.PushAsync(users);
        }
        else
        {
            await DisplayAlert("No autorizado", "Acceso Denegado", "OK");
        }
    }
}


