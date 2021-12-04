
    Console.WriteLine("What is the radius of your circle?");
    var radius = double.Parse(Console.ReadLine());
    

    double result = AreaOfCircle(radius);
    Console.WriteLine($"The area of a circle with radius of {radius} is {result}");



static double AreaOfCircle(double radius)
{
       
    return Math.PI * radius * radius;

}

