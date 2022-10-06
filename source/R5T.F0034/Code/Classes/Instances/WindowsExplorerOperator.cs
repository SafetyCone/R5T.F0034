using System;


namespace R5T.F0034
{
	public class WindowsExplorerOperator : IWindowsExplorerOperator
	{
		#region Infrastructure

	    public static IWindowsExplorerOperator Instance { get; } = new WindowsExplorerOperator();

	    private WindowsExplorerOperator()
	    {
        }

	    #endregion
	}
}