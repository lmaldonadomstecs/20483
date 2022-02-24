using System;

namespace Zoo
{
    // Derived class
    class Cat<T> : Pet
    {
        public Cat (string voice = "meow", string name = "Garfield", string owner = "John") {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
        }
        // GARBAGE COLLECTOR
        ~Cat () {
            
        }

        public override void communicate()
        {
            
        }

        public override int strenght()
        {
            return 0;
        }
    }
}