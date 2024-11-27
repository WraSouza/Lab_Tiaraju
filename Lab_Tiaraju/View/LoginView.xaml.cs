using Lab_Tiaraju.ViewModel;

namespace Lab_Tiaraju.View;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel model)
	{
		InitializeComponent();

		BindingContext = model;

    }
}