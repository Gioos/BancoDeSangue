using BancoDeSangue.API.Entities.Enums;
namespace BancoDeSangue.API.Entities
{
    public class Doacao
    {
        public Doacao() { }

        public int Id { get; set; }
        public int DoadorID { get; set; }
        public DateTime DataDoacao { get; set; }
        public int QuantidadeML { get; set; }
        public Doador Doador { get; set; }


    }


}
