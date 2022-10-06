using System;

using R5T.T0132;


namespace R5T.F0034.Construction
{
	[FunctionalityMarker]
	public partial interface ITry : IFunctionalityMarker
	{
		public void OpenDirectoryInWindowsExplorer()
        {
			var directoryPath = @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Packages";

			WindowsExplorerOperator.Instance.OpenDirectoryInExplorer(directoryPath);
        }
	}
}