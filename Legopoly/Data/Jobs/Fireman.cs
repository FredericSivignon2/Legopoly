using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
    public class Fireman : JobBase
    {
        public Fireman()
        {
            this.Name = "Pompier";
            this.grades = new Grade[]
            {
                new Grade("Auxiliaire", 0, 20, 0, 0, 10, 10),
                new Grade("Sapeur", 2, 28, 1, 1, 15, 14),
                new Grade("Sapeur 1ère classe", 3, 35, 1, 1, 18, 17),
                new Grade("Caporal", 4, 40, 2, 2, 22, 20),
                new Grade("Caporal Chef", 5, 45, 2, 2, 30, 24),
                new Grade("Sergent", 10, 50, 5, 3, 34, 35),
                new Grade("Sergent Chef", 14, 56, 10, 3, 34, 43),
                new Grade("Adjudant", 20, 60, 14, 4, 35, 52),
                new Grade("Adjudant Chef", 24, 60, 18, 4, 37, 60),
                new Grade("Lieutenant", 40, 64, 32, 6, 40, 110),
                new Grade("Capitaine", 48, 66, 40, 10, 40, 134),
                new Grade("Commandant", 60, 70, 50, 20, 42, 180),
                new Grade("Lieutenant Colonel", 70, 72, 64, 28, 44, 250),
                new Grade("Colonel", 80, 80, 80, 40, 50, 400)
            };
        }
    }
}
