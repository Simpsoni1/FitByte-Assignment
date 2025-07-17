public class FitByte
{
    //private
    private int age;
    private double targetHR;
    private double maxHR;
    public FitByte(int age, int restingHR)
    {
        maxHR = 206.3 - (0.711 * age);
        Console.WriteLine(maxHR);
        targetHR = (maxHR - restingHR) * 0.75 + restingHR;
        Console.WriteLine(targetHR);
    }


}