using Task_1;

Library_Service library_Service = new Library_Service();
List<Book> books = new List<Book>
{
    new Book
    {
        Title = "JHLJH",
        Authors = "jojupoj",
        Genre = "nasr"
    },
    new Book
    {
        Title = "JHLojsdfhH",
        Authors = "jojusldnfkjspoj",
        Genre = "nazm"
    },
    new Book
    {
        Title = "JHLJa[s]a[psaH",
        Authors = "LOLA",
        Genre = "nasr"
    },
    new Book
    {
        Title = "Jaaassas",
        Authors = "jsdadsaasojupoj",
        Genre = "nazm"
    }
};
library_Service.books = books;
var search_Result = library_Service.Search_Book_By_Author("LOLA");
foreach (var book in search_Result)
{
    Console.WriteLine(book);
}

var search_Result_1 = library_Service.Search_Book_By_Title("Jaaassas");
foreach (var book in search_Result_1)
{
    Console.WriteLine(book);
}
