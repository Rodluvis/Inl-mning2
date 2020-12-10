using Inlämning2;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Inlämning2
{
    class GroupMember
    {
        private string name;
        private int age;
        private string birthdate;
        private string favouritefood;
        private string favouriteband;
        private string favouritemovie;
        private string ilove;
        private string ihate;
        private string horoscopesign;
        private string superpower;
        private string motivationforprogramming;

        public GroupMember()
        {

        }
        public GroupMember(
            string name,
            int age,
            string birthDate,
            string favouriteFood,
            string favouriteBand,
            string favouriteMovie,
            string iLove,
            string iHate,
            string horoscopeSign,
            string superPower,
            string motivationForProgramming)
        {
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthDate;
            this.FavouriteFood = favouriteFood;
            this.FavouriteBand = favouriteBand;
            this.FavouriteMovie = favouriteMovie;
            this.ILove = iLove;
            this.IHate = iHate;
            this.HoroscopeSign = horoscopeSign;
            this.SuperPower = superPower;
            this.MotivationForProgramming = motivationForProgramming;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        public string FavouriteFood
        {
            get
            {
                return favouritefood;
            }
            set
            {
                favouritefood = value;
            }
        }
        public string FavouriteBand
        {
            get
            {
                return favouriteband;
            }
            set
            {
                favouriteband = value;
            }
        }
        public string FavouriteMovie
        {
            get
            {
                return favouritemovie;
            }
            set
            {
                favouritemovie = value;
            }
        }
        public string ILove
        {
            get
            {
                return ilove;
            }
            set
            {
                ilove = value;
            }
        }
        public string IHate
        {
            get
            {
                return ihate;
            }
            set
            {
                ihate = value;
            }
        }
        public string HoroscopeSign
        {
            get
            {
                return horoscopesign;
            }
            set
            {
                horoscopesign = value;
            }
        }
        public string SuperPower
        {
            get
            {
                return superpower;
            }
            set
            {
                superpower = value;
            }
        }
        public string MotivationForProgramming
        {
            get
            {
                return motivationforprogramming;
            }
            set
            {
                motivationforprogramming = value;
            }
        }
    }



}



class Program
{
    static List<GroupMember> listOfGroupMembers = new List<GroupMember>();


    static void Main(string[] args)
    {
        //1.Programmet skall vid uppstart fråga användaren om en kod. Om denna kod är == med namnet på er basgrupp skall tillgång till resten av programmet ges.
        //Annars skall ett passande meddelande skrivas ut.
        Console.WriteLine("Welcome to the information hub for Group #2");
        Password();


    }

    static void Password()
    {
        Console.Write("Please enter the name of the group you are trying to reach:");
        string password = Console.ReadLine().Trim().ToLower();
        bool passCheck = true;

        while (password != "götebuggarna")
        {
            Console.Write("Incorrect password, try again:");
            password = Console.ReadLine();
        }
        Console.WriteLine("");
        Console.WriteLine("Correct password, welcome in!");
        passCheck = false;
        Meny();
    }

    static void Meny()
    {
        CreateGroupMember();
        bool running = true;
        while (running)
        {
            //2.Användaren skall få olika val presenterat i form av en meny.
            //a.Lista alla deltagare i gruppen separerat med ,
            //b.Få ut 10 generella detaljer om varje medlem.Tex favoritmat eller band.
            //i.Varje deltagare skall ha en unik sträng som beskriver personens största driv till programmering.
            //c.Möjligheten att ta bort en person.
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?  The following options are available");
            Console.WriteLine("1. List group members.");
            Console.WriteLine("2. Print out short bio about each member.");
            Console.WriteLine("3. Print out personal motivation for programming for each group member.");
            Console.WriteLine("4. Delete a person from the list.");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PrintListOfGroupMembers();
                    break;
                case 2:
                    PrintInfoEachGroupMembers();
                    break;
                case 3:
                    PrintPersonalMotivation();
                    break;
                case 4:
                    DeleteGroupMember();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }



        }
    }

    static void PrintListOfGroupMembers()
    {
        Console.WriteLine(string.Join(",", listOfGroupMembers));

    }
    static void PrintInfoEachGroupMembers()
    {
        int counter = 1;
        foreach (GroupMember person in listOfGroupMembers)
        {
            Console.WriteLine($"{counter}.{person.Name}, {person.Age}, {person.BirthDate}, {person.HoroscopeSign}, { person.FavouriteFood}, {person.FavouriteBand}, {person.FavouriteMovie}, {person.ILove}, {person.IHate}, {person.SuperPower}");
            counter++;
        }

    }
    static void PrintPersonalMotivation()
    {
        int counter = 1;
        foreach (GroupMember person in listOfGroupMembers)
        {
            Console.WriteLine($"{counter}.{person.Name} has the following motivation for learning programming --> {person.MotivationForProgramming}");
            counter++;
        }
    }
    static void DeleteGroupMember()
    {
        Console.WriteLine("");
        Console.WriteLine("Which group member would you like to remove?");

        string choice;
        foreach (GroupMember person in listOfGroupMembers)
        {
            Console.Write($"{person.Name}, ");
        }
        choice = Console.ReadLine();

        for (int i = 0; i < listOfGroupMembers.Count; i++)
        {
            if (choice == listOfGroupMembers[i].Name)
            {
                Console.WriteLine($"{choice} will be removed from the group memeber list");
                listOfGroupMembers.RemoveAt(i);
            }
        }
        Console.WriteLine("Uppdated list og group members is:");
        Console.WriteLine(string.Join(",", listOfGroupMembers));

    }

    static void CreateGroupMember()
    {
        //Creating obejcts instances of class GroupMember

        GroupMember Andrei = new GroupMember();
        Andrei.Name = "Andrei";
        Andrei.Age = 25;
        Andrei.BirthDate = "22 January";
        Andrei.HoroscopeSign = "Capricorn";
        Andrei.FavouriteFood = "Carbonara";
        Andrei.FavouriteBand = "Two Steps from Hell";
        Andrei.FavouriteMovie = "The Lord of The Rngs";
        Andrei.ILove = "Travel";
        Andrei.IHate = "Olives";
        Andrei.SuperPower = "Instant olive detection";
        Andrei.MotivationForProgramming = "Problem solving";
        listOfGroupMembers.Add(Andrei);


        GroupMember Jesper = new GroupMember();
        Jesper.Name = "Jesper";
        Jesper.Age = 28;
        Jesper.BirthDate = "29 May";
        Jesper.HoroscopeSign = "Gemini";
        Jesper.FavouriteFood = "Lamm racks";
        Jesper.FavouriteBand = "Lars Winnebäck";
        Jesper.FavouriteMovie = "Catch me if you can";
        Jesper.ILove = "Simple things";
        Jesper.IHate = "People filning during concerts";
        Jesper.SuperPower = "Teleportation";
        Jesper.MotivationForProgramming = "Freedom";
        listOfGroupMembers.Add(Jesper);

        GroupMember Leroy = new GroupMember();
        Leroy.Name = "Leroy";
        Leroy.Age = 32;
        Leroy.BirthDate = "22 October";
        Leroy.HoroscopeSign = "Libra";
        Leroy.FavouriteFood = "Pizza";
        Leroy.FavouriteBand = "We the Best Music";
        Leroy.FavouriteMovie = "Matrix";
        Leroy.ILove = "Chocolate";
        Leroy.IHate = "Caviar";
        Leroy.SuperPower = "Flying";
        Leroy.MotivationForProgramming = "Dynamic";
        //Console.WriteLine($"{Leroy.Name}, {Leroy.Age}, {Leroy.BirthDate}, {Leroy.HoroscopeSign}, {Leroy.FavouriteFood}, {Leroy.FavouriteBand}, {Leroy.FavouriteMovie}, {Leroy.ILove}, {Leroy.IHate}, {Leroy.SuperPower}, {Leroy.MotivationForProgramming}");
        listOfGroupMembers.Add(Leroy);

        GroupMember MA = new GroupMember();
        MA.Name = "MA.Lin";
        MA.Age = 29;
        MA.BirthDate = "13 March";
        MA.HoroscopeSign = "Pisces";
        MA.FavouriteFood = "Platters";
        MA.FavouriteBand = "Modest Mouse";
        MA.FavouriteMovie = "Snatch";
        MA.ILove = "Autumn/Winter";
        MA.IHate = "Banana";
        MA.SuperPower = "Mrs. Hindsight";
        MA.MotivationForProgramming = "Creative process";
        // Console.WriteLine($"{MA.Name}, {MA.Age}, {MA.BirthDate}, {MA.HoroscopeSign}, {MA.FavouriteFood}, {MA.FavouriteBand}, {MA.FavouriteMovie}, {MA.ILove}, {MA.IHate}, {MA.SuperPower}, {MA.MotivationForProgramming}");
        listOfGroupMembers.Add(MA);

        GroupMember Gurra = new GroupMember();
        Gurra.Name = "Gustaf";
        Gurra.Age = 33;
        Gurra.BirthDate = "17 November";
        Gurra.HoroscopeSign = "Scorpio";
        Gurra.FavouriteFood = "Tacos";
        Gurra.FavouriteBand = "Berliner Phillarmoniker";
        Gurra.FavouriteMovie = "Any Star Wars:-)";
        Gurra.ILove = "J.S. Bach";
        Gurra.IHate = "Schlager";
        Gurra.SuperPower = "Puppy whisperer";
        Gurra.MotivationForProgramming = "Creativity";
        //Console.WriteLine($"{Gurra.Name}, {Gurra.Age}, {Gurra.BirthDate}, {Gurra.HoroscopeSign}, {Gurra.FavouriteFood}, {Gurra.FavouriteBand}, {Gurra.FavouriteMovie}, {Gurra.ILove}, {Gurra.IHate}, {Gurra.SuperPower}, {Gurra.MotivationForProgramming}");
        listOfGroupMembers.Add(Gurra);

        GroupMember JonnaWiberg = new GroupMember();
        JonnaWiberg.Name = "Jonna Wiberg";
        JonnaWiberg.Age = 30;
        JonnaWiberg.BirthDate = "5 February";
        JonnaWiberg.HoroscopeSign = "Aquarius";
        JonnaWiberg.FavouriteFood = "Pizza";
        JonnaWiberg.FavouriteBand = "Full of Hell";
        JonnaWiberg.FavouriteMovie = "Interstellar";
        JonnaWiberg.ILove = "Music";
        JonnaWiberg.IHate = "Meet";
        JonnaWiberg.SuperPower = "Eternal life";
        JonnaWiberg.MotivationForProgramming = "Stubborness";
        //Console.WriteLine($"{JonnaWiberg.Name}, {JonnaWiberg.Age}, {JonnaWiberg.BirthDate}, {JonnaWiberg.HoroscopeSign}, {JonnaWiberg.FavouriteFood}, {JonnaWiberg.FavouriteBand}, {JonnaWiberg.FavouriteMovie}, {JonnaWiberg.ILove}, {JonnaWiberg.IHate}, {JonnaWiberg.SuperPower}, {JonnaWiberg.MotivationForProgramming}");
        listOfGroupMembers.Add(JonnaWiberg);

        GroupMember Linus = new GroupMember();
        Linus.Name = "Linus";
        Linus.Age = 27;
        Linus.BirthDate = "17 July";
        Linus.HoroscopeSign = "Cancer";
        Linus.FavouriteFood = "Fich Soup";
        Linus.FavouriteBand = "Jack Moy";
        Linus.FavouriteMovie = "The Secret Life Of Walter Mitty";
        Linus.ILove = "Banana";
        Linus.IHate = "Mustard";
        Linus.SuperPower = "Breathing under water";
        Linus.MotivationForProgramming = "To get a fun job";
        //Console.WriteLine($"{Linus.Name}, {Linus.Age}, {Linus.BirthDate}, {Linus.HoroscopeSign}, {Linus.FavouriteFood}, {Linus.FavouriteBand}, {Linus.FavouriteMovie}, {Linus.ILove}, {Linus.IHate}, {Linus.SuperPower}, {Linus.MotivationForProgramming}");
        listOfGroupMembers.Add(Linus);

        GroupMember Nils = new GroupMember();
        Nils.Name = "Nils";
        Nils.Age = 21;
        Nils.BirthDate = "15 March";
        Nils.HoroscopeSign = "Pisces";
        Nils.FavouriteFood = "Pancakes";
        Nils.FavouriteBand = "Beach Boys";
        Nils.FavouriteMovie = "American Psycho";
        Nils.ILove = "Snow";
        Nils.IHate = "Slush";
        Nils.SuperPower = "Count with fingers";
        Nils.MotivationForProgramming = "Fun";
        //Console.WriteLine($"{Nils.Name}, {Nils.Age}, {Nils.BirthDate}, {Nils.HoroscopeSign}, {Nils.FavouriteFood}, {Nils.FavouriteBand}, {Nils.FavouriteMovie}, {Nils.ILove}, {Nils.IHate}, {Nils.SuperPower}, {Nils.MotivationForProgramming}");
        listOfGroupMembers.Add(Nils);

        GroupMember Yulrok = new GroupMember();
        Yulrok.Name = "Yulia";
        Yulrok.Age = 38;
        Yulrok.BirthDate = "23 April";
        Yulrok.HoroscopeSign = "Taurus";
        Yulrok.FavouriteFood = "Musli";
        Yulrok.FavouriteBand = "Morcheeba";
        Yulrok.FavouriteMovie = "The Green Book";
        Yulrok.ILove = "Chees";
        Yulrok.IHate = "Wastefullness";
        Yulrok.SuperPower = "Thought transfer";
        Yulrok.MotivationForProgramming = "Ticket to digital nomad life";
        //Console.WriteLine($"{Yulrok.Name}, {Yulrok.Age}, {Yulrok.BirthDate}, {Yulrok.HoroscopeSign}, {Yulrok.FavouriteFood}, {Yulrok.FavouriteBand}, {Yulrok.FavouriteMovie}, {Yulrok.ILove}, {Yulrok.IHate}, {Yulrok.SuperPower}, {Yulrok.MotivationForProgramming}");
        listOfGroupMembers.Add(Yulrok);
    }
}


