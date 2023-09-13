using System;

using R5T.T0132;
using R5T.T0180;


namespace R5T.F0034
{
    [FunctionalityMarker]
    public partial interface IWindowsExplorerOperator : IFunctionalityMarker,
        Platform.IWindowsExplorerOperator
    {
        /// <inheritdoc cref="Platform.IWindowsExplorerOperator.Open(string)"/>
        public void Open(IDirectoryPath directoryPath)
        {
            this.Open(directoryPath.Value);
        }
    }
}
