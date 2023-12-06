class Student{
    private string name;
    private int age;
    private string major;

    public Student(string name, int age, string major){
        this.name = name;
        this.age = age;
        this.major = major;
    }

    public void Introduce(){
        System.Console.WriteLine($"My name is {name} and I'm {age} years old, and my major is in {major}.");
    }
}

//class Program{
//    static void Main()
//    {
//        Student a = new("Sulav Kafle", 20, "Bsc Hons. Computing");
//        a.Introduce();
//    }
//}