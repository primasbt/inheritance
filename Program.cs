using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person("Mike", 29);
            person.GetNameAndAge();

            Teacher tch = new Teacher("Thomas", 22, "209148", "Math");
            tch.GetNameAndAge();

            Student std = new Student("Sara", 19, "901341", "augag@gmail.com");
            std.GetNameAndAge();
        }
    }
}