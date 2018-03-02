using Android.App;
using AuthApp.Models;
using AuthApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AuthApp.ViewModel
{
    public class StudentViewModel: INotifyPropertyChanged
    {
      
        public List<Student> _StudentList;

        public List<Student> ListStudentList
        {
            get { return _StudentList; }
            set {
                _StudentList = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public StudentViewModel()
        {

            var studentService = new StudentService();
            ListStudentList = studentService.GetStudentList();
        }

        protected virtual void OnPropertyChanged(string propertyname=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

      


    }
}
