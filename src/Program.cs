using InterfaceExercise;

var program1 = new Program1();
var program2 = new Program2();

// program1.Run();
// program2.Go();

IStart p1 = new Program1();
IStart p2 = new Program2();

p1.Start();
p2.Start();
