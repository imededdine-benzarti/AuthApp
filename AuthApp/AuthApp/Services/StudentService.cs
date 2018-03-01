using AuthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthApp.Services
{
     public class StudentService
    {

        public List<Student> GetStudentList()
        {

            var ListStudent = new List<Student>() {

                new Student{Id=1, Name="John", LastName="Doe", Mobile="123456", Image="image1.jpg"},
                new Student{Id=2, Name="John", LastName="Does", Mobile="654321", Image="image2.jpg"},
                new Student{Id=3, Name="John", LastName="Did", Mobile="456789", Image="image3.jpg"},
                new Student{Id=4, Name="John", LastName="Done", Mobile="987654", Image="image4.jpg"},
                new Student{Id=5, Name="John", LastName="aaa", Mobile="147258", Image="image5.jpg"},
                new Student{Id=6, Name="John", LastName="bbb", Mobile="852741", Image="image6.jpg"},
                new Student{Id=7, Name="John", LastName="ccc", Mobile="963852", Image="image7.jpg"}

            }; 
      
            return ListStudent;
        }

    }
}
