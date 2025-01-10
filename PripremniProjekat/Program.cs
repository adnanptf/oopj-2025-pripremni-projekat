

using Microsoft.Extensions.DependencyInjection;
using PripremniProjekat.Data;
using PripremniProjekat.Repositories;
using PripremniProjekat.Services;

var serviceProvider = new ServiceCollection().
    AddDbContext<MojContext>().
    AddScoped<IBookRepository,BookRepository>().
    AddScoped<IBookService,BookService>()

    .BuildServiceProvider(); 


var bookService = serviceProvider.GetService<IBookService>();


while(true)
{
    Console.WriteLine("Unesite 1 za dodavanje");
    Console.WriteLine("Unesite 2 za prikaz svih knjiga");

    var izbor = Console.ReadLine();

    switch(izbor)
    {
        case "1":
            Console.WriteLine("Unesi ime knjige ");
            var naslov = Console.ReadLine();
            Console.WriteLine("Unesi autora");
            var autor = Console.ReadLine();
            Console.WriteLine("Unesi opis");
            var opis = Console.ReadLine();
            bookService.AddBook(naslov, opis, autor);
            break;

        case "2":
            var knjige = bookService.GetAllBooks();
            foreach(var k in  knjige)
            {
                Console.WriteLine($"{k.Name} {k.Author}");
            }

            break;

    }
}