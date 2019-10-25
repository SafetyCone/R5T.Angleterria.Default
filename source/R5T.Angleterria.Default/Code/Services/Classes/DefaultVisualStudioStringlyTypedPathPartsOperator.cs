using System;


namespace R5T.Angleterria.Default
{
    public class DefaultVisualStudioStringlyTypedPathPartsOperator : IVisualStudioStringlyTypedPathPartsOperator
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
