using System;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace CodingWithCalvin.SuperClean.VS4Mac
{
	public static class ProjectExtensions
	{
        public static void CleanProject(this Project project)
        {
            var activeConfig = IdeApp.Workspace.ActiveConfiguration;
            var projectConfig = (ProjectConfiguration)project.GetConfiguration(activeConfig);

            var binDir = projectConfig.OutputDirectory;
            var objDir = projectConfig.IntermediateOutputDirectory;

            if (Directory.Exists(binDir))
            {
                Directory.Delete(binDir, true);
            }

            if (Directory.Exists(objDir))
            {
                Directory.Delete(objDir, true);
            }
        }
    }
}

