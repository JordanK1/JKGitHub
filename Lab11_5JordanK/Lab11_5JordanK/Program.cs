using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab11_5JordanK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating & Adding the films to sakila
            SakilaContext sakila = new SakilaContext();
            Film movie1917 = new Film("1917", "War Drama by Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
            Film joker = new Film("Joker", "Oscar-Nominated Supervillain Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
            Film starwarsIX = new Film("Star Wars: The Rise of Skywalker", "A Mediocre Disney Fan-Fic", "2019", 3, 4.99m, 202, 21.99m, "PG-13");

            /*sakila.Film.Add(movie1917);
            sakila.Film.Add(joker);
            sakila.Film.Add(starwarsIX);
            sakila.SaveChanges();*/

            
            Film[] allfilms = (from db in sakila.Film
                               select new Film(db.title, db.description, db.release_year, db.rental_duration, db.rental_rate, db.length, db.replacement_cost, db.rating)).ToArray();

            var newestfilms = allfilms.Where(x => x.release_year == "2019");

            StringBuilder html = new StringBuilder();
            html.Append("<html> \n");
            html.Append("<head> \n");
            html.Append("<title>Sakila Upcoming Releases</title> \n");
            html.Append("<body> \n");
            html.Append("<h1>UPCOMING RELEASES</h1> \n");
            html.Append("<ul> \n");

                foreach (var film in newestfilms)
            {
                html.Append("<li> \n");
                html.Append("<b>" + film.title + "</b>" + " : " + film.description);
                html.Append("</li> \n");
            }

            html.Append("</ul> \n");
            html.Append("</body> \n");
            html.Append("</html>");

            string htmlFile = "J:\\11_5lab.html";
            File.WriteAllText(htmlFile, html.ToString());

        }
    }
}
