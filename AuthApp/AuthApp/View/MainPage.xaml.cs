using Android.App;
using AuthApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AuthApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void StudentItemTapped(object sender, ItemTappedEventArgs e)
        {
            var student = e.Item as Student;
            DisplayAlert("Student Info", student.Image, "\n ID:" + student.Id + "\n FullName:" + student.FullName + "\n Mobile:" + student.Mobile, "Ok");
           
        }


        private void ClickGoBack(object o, EventArgs e)
        {

             Navigation.PopModalAsync();
        }


    }
}
