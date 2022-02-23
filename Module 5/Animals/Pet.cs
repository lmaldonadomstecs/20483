using System;

namespace Zoo
{
    // Derived class
    abstract class Pet : Animal
    {
        public Pet () {
            
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