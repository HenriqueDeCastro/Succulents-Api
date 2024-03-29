using System.Collections.Generic;

namespace Suculentas.WebApi.Dtos
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}