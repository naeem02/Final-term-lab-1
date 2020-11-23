using System;
using System.Collections.Generic;
using System.Text;


namespace Account_Type
{
    class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public Employee() { }
        public Employee(string name,string id, double balance)
        {
            this.name = name;
            this.id = id;
            //this.balance = balance;

        }
        
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
           
        }
    }
}