using System;

namespace Net12FinalExamCode
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objClasses = new object[2];
            objClasses[0] = new Adult();
            objClasses[1] = new Child();
            foreach(var item in objClasses)
            {
                
            }
            Console.WriteLine("Hello World!");
        }
    }

    public class Adult
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
    }

    public class Child
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
    }
}
