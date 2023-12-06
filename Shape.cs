class Shape {
    public virtual float CalculateArea(){
        return 0;
    }
}

class Circle : Shape{
    private float radius;

    public Circle(float radius){
        this.radius = radius;
    }

    public override float CalculateArea(){
        return (float)(Math.PI * Math.Pow(radius, 2));
    }
}

//class Program{
//    static void Main(){
//        Circle myCircle = new Circle(5);
//        float area = myCircle.CalculateArea();
//        Console.WriteLine("Area: " + area);
//    }
//}
