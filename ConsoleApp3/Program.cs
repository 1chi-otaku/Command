using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Invoker(ICommand command, bool undo = false)
        {
            Controller controller= new Controller();
            controller.SetCommand(command);
            controller.PressButton();
            if(undo)
                controller.PressUndo();
        }
        static void Main(string[] args)
        {
            TV tv = new TV();
            ICommand command = new TVOnCommand(tv);  
            Invoker(command,true);

            Microwave microwave = new Microwave();
            command = new MicrowaveCommand(microwave, 5000);
            Invoker(command,false);

        }
    }
}
