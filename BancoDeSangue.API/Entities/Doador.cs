using BancoDeSangue.API.Entities.Enums;
namespace BancoDeSangue.API.Entities
{
    public class Doador
    {
        public Doador() 
        {
            Doacaos = new();
            Deletado = false;
            PodeDoar = false;
        }

        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Genero { get; set; }
        public double Peso { get; set; }
        public TiposSanguineo Tipo { get; set; }
        public FatorRh Fator {  get; set; }
        public List<Doacao> Doacaos { get; set; }
        public bool Deletado { get; set; }
        public bool PodeDoar { get; set; }
        public void Update(string email,double peso)
        {
            Email = email;
            Peso = peso;
        }

        public void Delete() 
        {
            Deletado = true;

        }



    }
}
