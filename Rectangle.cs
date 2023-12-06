class Rectangle{
    private float length;
    private float width;

    public Rectangle(float width, float length){
        this.width = width;
        this.length = length;
    }

    public float CalculateArea(){
        return length * width;
    }
}

//class Program{
//    static void Main(){
//        Rectangle myRectangle = new Rectangle(4.5f, 3.2f);
//        float area = myRectangle.CalculateArea();
//        Console.WriteLine("Area: " + area);
//    }
//}
