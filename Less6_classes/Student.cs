using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6_classes
{
    internal class Student
    {
        //властивості properties
        private int myAge;

        //public int MyAge { get; set; }
        public Student(int age)
        {
           this.MyAge = age;
        }
        public int MyAge
        {
            get
            {
                return myAge;
            }
            set
            {
                if (value < 0 && value > 120)
                    throw new ArgumentException("Error");
                myAge = value;
            }
        }

        //private string _name = String.Empty;
        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string name)
        //{
        //    this._name = name;
        //}
    }
}
