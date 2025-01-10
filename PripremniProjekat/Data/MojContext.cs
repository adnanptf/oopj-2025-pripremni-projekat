using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PripremniProjekat.Models;

namespace PripremniProjekat.Data
{
    public class MojContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            /*Problem koji je bio na 
             * predavanjima je bio u tome sto se 
             * baza koju smo kreirali naredbama za 
             * migraciju kreirala u root folderu aplikacije, a kada se pokrene app
             * tj. dotnet run se pokrene to bude u bin/debug folderu i to predstavlja onda problem
             * ZBOG TOGA ovdje uvodimo da se putanja za bazu na mjestu pokretanja aplikacije imat cemo istu lokaciju.
             * Sada se pokrenu migracije normalno kada se nalazimo u root folderu i migracije ce
             * se uraditi u bazu koja se nalazi u folderu u kojem bude pokrenuta aplikacija.
             * Dakle, 1. dodamo migraciju:  dotnet ef migrations add prva ([rovjeriti da li se u folderu migrations kreirala migracija)
             * , 2. update baze: dotnet ef database update 
             * 3. pokrenuti aplikaciju
             Kad kazem root folder, to je folder u kojem se nalazi .csproj file!
             */
            var databasePath = Path.Combine(AppContext.BaseDirectory, "MojaBaza.db");
            options.UseSqlite($"Data Source={databasePath}");
        }
       
    }
}
