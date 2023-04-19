using System;
using Mono.Addins;

[assembly: Addin(Id = "SuperClean", Namespace = "CodingWithCalvin", Version = "2023.04.19.1")]
[assembly: AddinName("Super Clean")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("A Visual Studio for Mac (2022+) extension that adds a menu command to Build menu, that triggers a recursive delete (i.e., clean, but super) on all projects in the solution.")]
[assembly: AddinAuthor("Coding with Calvin")]