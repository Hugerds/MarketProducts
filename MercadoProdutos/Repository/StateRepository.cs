using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;

namespace MercadoProdutos.Repository
{
    public class StateRepository : IStateRepository
    {
        protected readonly MercadoProdutosContext _dbContext;
        public StateRepository(MercadoProdutosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public State GetStateByAbbreviation(string StateAbbreviation)
        {
            var state = _dbContext.State.FirstOrDefault(s => s.Abbreviation == StateAbbreviation);
            if(state == null)
            {
                state = new State()
                {
                    Id = Guid.NewGuid(),
                    Abbreviation = StateAbbreviation,
                    Description = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Name = "",
                    Excluded = false,
                };
                _dbContext.State.Add(state);
                _dbContext.SaveChanges();
            }
            return state;
        }
    }
}
