using System.Runtime.InteropServices;
//print backstory for the user

Console.WriteLine("Welcome to the Haunted Mansion!");
Console.WriteLine("Your rich grandpa has recently passed away and he has left you with a lot of money and one of his Mansions.");
Console.WriteLine("now that you are the newfound owner, you decide to take a look inside.");
Console.WriteLine("the house is dated, creaky and falling appart.");
Console.WriteLine("You walk in the front door.");
Console.WriteLine("You take a look around and notice 3 ways to go.");
Console.WriteLine("where will you go? The living room dining room or upstairs?");
Console.WriteLine("or will you ???");

//promt the user for a choice
Console.Write(">");
string roomChoice = Console.ReadLine();
//ask player where they will go
if (roomChoice == "living room")
{
    Console.WriteLine("you chose to enter the living room.");
    Console.WriteLine(" As you walk in the door slams shut behind you.");
    Console.WriteLine(" what will you do now");
    //prompt the use for a choice
    Console.WriteLine(" open door | explore | wait");
    Console.Write(">");
    string livingRoomChoice = Console.ReadLine();
    if (livingRoomChoice == "open door")
    {
        Console.WriteLine(" you try to open the door, it is locked.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("a monster appears behind you and ends your life");
    }
    else if (livingRoomChoice == "explore")
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" you move the the center of the room and the floor opens up and you fall through.");
        Console.WriteLine("you quickly hit the ground and die.");
    }
    else if (livingRoomChoice == "wait")
    {
        Console.WriteLine("you sit down and wait for about 10 minutes till a monster appears.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" the monster picks you up and rips you in two.");
    }

}
else if (roomChoice == "dining room")
{
    Console.WriteLine("you start walking twards the dining room...");
    Console.WriteLine("as you get near the room you can hear the sound of people talking");
    Console.WriteLine("will you enter or leave?");
    Console.Write('>');
    string diningRoomChoice = Console.ReadLine();

    if (diningRoomChoice == "enter")
    {
        Console.WriteLine("as you walk in you see a bunch of ghosts");
        Console.WriteLine("they turn to look at you");
        Console.WriteLine("as you sit down to eat the food, you notice a faint cry for help comming from the food.");
        Console.WriteLine(" you are struck with emmence fear.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" when you regain your senses you are already already one of the many plates of food on the table.");
        Console.WriteLine(" you were eaten");
    }
    else if(diningRoomChoice == "leave")
    {
        Console.WriteLine(" you try to leave but a long clawed hand grobs you and slams you on the floor.");
        Console.WriteLine(" you get knocked out.");
        Console.WriteLine("as you wake up you find yourself tied to the dinner table beion locked at by a bunch of monsters.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("before you know it they start riping off your body parts and eating you alive.");
    }
}
else if (roomChoice == "upstairs")
{
    Console.WriteLine("you attempt to go upstairs...");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(" but the floor collapses and you fall into an inescapable pit");
    Console.WriteLine(" you wait for a few days till you invetibly parish due to lack of food and water.");
}
else if (roomChoice == "BURN")
{

}

