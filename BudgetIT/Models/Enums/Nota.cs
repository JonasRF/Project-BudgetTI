using System.ComponentModel.DataAnnotations;

namespace BudgetIT.Models
{
    public enum Nota
    {
        [Display(Name = "EnviadoNfe")]
        EnviadoNfe,
        [Display(Name = "Cancelado")]
        Cancelado,
        [Display(Name = "Liquidado")]
        Liquidado
    }
}
