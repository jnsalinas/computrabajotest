using ComputrabajoTest.App.ViewModels;
using ComputrabajoTest.Entities;

namespace ComputrabajoTest.App.Views;

public partial class Users : ContentPage
{
	public Users()
	{
		InitializeComponent();
	}


    /// <summary>
    /// action item selected
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void lsvUsers_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        var selection = e.SelectedItem as User;
        await _internalDetail(selection);
    }

    /// <summary>
    /// go to userdetail page and seearch item selected with detail
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    private async Task _internalDetail(User user)
    {
        UserDetail userDetail = new UserDetail();
        UserVM userVM = BindingContext as UserVM;
        userVM.selectedUser = user;
        userVM.GetUserDetailCommand.Execute(null);
        userDetail.BindingContext = userVM;

        await App.Current.MainPage.Navigation.PushAsync(userDetail);
    }
}
