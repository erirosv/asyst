using System.Collections.Generic;

namespace Lab2Version
{
    public class DataStore
    {
        internal List<Lärare> LärarLista = new List<Lärare>();
        internal List<Kurs> KursLista = new List<Kurs>();
        internal List<Student> StudentLista = new List<Student>();
        internal List<Uppgift> UppgiftsLista = new List<Uppgift>();
    }
}