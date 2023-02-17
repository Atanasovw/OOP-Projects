namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("animal farm",2003, "gosho sos");
            Book bookTwo = new Book("enimal farm", 2004, "goshi sos");
            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne,bookTwo);

        }
    }
}