class DaiyLearnings
{
    static void Main(String[] args)
    {
        String day = Console.ReadLine();
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Today is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Today is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("Today is Wednesday");
                break;
            default:
                Console.WriteLine("The is not a valid day");
                break;
        }
    }
}