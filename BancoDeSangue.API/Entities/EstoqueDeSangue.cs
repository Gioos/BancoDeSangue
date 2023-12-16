using BancoDeSangue.API.Entities.Enums;

namespace BancoDeSangue.API.Entities
{
    public class EstoqueDeSangue
    {
        public int Id { get; set; }
        public TiposSanguineo TipoSanguineo { get; set; }
        public FatorRh FatorRh { get; set; }
        public int QuantidadeML { get; set; }
    }
}
