using DevFreela.Application.ViewModels;
using System.Collections.Generic;

namespace DevFreela.Application.Services.Interfaces
{
    public interface ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectServices(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        List<SkillViewModel> GetAll();
    }
}
