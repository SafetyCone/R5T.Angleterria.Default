using System;

using R5T.T0064;


namespace R5T.Angleterria.Default
{
    [ServiceImplementationMarker]
    public class DefaultVisualStudioStringlyTypedPathPartsOperator : IVisualStudioStringlyTypedPathPartsOperator, IServiceImplementation
    {
        /// <summary>
        /// The default project directory name is the same as the project name.
        /// </summary>
        public string GetProjectDirectoryNameForProjectName(string projectName)
        {
            var projectDirectoryName = projectName;
            return projectName;
        }
    }
}
