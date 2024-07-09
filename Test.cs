namespace Test {
    public class BaseClass
    {
        public virtual void DisplayJohn()
        {
            Person person = new() { Age = 30 };
            person.ChangeName("George");
            person.Display();
        }

        public void Display()
        {
            Console.WriteLine("This is a base class");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Show()
        {
            Console.WriteLine("This is a derived class");
        }
    }

    class OtherDerived : BaseClass
    {
        public override void DisplayJohn()
        {
            Console.WriteLine("Different display john");
        }
    }

    class DistantRelative : DerivedClass
    {
        public void DisplayNew()
        {
            Console.WriteLine("Distant class");
        }

        public void DisplayNew(int num)
        {
            Console.Write($"Overload! Number is {num}");
        }
    }

    public class Person
    {
        private string name = "Jack";
        public string Name 
        { 
            get { return name; } 
            private set { name = value; }
        }
        public int Age { get; set; }

        public void ChangeName(string name)
        {
            if (name != "")
                Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public void CallInherited()
        {
            DerivedClass derived = new();
            derived.Display();
        }

        public void CallDistant()
        {
            DistantRelative distant = new();
            distant.Display();
            distant.Show();
            distant.DisplayNew();
            distant.DisplayJohn();
            distant.DisplayNew(33);

            OtherDerived other = new();
            other.DisplayJohn();
        }
    }

    public class AlertButton : Button, IDraggable
    {
        public override void Click()
        {
            Console.WriteLine("Danger!");
        }

        public void Drag()
        {
            Console.WriteLine("Dragging button!");
        }
    }

    public abstract class Button
    {
        public abstract void Click();
    }

    public interface IDraggable
    {
        void Drag();
    }

}
