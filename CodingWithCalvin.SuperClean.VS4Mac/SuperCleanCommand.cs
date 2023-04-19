using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace CodingWithCalvin.SuperClean.VS4Mac
{
	public class SuperCleanCommand : CommandHandler
	{
        protected override void Run()
        {
            var projects = IdeApp.ProjectOperations.CurrentSelectedSolution.GetAllProjects();

            foreach (var project in projects)
            {
                CleanProject(project);
            }
        }

        private static void CleanProject(Project project)
        {
            var baseDirectory = project.BaseDirectory;
            var binDir = Path.Join(baseDirectory, "bin");
            var objDir = Path.Join(baseDirectory, "obj");

            if (Directory.Exists(binDir)) {
                Directory.Delete(binDir, true);
            }

            if (Directory.Exists(objDir))
            {
                Directory.Delete(objDir, true);
            }
        }
    }
}

