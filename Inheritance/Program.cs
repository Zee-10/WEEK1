namespace Inheritance
{
    interface IAnimal
    {
        void Eat();
    }

    // Define interface for Pet actions
    interface IPet
    {
        void Play();
    }

    // Base class for general behavior
    class Mammal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    // Derived class that implements both interfaces and inherits from Mammal
    class Dog : Mammal, IAnimal, IPet
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }

        public void Play()
        {
            Console.WriteLine("Dog is playing...");
        }

        // Overriding the virtual method from Mammal
        public override void Sleep()
        {
            Console.WriteLine("The Dog is Sleeping");
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Dog dog = new Dog();
                dog.Eat();    // Implemented from IAnimal
                dog.Play();   // Implemented from IPet
                dog.Sleep();  // Overridden from Mammal

                // You can also use the interfaces to reference the Dog object
                IAnimal animal = dog;
                animal.Eat();

                IPet pet = dog;
                pet.Play();
            }
        }
    }
}
