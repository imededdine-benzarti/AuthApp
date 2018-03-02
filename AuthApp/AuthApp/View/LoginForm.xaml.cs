using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AuthApp.View
{
	public partial class LoginForm : ContentPage
	{
		public LoginForm ()
		{
			InitializeComponent ();
		}

        private void Connect(object sender, EventArgs e)
        {
            String username = Username.Text;
            String password = Password.Text;


            if (username == "admin" && password == "admin")
            {
                Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                DisplayAlert("ERROR", "ERROR", "OK");
            }

        }

    }
}