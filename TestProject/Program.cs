using ThirdPractical_CarLibrary;

class Program
{
    static void Main(string[] args)
    {
        Engine engine = new Engine();
        Engine engine1 = new Engine(4, 210);
        Car car = new Car("Ford", "Fiesta", 2016, engine);

        car.Drive();
        car.Stop();
    }
}