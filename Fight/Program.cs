Console.WriteLine("vad är dit namn");
string name = Console.ReadLine();
Console.Clear();

Entety Player = new();
Entety Enemy = new();
Random generator = new Random();

Console.WriteLine("you wake up in in your bed...");
Console.WriteLine("you start to feal worse and worse the more you get awake.");
Console.WriteLine("you start to remember were you are...");
Console.WriteLine("you remaber that you are a gladiator and youre next match is a spacial");
Console.WriteLine("that it is inspierd by chess and that you will take turns picking and then fithing to then pick a new wapone and cuntinu.");
Console.WriteLine("you hear bang on the door you know what time it is");
Console.WriteLine("you don't whant to go but you must.");
Console.WriteLine("you see a weapon case there are 3 weapons...");

Player.name = "";
int ene = generator.Next(3);
if(ene == 1)
{
    name = "Felix";
}
else if(ene == 2)
{
    name = "Hugo";
}
else 
{
    name = "Atle";
}
Enemy.hpe = 50;

Player.hp = 50; 

int sledgehammer;
int kniv;
int gun;
int fist;
string choose;
int p;
int dm = 0;
int dme = 0;
string pe;
int g;
while (Player.hp > 0)
{
// entety.hp = 50;
// entety.hpe = 50;
    if (Enemy.hp > 0)
    {
        sledgehammer = generator.Next(16);
        sledgehammer += 3;

        kniv = generator.Next(6);
        kniv += 7;

        fist = generator.Next(3);
        fist += 3;
        if(generator.Next(101) < 50){
            gun = 1000;
        }
        else{
            gun = 0;
        }

        p = generator.Next(3);
        p ++;
        Console.WriteLine("1. knife 2. slagehammer 3. none 4. gun");
        Console.WriteLine("you choose..");
        choose = Console.ReadLine();
        if(choose == "1")
        {
            dm = kniv;
        }
        else if (choose == "2")
        {
            dm = sledgehammer;
        }
        else if(choose == "3")
        {
            dm = fist;
        }
        else if(choose == "4")
        {
            if(gun != 0)
            {
                Console.WriteLine("the gun worked! you killd the gladiator!");
            }
            else if(gun == 0)
            {
                Console.WriteLine("The gun faild! you stand there like an idiot!");

            }
            dm = gun;

        }
        if(p == 1)
        {
            dme = kniv;
        }
        else if (p == 2)
        {
            dme = sledgehammer;
        }
        else if(p == 3)
        {
            dme = fist;
        }

        Player.hp = Player.hp - dme;
        Enemy.hpe = Enemy.hpe - dm;
        g = Player.hp + Enemy.hpe;
        choose = Player.hp.ToString();
        pe = Enemy.hpe.ToString();
        Console.Clear();
        Console.WriteLine(Player.name + choose);

        Console.WriteLine(Enemy.name + pe);

        
        if (g <= 0)
        {
            Console.WriteLine("Båda dog ingen van");
            Console.WriteLine("tryck 1 för att gå vidare eller skriv 0 för att tästa din tur");
            
            choose = Console.ReadLine();
            if (choose == "1")
            {
                Environment.Exit(0);
            }


        }
        if (Player.hp <= 0)
        {
            Console.WriteLine("du förlora!!!");
            Console.WriteLine(Enemy.name, "van!!!");
            Console.WriteLine("tryck 1 för att gå vidare eller skriv 0 för att tästa din tur");
            
            choose = Console.ReadLine();
            if (choose == "1")
            {
                Environment.Exit(0);
            }

        }
        if (Enemy.hpe <= 0)
        {
            Console.WriteLine("du van!!!");
            Console.WriteLine("tryck 1 för att gå vidare eller skriv 0 för att tästa din tur");
            
            choose = Console.ReadLine();
            if (choose == "1")
            {
                Environment.Exit(0);
            }


        }
    }
   
    Console.ReadLine();
    
}



Console.ReadLine();

