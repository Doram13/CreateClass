using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        private int Salary { get; set; }
        private string Profession { get; set; }
        protected Room RoomNumber { get; set; }

        // Why do I have to add roomNumber in the constructor? How could I add a roomNumber after creating the employee with its setter?

        public Employee(string name, int birthDate, Gender gender, int salary, string profession, Room roomNumber) :
            base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.RoomNumber = roomNumber;
        }

        /* WHY won't this work??? 
        public setRoomNumber(int roomNumber)
        {
            this.RoomNumber = roomNumber;
        }
        */

        public new string ToString()
        {
            string pronoun = base.getPronoun();
            return pronoun + " gets " + this.Salary + " as a " + Profession + " in the room " + RoomNumber.RoomNumber;
        }

        // If I write "override" instead of "new" at ToString(), then it will ovverride its base class no matter what, and I will not be able
        // to print the Person properties for an employee object (only the employee properties)! 
    

    public object Clone()
        {
            //return this.MemberwiseClone();
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.RoomNumber = new Room(5);
            return newEmployee;
        }

    }
}
