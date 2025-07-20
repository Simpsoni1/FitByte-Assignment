// calling a new instance of a class
FitByte a = new(30, 60);
a.MaxHeartrate();
a.TargetHeartrate(0.75);
a.Display();

Games mario = new();
mario.Name = "Mario";
mario.genre = Genre.Platformer;
Games ror2 = new();
ror2.Name = "Risk of Rain 2";
ror2.genre = Genre.Roguelike;
mario.Play(50);
ror2.Play(45);
mario.Play(25);
Console.WriteLine(mario.gamedetails());
Console.WriteLine(ror2.gamedetails());