using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {

        //private String name;
        //public String Name { get { return name; } }
        //public void Name { set { Name = value } }
        public string Name { get; set; }


        public int BirthDate { get; set; }
        

       public enum Gender
        {
            Male,
            Female
        }

        public Gender gender = Gender.Male;

        public Person(string name, int birthDate, Gender gender)
        {
            Name = name;
            BirthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            String Ppronoun = "";
            switch (gender)
            {
                case Gender.Male:
                    Ppronoun = "He";
                    break;
                case Gender.Female:
                    Ppronoun = "She";
                    break;
            }
            String s = Ppronoun + "'s called: " + Name + " and " + Ppronoun + " was born in " + BirthDate;
            return s;
                        }
        static void Main(string[] args)
        {
            Person person = new Person("Béla", 1900, Gender.Male);
            Console.WriteLine(person.ToString());
            Console.Read();
        }

    }
}
