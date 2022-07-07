using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreeProjectsExist_Executed_ReturnThreeProjectViewModels()
        {
            var projects = new List<Project>
            {
                new Project("Nome do Teste 1", "Descrição De Teste 1", 1, 2, 1000),
                new Project("Nome do Teste 2", "Descrição De Teste 2", 1, 2, 2000),
                new Project("Nome do Teste 3", "Descrição De Teste 1", 1, 2, 3000),
            };

            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetAllAsync().Result).Returns(projects);


            var getAllProjectQuey = new GetAllProjectsQuery("");
            //var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projects);

        }

    }
}
