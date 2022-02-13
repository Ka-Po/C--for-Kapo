using System;

namespace StatePatten
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Context switchContext = new Context();

            State_1 S1 = new State_1(switchContext);

            switchContext.ChangeState(S1);

            switchContext.ExcStateMothed(1);

            switchContext.ExcStateMothed(2);

            switchContext.ExeM2();

            //switchContext.ExcStateMothed(2);

            //Console.WriteLine("Hello World!");
        }
    }

    public class Context
    {
        State _state = null;

        public void ChangeState(State newState)
        {
            _state = newState;
        }

        public void ExcStateMothed(int _int)
        {
            _state.DisplaySomething(_int);
        }

        public void ExeM2()
        {
            _state.M2();
        }

    }

    public abstract class State
    {
        public Context _switchContext = null;

        public State(Context switchContext)
        {
            _switchContext = switchContext;
        }

        public abstract void DisplaySomething(int _int);

        public virtual void M2() { Console.WriteLine("Come Form State class Show M2!"); }

    }

    public class State_1 : State
    {
        public State_1(Context switchContext) : base(switchContext) { }

        public override void DisplaySomething(int _int)
        {
            if (_int == 1)
            {
                Console.WriteLine("Here is State 1!");
            }
            if (_int == 2)
            {
                Console.WriteLine("Create State 2!");
                _switchContext.ChangeState(new State_2(_switchContext));
            }
        }

        public class State_2 : State
        {
            public State_2(Context switchContext) : base(switchContext) { }

            public override void DisplaySomething(int _int)
            {
                if (_int == 2)
                {
                    Console.WriteLine("Here is State 2!");
                }
                if (_int == 3)
                {
                    Console.WriteLine("Create State 3!");
                    _switchContext.ChangeState(new State_1(_switchContext));
                }

            }

             public override void M2()
            {
                Console.WriteLine(" State 2 execute M2!");

            }
        }
        public class State_3 : State
        {
            public State_3(Context switchContext) : base(switchContext) { }

            public override void DisplaySomething(int _int)
            {

            }
        }
    }
}
