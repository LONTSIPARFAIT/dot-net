using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DotNet
{
    internal class Student
    {
        public String Name { get; set; }
        public String Register { get; set; }
        public String Class { get; set; }
        public String Section { get; set; }

        public Student(string name, string register, string @class, string section)
        {
            Name = name;
            Register = register;
            Class = @class;
            Section = section;
        }
    }

}
