using System.ComponentModel.DataAnnotations;
using ExpensiveControlApp.Models.Expensives;

namespace ExpensiveControlApp.DTOs
{
    public class EditExpensiveDTO
    {
        public EditExpensiveDTO()
        {
            Date = DateTime.Now;
            Item = new Expensive();
        }

        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório.")]
        [Range(0.01, 9999999999, ErrorMessage = "Valor deve ser maior que 0.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Data é obrigatória.")]
        public DateTime Date { get; set; }
        public Expensive Item { get; set; }
    }
}
