using System;
using Mono.Addins;

[assembly: Addin(Id = "SuperClean", Namespace = "CodingWithCalvin", Version = "1.0")]
[assembly: AddinName("Super Clean")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("A Visual Studio (2022 and up) extension that adds a right-click context menu command to the Solution node, and Project node, that allows you to recursively delete (i.e., clean) the selected project's bin & obj folders, or all projects in the solution.")]
[assembly: AddinAuthor("Coding with Calvin")]