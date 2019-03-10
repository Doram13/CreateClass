using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        /* Don't use private properties because this way it becomes purposeless.
        modify like this. This is named full-property which means you implement the backing private field as well:
        private int _salary;
        
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        
        if it's enough the very basic getting and setting mechanism than you can use so-called auto-property:
        public int AutoSalary { get; set; }
        It generates the same code as above but in the background.
        
        check the following link: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        */
        private int Salary { get; set; }
        private string Profession { get; set; }
        protected Room RoomNumber { get; set; }

        // Why do I have to add roomNumber in the constructor? How could I add a roomNumber after creating the employee with its setter?
        // You don't need it in the constructor. Actually, right now itscontrsuctor getting too complex because of the too many params
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
            this.RoomNumber = roomNumber; // Because the Room is not an Integer value. You have to instantiate the Room with the value coming from the parameter
            // this.RoomNumber = new Room(roomNumber);
        }
        */

        public new string ToString()
        {
            string pronoun = base.getPronoun();
            return pronoun + " gets " + this.Salary + " as a " + Profession + " in the room " + RoomNumber.RoomNumber;
        }

        // If I write "override" instead of "new" at ToString(), then it will ovverride its base class no matter what, and I will not be able
        // to print the Person properties for an employee object (only the employee properties)!
        
        /* You can refer to your base class' fields and methods (including ToString()) with the `base` keyword
        public override string ToString()
        {
            return $"{base.ToString()}, salary: {Salary}, profession: {Profession}, room: {Room.Number}";
        }
        
        If you use the `new` keyword it will totally hide the base class implementation. You don't need that in this situation
        Check: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/versioning-with-the-override-and-new-keywords
        */
    

    public object Clone()
        {
            //return this.MemberwiseClone();
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.RoomNumber = new Room(5);
            return newEmployee;
        }

    }
}
