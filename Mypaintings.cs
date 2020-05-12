using System;

namespace C_OOP_Assignment
{
    //Inheritance 
    class Painting
    {
        public string groupName = "Painting";
        public void greet()
        {
            Console.WriteLine("Welcome to my Painiting Collection!");
        }
        class Collection:Painting
        {
            public string collectionYear= "2020";
        }
     
        //encapsulation
        private string Name;
        private string Artist;
        private string Medium;
        private string Year;
        public string PaintingName
        { //accessos
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string PaintingArtist
        { //accesor 
            get
            {
                return Artist;
            }
            set
            {
                Artist = value;

            }
        }
        public string PaintingMedium
        { //accesor 
            get
            {
                return Medium;
            }
            set
            {
                Medium = value;

            }
        }

        public string PaintingYear
        { //accesor 
            get
            {
                return Year;
            }
            set
            {
                Year = value;

            }
        }
        // 

        // }
        // class Painting : Group
        // {
        //     public string paintingName = "Life in West Edmonton Mall ";
        // }

        class Program
        {
            static void Main(string[] args)
            {
                Painting newPainting = new Painting();
                newPainting.PaintingName = "The Last Supper";
                newPainting.PaintingArtist = "Leonardo da Vinci";
                newPainting.PaintingMedium = "Mural painting";
                newPainting.PaintingYear = "1495-1498";

                Console.WriteLine("Name: " + newPainting.PaintingName);
                Console.WriteLine("Created by: " + newPainting.PaintingArtist);
                Console.WriteLine("Medium: " + newPainting.PaintingMedium);
                Console.WriteLine("Year: " + newPainting.PaintingYear);
            }
        }
    }
}
