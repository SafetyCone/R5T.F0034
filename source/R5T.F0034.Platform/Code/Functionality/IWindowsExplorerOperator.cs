using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.F0034.Platform
{
    [FunctionalityMarker]
    public partial interface IWindowsExplorerOperator : IFunctionalityMarker
    {
        /// <summary>
		/// Quality-of-life overload for <see cref="OpenDirectoryInExplorer(string)"/>.
		/// </summary>
		public void Open(string directoryPath)
        {
            this.OpenDirectoryInExplorer(directoryPath);
        }

        /// <summary>
        /// Will open the directory in Windows explorer.
        /// A new window is only created if the directory is not already open. If the directory is already open, then it's Explorer window is focused (but only if this command opened the window, strangely).
        /// Strangley, this only works when this command opened the window. If the window was opened "naturally" (not by this command), then a new window will still be created.
        /// </summary>
        /// <param name="directoryPath"></param>
        public void OpenDirectoryInExplorer(string directoryPath)
        {
            /// <remarks>
            /// * Use the /c character to tell cmd.exe that this text is a command.
            /// * Use the start command (which is a command, not an executable), instead of explorer.exe.
            /// * Use quotes around the directory path to make sure it is treated as a single token when the directory path has a directory name with spaces.
            /// * Use the first blank quotes to make the start command ok with the directory path being quoted.
            /// * Use the /B command to avoid creating a new window, bringing focus to the Explorer windown where the directory is already open.
            /// (Strangley, this only works when this command opened the window. If the window was opened "naturally" (not by this command), then a new window will still be created.)
            /// </remarks>
            var arguments = $"/c start /B \"\" \"{directoryPath}\"";

            Instances.CommandLineOperator.Run_Synchronous(
                Instances.ExecutableNames.Cmd,
                arguments);
        }

        public void OpenDirectoriesInExplorer(IEnumerable<string> directoryPaths)
        {
            foreach (var directoryPath in directoryPaths)
            {
                this.OpenDirectoryInExplorer(directoryPath);
            }
        }

        public void OpenDirectoriesInExplorer(params string[] directoryPaths)
        {
            this.OpenDirectoriesInExplorer(directoryPaths.AsEnumerable());
        }
    }
}
