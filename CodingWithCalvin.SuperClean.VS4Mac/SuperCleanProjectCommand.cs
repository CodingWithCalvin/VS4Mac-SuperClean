using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace CodingWithCalvin.SuperClean.VS4Mac
{
	public class SuperCleanProjectCommand : CommandHandler
	{
        protected override void Run()
        {
            var project = IdeApp.ProjectOperations.CurrentSelectedProject;
            project.CleanProject();
        }
    }
}

