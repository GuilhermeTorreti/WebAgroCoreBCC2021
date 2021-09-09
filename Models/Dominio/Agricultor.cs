using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAgroCoreBCC2021.Models.Dominio
{
    [Table("Agricultores")]
    public class Agricultor
    {
        [Key]   //metadados
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }


        [StringLength(50, ErrorMessage = "Tamanho de Nome Proprietário Inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome do Proprietário")]
        public string proprietario { get; set; }


        [Range(minimum: 18, maximum: 100, ErrorMessage = "Idade Entre 18 e 100 Anos")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Idade")]
        public int idade { get; set; }


        [StringLength(11)]
        public string cpf { get; set; }


        [StringLength(40, ErrorMessage = "Tamanho de Nome do Bairro Inválido", MinimumLength = 1)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }


        [StringLength(40, ErrorMessage = "Tamanho de Nome do Município Inválido", MinimumLength = 1)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Município")]
        public string municipio { get; set; }


        [Display(Name = "E-Mail")]
        [StringLength(35, ErrorMessage = "E-Mail Maior que 35 Caracteres")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "E-Mail Inválido")]
        [RegularExpression("^[a-zA-Z0-9_+-] +[a-zA-Z0-9._+-]*[a-zA-Z0-9_+-] +@[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[.]{1,1}[a-zA-Z]{2,}$", ErrorMessage = "E-Mail Inválido")]
        public string email { get; set; }


        public ICollection<Area> areas { get; set; }
    }
}
