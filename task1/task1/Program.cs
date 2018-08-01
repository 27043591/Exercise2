using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee1 = new Person("mani, bhardwaj , 25 , 18% , 12503562125");
            Console.WriteLine(employee1.Fname);
            Console.WriteLine(employee1.Lname);
            Console.WriteLine(employee1.PayRate);
            Console.WriteLine(employee1.Tax);
            Console.WriteLine(employee1.Anumber);
        }
    }
    public class Person
    {
        string fname;
        string lname;
        string payrate;
        string tax;
        string anumber;

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
  
        public string PayRate
        {
            get
            {
                return payrate;
            }
            set
            {
                payrate = value;
            }
        }
        
        public string Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        public string Anumber
        {
            get
            {
                return anumber;
            }
            set
            {
                anumber = value;
            }
        }
        public Person(string _fname, string _lname, string _)
        {
            Fname = _fname;
           
        }
    }
}
