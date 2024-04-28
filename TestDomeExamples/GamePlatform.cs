using System;

public class GamePlatform
{
    public static double CalculateFinalSpeed(double initialSpeed, int[] inclinations)
    {
        double finalSpeed = initialSpeed;
        for (int i = 0; i < inclinations.Length; i++)
            finalSpeed -= inclinations[i];

        if (finalSpeed < 0)
            finalSpeed = 0;
        return finalSpeed;
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(CalculateFinalSpeed(60, new int[] { 0, 30, 0, -45, 0 }));
    //}
}