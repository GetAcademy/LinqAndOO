using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndOO
{
    class Program
    {
        /*
         * Enums
         * Klasser og objekter - Vinlotterix
         * Linq
         * State machine - UML tilstandsdiagram
         * Ev. åpne data - data.norge.no
         * Må avslutte litt før, ca. 11:10
         */
        static void Main(string[] args)
        {
            var model = CreateSomeData();

            // filtrere liste - erValgt: true
            var list = model.personer.liste;
            var filteredList = FilterErValgt2(list);
        }

        private static string[] FilterErValgt(Person[] list)
        {
            var filteredList = new List<string>();
            foreach (var person in list)
            {
                if (person.id < 100 && person.erValgt)
                {
                    filteredList.Add($"{person.navn} ({person.id})");
                }
            }

            return filteredList.ToArray();
        }

        private static string[] FilterErValgt2(Person[] list)
        {
            return list
                .Where(p => p.id < 100 && p.erValgt)
                .Select(p => $"{p.navn} ({p.id})")
                .ToArray();

            /*
             * BuilderPattern
             * IEnumerable<>
             * Extension methods
             */
        }

        private static Model CreateSomeData()
        {
            return new Model
            {
                personer = new Personer
                {
                    velgAlle = false,
                    trekkAntall = 1,
                    liste = new[]
                    {
                        new Person {id = 100, navn = "Per", erValgt = true},
                        new Person {id = 101, navn = "Pål", erValgt = true},
                        new Person {id = 102, navn = "Espen", erValgt = false},
                        new Person {id = 103, navn = "Ole", erValgt = true},
                    }
                },
                trekninger = new[]
                {
                    new Trekning
                    {
                        vinnere = new string[] {"Ole"},
                        tid = "2018-10-17 17=10",
                        deltakere = new string[] {"Per", "Pål", "Ole"}
                    },
                    new Trekning
                    {
                        vinnere = new string[] {"Per", "Pål", "Knut"},
                        tid = "2018-10-11 17=10",
                        deltakere = new string[] {"Per", "Pål", "Ole", "Knut", "Gunnar"}
                    }
                }
            };
        }
    }
}
