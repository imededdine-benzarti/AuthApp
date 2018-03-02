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

                new Student{Id=1, FullName="John Doe", Mobile="123456", Image="image1.jpg"},
                new Student{Id=2, FullName="John Does", Mobile="654321",Image="image2.jpg"},
                new Student{Id=3, FullName="John Did", Mobile="456789", Image="image3.jpg"},
                new Student{Id=4, FullName="John Done", Mobile="987654",Image="image4.jpg"},
                new Student{Id=5, FullName="John aaa", Mobile="147258", Image="image5.jpg"},
                new Student{Id=6, FullName="John bbb", Mobile="852741", Image="image6.jpg"},
                new Student{Id=7, FullName="John ccc", Mobile="963852", Image="image7.jpg"}

            }; 
      
            return ListStudent;
        }

    }
}
