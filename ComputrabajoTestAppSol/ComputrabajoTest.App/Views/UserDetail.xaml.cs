namespace ComputrabajoTest.App.Views;

public partial class UserDetail : ContentPage
{
    public UserDetail()
    {
        InitializeComponent();
    }

    /// <summary>
    /// search in default browser email of user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void btnSearchEmployee_Clicked(System.Object sender, System.EventArgs e)
    {
        var bindingContet = this.BindingContext as ViewModels.UserVM;
        Uri currentURL = new UriBuilder($"https://www.google.com/search?q={bindingContet.selectedUser.email}").Uri;
        await Browser.OpenAsync(currentURL, BrowserLaunchMode.SystemPreferred);
    }
}
