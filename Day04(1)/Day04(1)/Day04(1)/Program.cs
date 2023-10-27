// See https://aka.ms/new-console-template for more information

using Day04;

Console.WriteLine("Hello, World!");


Library c = new Library();

c.countProperty();


c.AddBook(new Book("wigni4", "giorgi4", 1950));
c.AddBook(new Book("wigni4", "giorgi5", 1950));
c.printBook();
Console.WriteLine("Wignebis raodenoba: " + c.countProperty());

Console.WriteLine("Wignebis raodenoba: " + c.countProperty());
//c.FindBook("wigni4");
//Console.WriteLine(c.FindBook);
Library b = new Library();
c.RemoveBookByTitle("wigni3");
c.FindBook("wigni4").ForEach(x => Console.WriteLine(x.Title));
c.printBook();
c.RemoveBookAll();
Console.WriteLine("Wignebis raodenoba: " + c.countProperty());
