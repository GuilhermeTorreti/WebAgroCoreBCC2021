using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAgroCoreBCC2021.Models.Dominio
{
    public enum TipoInsumo { Defensivo, Adubo, Semente, Herbicidas, Lubrificante, Combustivel }
    public class Insumo
    {
        public enum TipoInsumo { Adubo, Semente, Combustivel, Lubrificante, Herbicidas, Inseticida, Outros }

        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [Display(Name = "Tipo Insumo")]
        public TipoInsumo tipoinsumo { get; set; }


        [StringLength(50, ErrorMessage = "Descrição deve ter no máximo 50 caractéres")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }


        [Display(Name = "Quantidade")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public float quantidade { get; set; }


        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor { get; set; }

        //lista de areas onde o insumo é utilizado - memória
        public ICollection<InsumoArea> areasinsumo { get; set; }
    }
}
