using System.Drawing;

class MyClass
{
    public static void Main(string[] args)
    {
        car elantra = new car();
        elantra.Color = "red";
        car xuv= new car();
        xuv.Color = "black";
        elantra.Speed = 120.5m;
        xuv.Speed = -100m;

        Console.WriteLine("Elantra color: " + elantra.Color);
        Console.WriteLine("XUV color: " + xuv.Color);
        Console.WriteLine("Elantra speed: " + elantra.Speed);
        Console.WriteLine("XUV speed: " + xuv.Speed);
    }
}
class car

{
   private String color;
    public String Color{
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
     
    private decimal speed;

    public decimal Speed
    {
        get
        {
            return speed;
        }
        set
        {
            if(value>=0) {
                speed = value;
            }
        }
    }



}