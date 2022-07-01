using ExpensiveControlApp.Models.Expensives;

namespace ExpensiveControlApp.Services
{
    public interface IExpensiveService
    {
        Task Create(DTOs.CreateExpensiveDTO createExpensiveDTO);

        Task Edit(DTOs.EditExpensiveDTO editExpensiveDTO);
        
        Expensive ListarPorId(int id);

        Task<List<Expensive>> FindBy(DateTime starDate, DateTime endDate);

        Task<List<Expensive>> FindById(int id);
    }
}
