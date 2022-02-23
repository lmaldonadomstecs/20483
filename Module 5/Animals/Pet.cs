using System;

namespace Zoo
{
    // Derived class
    abstract class ListOfContextClass : DbContext
    {
        public ListOfContextClass () : base() {
            
        }
        protected string name;
        protected string owner;

        public void readCollar() {
            Console.WriteLine("My name is {0} and my owner is {1}", this.name, this.owner);
        }

        public virtual void communicate() {
            Console.WriteLine("Pet class comunicate");
        }

        public abstract int strenght();
    }
}