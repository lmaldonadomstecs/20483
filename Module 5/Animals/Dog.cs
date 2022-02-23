using System;

namespace Zoo
{
    // Derived class
    class Dog : Pet
    {
        public Dog (string voice = "woof", string name = "Odie", string owner = "John") {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
            this.address.street = "A street";
            this.address.streetNumber = "1005";
        }
        public override void communicate() {
            Console.WriteLine("Dog class communicate");
        }

        public override int strenght()
        {
            return 0;
        }
    }
}