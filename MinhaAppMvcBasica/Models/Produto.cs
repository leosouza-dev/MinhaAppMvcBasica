using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MinhaAppMvcBasica.Models
{
    public class Produto : Entity
    {
        //Chave estrangeira - FK  (este produto pertence à um fornecedor
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }
    }
}
