using System;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedExcepetion : Exception
    {
        public ProjectAlreadyStartedExcepetion() :base("Project is already in Started status")
        {

        }
    }
}
