using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppMvcBasica.Models
{
    public class Produto : Entity
    {
        //Chave estrangeira - FK  (este produto pertence à um fornecedor
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }
    }
}
