using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestIfProjectStartWorks()
        {
            //instaciar o projeto
            var project = new Project("Nome De Teste", "Descricao de Teste", 1, 2, 10000);

            Assert.Equal(ProjectStatusEnums.Created, project.Status);
            Assert.Null(project.StartedAt);

            Assert.NotNull(project.Title);
            Assert.NotEmpty(project.Title);

            Assert.NotNull(project.Description);
            Assert.NotEmpty(project.Description);

            project.Start();

            Assert.Equal(ProjectStatusEnums.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);
        }
    }
}
