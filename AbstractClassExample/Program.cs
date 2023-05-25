using AbstractClassExample;

//var beagle = new Dog();

//beagle.AbstractAnimal();

//beagle.VirtualAnimal();

var circleA = new Circle(25);
circleA.Name = "Circla A";

Console.WriteLine($"The area of a circle with a radius of {circleA.Radius} is {circleA.CalculateArea()}");

circleA.VirtualShape();

var triangle = new Triangle();


triangle.VirtualShape();
