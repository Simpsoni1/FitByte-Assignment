public class FitByte
{
    //private encapsolated variables.
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    //private encapsolated variables.
    private int restingHR;
    public int RestingHR
    {
        get { return restingHR; }
        set { restingHR = value; }
    }
    private double targetHR;
    private double maxHR;
    //Default values for the class.
    public FitByte()
    {
        age = 20;
        restingHR = 65;

    }
    //Lets the user set their age and heart rate.
    public FitByte(int age, int restingHR)
    {
        this.age = age;
        this.restingHR = restingHR;
    }
    //Calculates max heart reate when called.
    public double MaxHeartrate()
    {
        maxHR = 206.3 - (0.711 * age);
        return maxHR;
    }
    //Callculate target heart rate when called.
    public double TargetHeartrate(double percentageOfMaximum)
    {
        targetHR = (maxHR - restingHR) * percentageOfMaximum + restingHR;
        return targetHR;
    }
    //Displays both max and target heart rate when called.
    public void Display()
    {
        Console.WriteLine(maxHR + " BPM");
        Console.WriteLine(targetHR + " BPM");
    }

}