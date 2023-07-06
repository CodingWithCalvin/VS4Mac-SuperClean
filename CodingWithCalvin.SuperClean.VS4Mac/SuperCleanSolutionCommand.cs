using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace CodingWithCalvin.SuperClean.VS4Mac
{
	public class SuperCleanSolutionCommand : CommandHandler
	{
        protected override void Run()
        {
            var projects = IdeApp.ProjectOperations.CurrentSelectedSolution.GetAllProjects();

            foreach (var project in projects)
            {
                project.CleanProject();
            }
        }
    }
}

