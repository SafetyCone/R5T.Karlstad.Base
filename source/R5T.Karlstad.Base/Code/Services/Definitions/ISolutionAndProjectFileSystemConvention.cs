using System;using R5T.T0064;


namespace R5T.Karlstad
{[ServiceDefinitionMarker]
    public interface ISolutionAndProjectFileSystemConvention:IServiceDefinition
    {
        string GetSolutionDirectoryPathFromExecutableFileDirectoryPath(string executableFileDirectoryPath);
    }
}
