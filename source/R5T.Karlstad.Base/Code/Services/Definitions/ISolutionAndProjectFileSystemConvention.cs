using System;


namespace R5T.Karlstad
{
    public interface ISolutionAndProjectFileSystemConvention
    {
        string GetSolutionDirectoryPathFromExecutableFileDirectoryPath(string executableFileDirectoryPath);
    }
}
