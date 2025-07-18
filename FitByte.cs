public class FitByte
{
    //private encapsolated variables
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private int restingHR;
    public int RestingHR
    {
        get { return restingHR; }
        set { restingHR = value; }
    }
    private double targetHR;
    private double maxHR;
    public FitByte()
    {
        age = 20;
        restingHR = 65;

    }
    public FitByte(int age, int restingHR)
    {
        this.age = age;
        this.restingHR = restingHR;
    }
    public double MaxHeartrate()
    {
        maxHR = 206.3 - (0.711 * age);
        return maxHR;
    }

    public double TargetHeartrate(double percentageOfMaximum)
    {
        targetHR = (maxHR - restingHR) * percentageOfMaximum + restingHR;
        return targetHR;
    }
    public void Display()
    {
        Console.WriteLine(maxHR + " BPM");
        Console.WriteLine(targetHR + " BPM");
    }

}