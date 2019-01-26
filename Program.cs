using System;
using System.Collections.Generic;

namespace CrossDomainInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var peter = new Student("Peter");
            var maggie = new PhDStudent("Maggie");
            var sarah = new Teacher("Sarah");
            
            peter.Subscribe(MessageManager.CODING_TOPIC);
            maggie.Subscribe(MessageManager.CHEMISTRY_TOPIC);
            sarah.Subscribe(MessageManager.CHEMISTRY_TOPIC);

            maggie.Publish(MessageManager.CHEMISTRY_TOPIC, "I'm working on a new formula!");
            sarah.Publish(MessageManager.CODING_TOPIC, "It's ready a new lesson about JavaScript");
            sarah.Publish(MessageManager.CHEMISTRY_TOPIC, "It's ready a new lesson about pH");

            
        }
    }
}
