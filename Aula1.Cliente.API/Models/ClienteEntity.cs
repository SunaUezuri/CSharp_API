using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula1.Cliente.API.Models
{
    // Definindo que é uma tabela e dando um nome para a mesma
    [Table("TB_CS_CLIENTE")]
    public class ClienteEntity
    {
        // Anotação que define o campo como chave primária(PK)
        [Key]
        public int Id { get; set; }

        // Anotação que faz obrigatória a entrada de dados do campo(NotNull)
        [Required]
        // Define o tamanho da String
        [StringLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public int Idade { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}