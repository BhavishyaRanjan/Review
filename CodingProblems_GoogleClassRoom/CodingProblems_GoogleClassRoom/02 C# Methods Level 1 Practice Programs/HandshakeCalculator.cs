using System;

namespace CodingProblems_GoogleClassRoom;

public class HandshakeCalculator
{
    public int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    public void Run()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(numberOfStudents);
        Console.WriteLine($"Maximum number of handshakes: {handshakes}");
    }
}
