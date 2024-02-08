using System.ComponentModel.DataAnnotations;

namespace TesteFi.Model
{
    public class Pessoa
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string Celular { get; set; }


    }
}
