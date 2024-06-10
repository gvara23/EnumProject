using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProject
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Ecolors Color { get; set; }
        public User(string name, string lastName, Ecolors color)
        {
            Name = name;
            LastName = lastName;
            Color = color;
        }
        public override string ToString()
        {
            return $"Name : {Name}\nLastName : {LastName}\nColor : {Color.GetDescription()}";
        }
    }
}
