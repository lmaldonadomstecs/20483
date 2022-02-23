using System;

namespace Zoo
{
    enum livingState {
        Alive,
        Dead
    }
    enum healthState {
        Good,
        Sick
    }


    struct Address {
        public string street;
        public string streetNumber;
        public string city;
        public string state;
        public string postalCode;
    }

    // Base class
    abstract class DbContext
    {
        private livingState livingState;
        private healthState healthState;
        private int age;
        private bool hungry;
        protected string voice;
        protected Address address;

        public Animal (livingState livingState = livingState.Alive, healthState healthState = healthState.Good, int age = 0, bool hungry = false) {
            this.livingState = livingState;
            this.healthState = healthState;
            this.age = age;
            this.hungry = hungry;
        }

        public bool isAlive() {
            if (this.livingState == livingState.Alive) {
                return true;
            } else {
                return false;
            }
        }
        public bool isHealthy() {
            if (this.healthState == healthState.Good) {
                return true;
            } else {
                return false;
            }
        }
        public int getAge() {
            return this.age;
        }
        public bool isHungry() {
            return this.hungry;
        }
    }
}