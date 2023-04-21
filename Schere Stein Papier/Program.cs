string inputPlayer;
string inputCPU;
int randomNum;
int Playerscore = 0;
int CPUscore = 0;
do
{
    Console.WriteLine("Wähle zwischen Schere/Stein/Papier/Echse/Spock oder 'Q' zum Beenden: ");
    inputPlayer = Console.ReadLine();

    Random rnd = new();

    randomNum = rnd.Next(0, 4);

    switch (randomNum)
    {
        case 0:
            inputCPU = "Schere";
            Console.WriteLine("Computer wählt Schere!");
            if (inputPlayer == "Schere" || inputPlayer == "schere")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (inputPlayer == "Stein" || inputPlayer == "stein")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Spock" || inputPlayer == "spock")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Papier" || inputPlayer == "papier")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            else if (inputPlayer == "Echse" || inputPlayer == "echse")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            break;
        case 1:
            inputCPU = "Stein";
            Console.WriteLine("Computer wählt Stein!");
            if (inputPlayer == "Stein" || inputPlayer == "stein")
            {
                Console.WriteLine("Unentschieden!"  );
            }
            else if (inputPlayer == "Papier" || inputPlayer == "papier")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Spock" || inputPlayer == "spock")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Schere" || inputPlayer == "schere")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            else if (inputPlayer == "Echse" || inputPlayer == "echse")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            break;
        case 2:
            inputCPU = "Papier";
            Console.WriteLine("Computer wählt Papier!");
            if (inputPlayer == "Papier" || inputPlayer == "papier")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (inputPlayer == "Schere" || inputPlayer == "schere")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Echse" || inputPlayer == "echse")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Stein" || inputPlayer == "stein")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            else if (inputPlayer == "Spock" || inputPlayer == "spock")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            break;
        case 3:
            inputCPU = "Echse";
            Console.WriteLine("Computer wählt Echse!");
            if (inputPlayer == "Echse" || inputPlayer == "echse")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (inputPlayer == "Papier" || inputPlayer == "papier")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Spock" || inputPlayer == "spock")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Schere" || inputPlayer == "schere")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            else if (inputPlayer == "Stein" || inputPlayer == "stein")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            break;
        case 4:
            inputCPU = "Spock";
            Console.WriteLine("Computer wählt Spock!");
            if (inputPlayer == "Spock" || inputPlayer == "spock")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (inputPlayer == "Schere" || inputPlayer == "schere")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Stein" || inputPlayer == "stein")
            {
                Console.WriteLine("Spieler gewinnt!");
                Playerscore++;
            }
            else if (inputPlayer == "Papier" || inputPlayer == "papier")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            else if (inputPlayer == "Echse" || inputPlayer == "echse")
            {
                Console.WriteLine("Computer gewinnt!");
                CPUscore++;
            }
            break;
    }
} while (inputPlayer != "q" && inputPlayer != "Q");
Console.Clear();
Console.WriteLine("Du hast " + Playerscore + " mal gewonnen");
Console.WriteLine("Der Computer hat " + CPUscore + " mal gewonnen");