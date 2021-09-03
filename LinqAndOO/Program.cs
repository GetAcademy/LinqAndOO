using System;

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
            var model = new Model
            {
                personer = {
                    velgAlle= false,
                    trekkAntall= 1,
                    liste= new Person[] {
                        new Person{ id= 100, navn= "Per", erValgt= true },
                        new Person{ id= 101, navn= "Pål", erValgt= true },
                        new Person{ id= 102, navn= "Espen", erValgt= false },
                        new Person{ id= 103, navn= "Ole", erValgt= true },
                    }
                },
                trekninger = new Trekning[] {
                    new Trekning{
                        vinnere = new string[]{"Ole"},
                        tid = "2018-10-17 17=10",
                        deltakere =new string[]{"Per", "Pål", "Ole"}
                    },
                    new Trekning{
                        vinnere =new string[]{"Per", "Pål", "Knut"},
                        tid = "2018-10-11 17=10",
                        deltakere =new string[]{"Per", "Pål", "Ole", "Knut", "Gunnar"}
                    }
                }
            };
        }
    }
}
