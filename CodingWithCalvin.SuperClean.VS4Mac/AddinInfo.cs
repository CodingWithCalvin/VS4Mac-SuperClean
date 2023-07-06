using System;
using Mono.Addins;

[assembly: Addin(Id = "SuperClean", Namespace = "CodingWithCalvin", Version = "2023.07.07.1")]
[assembly: AddinName("Super Clean")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("A Visual Studio for Mac (2022+) extension that adds a menu command to Build menu, that triggers a recursive delete (i.e., clean, but super) on all projects in the solution, a right-click context menu option on the Project node, and a right-click context menu option on the Solution node.")]
[assembly: AddinAuthor("Coding with Calvin")]