using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to build a PC gamer","Techsav43",400);
        Video video2 = new Video("Top 10 places you cannot miss in Rome","TravelRom3",1200);
        Video video3 = new Video("Upcoming 2025 movies I want to see", "TheMovieFiles", 1342);
        Video video4 = new Video("Classes made easy on C#", "BroCodes",350);

        video1._comments.Add(new Comments("QuantumWaffle","Step 1: Cry about GPU prices. Step 2: Repeat."));
        video1._comments.Add(new Comments("RavioliRoller69","I followed this guide, now my PC sounds like a jet engine. Help."));
        video1._comments.Add(new Comments("UnstableTable","Building was easy, but cable management is my final boss."));
        video1._comments.Add(new Comments("SpicyKeyboardWarrior","Amazing video!, keep up the good work"));
        
        video2._comments.Add(new Comments("SoggyNachoKing","I went to Rome and somehow only found McDonald’s. Oops"));
        video2._comments.Add(new Comments("CrispyAvocado69","The real challenge is surviving the scooter traffic."));
        video2._comments.Add(new Comments("DuckOverlord9000","Where’s the ‘places to avoid’ video?"));
        video2._comments.Add(new Comments("EchoEchoEcho123","Watched this, packed my bags, and now I’m lost in Rome."));
    
        video3._comments.Add(new Comments("CabbageProphet","No way they’re making Fast & Furious 15 already!"));
        video3._comments.Add(new Comments("FlamingoInDisguise","I hope at least one of these isn't a reboot of a reboot"));
        video3._comments.Add(new Comments("BaguetteBandit","Talking about superheroe-fatigue..."));
        video3._comments.Add(new Comments("UnstableTable","Me gustan las peliculas"));
    
        video4._comments.Add(new Comments("CabbageProphet","BroCodes? More like ProCodes!"));
        video4._comments.Add(new Comments("BananaInPajamas","Console.WriteLine(‘I’m still confused’);"));
        video4._comments.Add(new Comments("404BrainNotFound","C# classes are easy? That’s the funniest joke in this video"));
        video4._comments.Add(new Comments("SpicyKeyboardWarrior","Finally, a class I don’t have to attend at 8 AM."));

        Console.WriteLine();
        video1.DisplayVideo();
        Console.WriteLine();
        video2.DisplayVideo();
        Console.WriteLine();
        video3.DisplayVideo();
        Console.WriteLine();
        video4.DisplayVideo();


    }
}