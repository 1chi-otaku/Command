using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    interface ICommand
    {
        void Execute();
        void Undo();

    }
    class TVOnCommand : ICommand
    {
        TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }

    class MicrowaveCommand : ICommand
    {
        Microwave microwave;
        int time;

        public MicrowaveCommand(Microwave microwave, int timer)
        {
            this.microwave = microwave;
            time = timer;
        }
        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }

    class Controller
    {
        ICommand command;
        public Controller() { }
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void PressButton()
        {
            if (command != null)
                command.Execute();
        }
        public void PressUndo()
        {
            if (command != null)
                command.Undo();
        }
    }


}
