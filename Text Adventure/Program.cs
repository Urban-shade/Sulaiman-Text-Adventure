using System.Runtime.InteropServices;
static void writeLetterByLetter(string text)
{
    for (int i = 0; i < text.Length; i++)
    {
        Console.Write(text[i]);
        Thread.Sleep(20);
    }
    Console.WriteLine();
}
//print backstory for the user

writeLetterByLetter("Welcome to the Haunted Mansion!");
Thread.Sleep(1000);
writeLetterByLetter("Your rich grandpa has recently passed away and he has left you with a lot of money and one of his Mansions.");
Thread.Sleep(1000);
writeLetterByLetter("now that you are the newfound owner, you decide to take a look inside.");
Thread.Sleep(1000);
writeLetterByLetter("the house is dated, creaky and falling appart.");
Thread.Sleep(1000);
writeLetterByLetter("You walk in the front door.");
Thread.Sleep(1000);
writeLetterByLetter("You take a look around and notice 3 ways to go.");
Thread.Sleep(1000);
writeLetterByLetter("where will you go? The living room dining room or upstairs?");
Thread.Sleep(1000);
writeLetterByLetter("or will you ???");

//promt the user for a choice
Console.Write(">");
string roomChoice = Console.ReadLine();
//ask player where they will go
if (roomChoice == "living room")
{
    writeLetterByLetter("you chose to enter the living room.");
    Thread.Sleep(1000);
    writeLetterByLetter(" As you walk in the door slams shut behind you.");
    Thread.Sleep(1000);
    writeLetterByLetter(" what will you do now");
    Thread.Sleep(1000);
    //prompt the use for a choice
    writeLetterByLetter(" open door | explore | wait");
    Console.Write(">");
    string livingRoomChoice = Console.ReadLine();
    if (livingRoomChoice == "open door")
    {
        writeLetterByLetter(" you try to open the door, it is locked.");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        writeLetterByLetter("a monster appears behind you and ends your life");
    }
    else if (livingRoomChoice == "explore")
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        writeLetterByLetter(" you move the the center of the room and the floor opens up and you fall through.");
        Thread.Sleep(1000);
        writeLetterByLetter("you quickly hit the ground and die.");
    }
    else if (livingRoomChoice == "wait")
    {
        writeLetterByLetter("you sit down and wait for about 10 minutes till a monster appears.");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        writeLetterByLetter(" the monster picks you up and rips you in two.");
    }

}
else if (roomChoice == "dining room")
{
    writeLetterByLetter("you start walking twards the dining room...");
    Thread.Sleep(1000);
    writeLetterByLetter("as you get near the room you can hear the sound of people talking");
    Thread.Sleep(1000);
    writeLetterByLetter("will you enter or leave?");
    Console.Write('>');
    string diningRoomChoice = Console.ReadLine();

    if (diningRoomChoice == "enter")
    {
        writeLetterByLetter("as you walk in you see a bunch of ghosts");
        Thread.Sleep(1000);
        writeLetterByLetter("they turn to look at you");
        Thread.Sleep(1000);
        writeLetterByLetter("as you sit down to eat the food, you notice a faint cry for help comming from the food.");
        Thread.Sleep(1000);
        writeLetterByLetter(" you are struck with emmence fear.");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        writeLetterByLetter(" when you regain your senses you are already already one of the many plates of food on the table.");
        Thread.Sleep(1000);
        writeLetterByLetter(" you were eaten");
    }
    else if(diningRoomChoice == "leave")
    {
        writeLetterByLetter(" you try to leave but a long clawed hand grobs you and slams you on the floor.");
        Thread.Sleep(1000);
        writeLetterByLetter(" you get knocked out.");
        writeLetterByLetter("as you wake up you find yourself tied to the dinner table beion locked at by a bunch of monsters.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        writeLetterByLetter("before you know it they start riping off your body parts and eating you alive.");
    }
}
else if (roomChoice == "upstairs")
{
    writeLetterByLetter("you attempt to go upstairs...");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    writeLetterByLetter(" but the floor collapses and you fall into an inescapable pit");
    Thread.Sleep(1000);
    writeLetterByLetter(" you wait for a few days till you invetibly parish due to lack of food and water.");
}
else if (roomChoice == "BURN IT DOWN")
{
    writeLetterByLetter(" insted of keeping the house you decide it is not worth it to keep the house.");
    Thread.Sleep(1000);
    writeLetterByLetter("you exit the mansion soon after entering.");
    Thread.Sleep(1000);
    writeLetterByLetter(" after leaving you aproch your truck which you have a conveniently placed flame thrower in.");
    Thread.Sleep(1000);
    writeLetterByLetter(" after grabbing the flame thrower you walk back and set the house ablaze with it");
    Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.Green;
    writeLetterByLetter("you watch and hear all the monsters cries as they burn in the fire.");
}
else 
{
    Console.WriteLine(" you stood there doing nothing for a few minutes");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("a bunch of monsters come out off all the rooms and start riping you appart.");
}

