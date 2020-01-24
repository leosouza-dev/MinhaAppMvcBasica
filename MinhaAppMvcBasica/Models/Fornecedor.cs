using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MinhaAppMvcBasica.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        /* EF Relations */
        public Endereco Endereco { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
