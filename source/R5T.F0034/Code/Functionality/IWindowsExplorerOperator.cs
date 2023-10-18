using System;

using R5T.T0132;
using R5T.T0180;


namespace R5T.F0034
{
    [FunctionalityMarker]
    public partial interface IWindowsExplorerOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IWindowsExplorerOperator _Platform => Platform.WindowsExplorerOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.IWindowsExplorerOperator.Open(string)"/>
        public void Open(IDirectoryPath directoryPath)
        {
            _Platform.Open(directoryPath.Value);
        }
    }
}
