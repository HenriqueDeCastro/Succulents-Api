using System.Collections.Generic;

namespace Suculentas.Domain
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public int TipoCategoriaId { get; set; }
        public TipoCategoria TipoCategoria { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}