//Taking the users data and convetting it into intigers
Console.WriteLine("Please enter your age.");
int age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Please enter your resting heartrate.");
int restingHR = Convert.ToInt16(Console.ReadLine());

//FitByte a = new();
new FitByte(age, restingHR);
