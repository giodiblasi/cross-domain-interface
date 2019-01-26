
using System;

namespace CrossDomainInterface{

    /* 
    * These are our domain types.
    * Person is the base class of our taxonomy
    */
    
    public class Person {
        public string Name {private set; get;}
        public Person(string name){
            Name = name;
        }
    }

    
    public class Student : Person,
                           ISubscriber
    {
        public Student(string name) : base(name)
        {
        }

        public void OnIncomingMessage(string message)
        {
            Console.WriteLine(string.Format("Student {0} receives\n{1}", Name, message));
            Console.WriteLine("-----------------------------------------");
        }
    }

    public class PhDStudent : Person,
                              ISubscriber,
                              IPublisher{
        public PhDStudent(string name) : base(name)
        {
        }

        public string SenderID {get{return Name;}}

        public void OnIncomingMessage(string message)
        {
            Console.WriteLine(string.Format("PhD Student {0} receives\n{1}", Name, message));
            Console.WriteLine("-----------------------------------------");
        }
    }

    public class Teacher : Person,
                           ISubscriber,
                           IPublisher
    {
        public Teacher(string name) : base(name)
        {
        }

        public string SenderID {get{return Name;}}

        public void OnIncomingMessage(string message)
        {
            Console.WriteLine(string.Format("Teacher {0} receives:\n{1}", Name, message));
            Console.WriteLine("-----------------------------------------");
        }
    }
}