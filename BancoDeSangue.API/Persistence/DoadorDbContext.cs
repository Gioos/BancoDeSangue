using BancoDeSangue.API.Entities;

namespace BancoDeSangue.API.Persistence
{
    public class DoadorDbContext
    {
        public List<Doador> Doadores { get; set; }

        public DoadorDbContext() 
        {
            Doadores = new List<Doador>();
        }
    }
}
