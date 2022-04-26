using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {

        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeto ASPNET Core 1", "Minha Descrição de Projeto 1", 1, 1, 1000),
                new Project("Meu Projeto ASPNET Core 1", "Minha Descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu Projeto ASPNET Core 1", "Minha Descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Lucas Viana", "lucas@gmail.com", new DateTime(1999, 1,10)),
                new User("Ronaldo Fenomeno", "lucas@gmail.com", new DateTime(2000, 1,10)),
                new User("Cesar Filho", "lucas@gmail.com", new DateTime(1988, 1,10)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
