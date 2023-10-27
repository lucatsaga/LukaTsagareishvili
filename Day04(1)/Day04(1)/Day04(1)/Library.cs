using Day04;



public class Library
{
    private List<Book> books = new List<Book>();

    public Library()
    {
        books.Add(new Book("wigni1", "giorgi1", 1942));
        books.Add(new Book("wigni2", "giorgi2", 1945));
        books.Add(new Book("wigni3", "giorgi3", 1948));

    }

    public void printBook()
    {
        int i = 1;
        foreach (Book book in books)
        {
            Console.WriteLine("Book #" + i + " - " + book.Title + " " + book.Author);
            Console.WriteLine();
            i++;


        }
    }


    public int countProperty()
    {

        return books.Count();
    }


    public void AddBook(Book book)
    {
        books.Add(book);

    }


    public List<Book> FindBook(string book)
    {

        return books.FindAll(i => i.Title == book);


    }


    public void RemoveBookAll()
    {
        books.Clear();
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void RemoveBookByTitle(string title)
    {
        this.books = books.FindAll(x => x.Title != title);
    }

}
