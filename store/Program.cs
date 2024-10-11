int pengar = 2500;

while (pengar > 0)
{
  Console.WriteLine($"Du har ${pengar}.");


  Console.WriteLine("Vilket par skor vill du köpa?");
  Console.WriteLine("1. Balenciaga Tracks ($1000)");
  Console.WriteLine("2. Jordan 4 Retro Black Cats ($880)");
  Console.WriteLine("3. Vetements Black New Rock Edition Platforms ($1280)");
  Console.WriteLine("4. Nike Air Force 1 Low ($110)");

  string vadKopa = "";
  while (vadKopa != "1" && vadKopa != "2" && vadKopa != "3" && vadKopa != "4")
  {
    vadKopa = Console.ReadLine();
  }


  int prisPerForemal = 0;

  if (vadKopa == "1")
  {
    prisPerForemal = 1000;
  }
  else if (vadKopa == "2")
  {
    prisPerForemal = 880;
  }
  else if (vadKopa == "3")
  {
    prisPerForemal = 1280;
  }
  else if (vadKopa == "4")
  {
    prisPerForemal = 110;
  }

  Console.WriteLine("Hur många vill du köpa?");
  int numKopa = 0;
  while (numKopa == 0)
  {
    string num = Console.ReadLine();
    bool success = int.TryParse(num, out numKopa);
    if (success == false)
    {
      Console.WriteLine("Du måste skriva en siffra!");
    }
  }

  int slutkostand = prisPerForemal * numKopa;

  if (slutkostand <= pengar)
  {
    Console.WriteLine("Tack, det går bra.");
    pengar -= slutkostand;
  }
  else
  {
    Console.WriteLine("Det har du tyvärr inte råd med.");
  }
}

Console.WriteLine("Nu har du slut på pengar.");
Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();