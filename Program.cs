double fa, ce;

Console.Write("Digite a temperatura (F°): ");
fa = Convert.ToDouble(Console.ReadLine());

ce = (fa - 32) / 1.8;

Console.WriteLine($"\n{fa} F° equivalem a {ce} C°\n");
