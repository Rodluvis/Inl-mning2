using Inlämning2;
using System;

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
        public GroupMember
            (string name,
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
    static void Main(string[] args)
    {
        //1. First member
        GroupMember Andrei = new GroupMember();
        Andrei.Name = "Andrei";
        Andrei.Age = 25;
        Andrei.BirthDate = "22 January";
        Andrei.FavouriteFood = "Carbonara";
        Andrei.FavouriteBand = "Two Steps from Hell";
        Andrei.FavouriteMovie = "The Lord of The Rngs";
        Andrei.ILove = "Travel";
        Andrei.IHate = "Olives";
        Andrei.HoroscopeSign = "Capricorn";
        Andrei.SuperPower = "Instant olive detection";
        Andrei.MotivationForProgramming = "Problem solving";
        Console.WriteLine($"{Andrei.Name},{Andrei.Age}, {Andrei.BirthDate},{ Andrei.FavouriteFood},{Andrei.FavouriteBand},{ Andrei.FavouriteMovie},{ Andrei.ILove},{ Andrei.IHate}, { Andrei.HoroscopeSign}, { Andrei.SuperPower},{ Andrei.MotivationForProgramming}");
    }
}
}
