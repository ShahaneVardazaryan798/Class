using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassObject
{
    class Student
    {
       private int age;
       private string gender;
       private string education;

        public int Age
        {
            get
            {
                if (age <= 35 && age >= 16)
                {
                    Console.WriteLine("The age of student = "+age);
                }
                else
                {
                    Console.WriteLine("The age is not current");
                }
                return age;
            }
            set
            {
                if (age <= 35 && age >= 16)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("The age is not true");
                }
                
            }   
        }
        public string Gender { get => gender; set => gender = value; }
        public string Education { get => education; set => education = value; }
    }
}
