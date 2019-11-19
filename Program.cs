using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUserCounterMCSDemo
{
  public class User
    {
        //..
        private int duration;
        static private int count; //used to track of the total number of user ojbects we have created
        static public int Count
        {
            get
            {
                return count;
            }//we dont need to edit the object count, so we only define a get accessor for it.
        }

        public int Duration { get => duration; set => duration = value; }

        static User()//special type of constructor used to initialize the values of static variables and other validations
        {
            

//This ctor is executed only once during the run of a program, unlike other constructors run each time when any object
//is created
//It has no access modifier. It is not explicitly called by code, it is called by the .net runtime so it has to be publicly accessible
            count = 0;
        }
        public User(int _duration)
        {
            this.Duration = _duration;
        }
        public User()
        {//ordinary class constructor simply increments the count variable.
      
            count++;
        }
        static void something()
        {
            
        }
    }
    class Program
    {
        static int one;
        public int second;
       static  Program()
        {
            Console.WriteLine("I am called first:\n");
            one++;
        }
        int something()
        {
           
            return 0;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("In main now");
            Console.WriteLine(one);//static field can be accessed direct inside a static block as Main is static here
            Console.WriteLine($"User count is {User.Count}");
            Console.WriteLine("Creating User Alex...");
           
            User alex = new User();
            Console.WriteLine($"User count is {User.Count}");

            User rob = new User();

            Console.WriteLine($"After creating Rob...User count is {User.Count}");

            User jane = new User();
            Console.WriteLine($"User count is {User.Count}");

            var John = new User(12);
           
            Console.ReadKey();

        }
       
    }
}
