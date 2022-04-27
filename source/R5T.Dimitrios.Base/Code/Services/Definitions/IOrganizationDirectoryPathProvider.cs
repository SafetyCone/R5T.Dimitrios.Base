using System;

using R5T.T0064;


namespace R5T.Dimitrios
{
    [ServiceDefinitionMarker]
    public interface IOrganizationDirectoryPathProvider : IServiceDefinition
    {
        string GetOrganizationDirectoryPath();
    }
}
