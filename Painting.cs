using System;

namespace C_OOP_Assignment
{
    //Polymorphism
    class ArtWork
    {
        class Painting
        {
            public virtual void greet()
            {
                Console.WriteLine("=============**~** WELCOME TO MY ARTWORK COLLECTION **~** =================");
            }
            //Inheritance 
            class Collection : Painting
            {
                public int collectionYear = 2020;
            }


            //Encapsulation
            private string Name;
            private string Artist;
            private string Medium;
            private int Year;

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

            public int PaintingYear
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
            //Abstraction ( this information will not be displayed to public)
            abstract class PaintingPrice
            {
                public void myPaintingPrice()
                {
                    Console.WriteLine("I bought this Painting for $500 in an Auction at West Edmonton mall");
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    Painting newPainting = new Painting();
                    Collection myCollection = new Collection();
                    // PaintingPrice PaintingPrice= new PaintingPrice();
                    newPainting.PaintingName = "The Last Supper";
                    newPainting.PaintingArtist = "Leonardo da Vinci";
                    newPainting.PaintingMedium = "Mural painting";
                    newPainting.PaintingYear = 1495;
                    myCollection.collectionYear = 2020;

                    newPainting.greet();
                    Console.WriteLine("Name: " + newPainting.PaintingName);
                    Console.WriteLine("Artist: " + newPainting.PaintingArtist);
                    Console.WriteLine("Medium: " + newPainting.PaintingMedium);
                    Console.WriteLine("Year Created: " + newPainting.PaintingYear);
                    Console.WriteLine("Collection Year: " + myCollection.collectionYear);

                }
            }
        }
    }
}
