using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Camp.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor informar a descrição do produto")]
        [Display(Name = "Nome do Produto")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Por favor informar a quantidade de produto")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
