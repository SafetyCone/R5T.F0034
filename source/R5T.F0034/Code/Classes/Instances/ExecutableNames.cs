using System;


namespace R5T.F0034
{
	public class ExecutableNames : IExecutableNames
	{
		#region Infrastructure

	    public static IExecutableNames Instance { get; } = new ExecutableNames();

	    private ExecutableNames()
	    {
        }

	    #endregion
	}
}