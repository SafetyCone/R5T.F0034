using System;


namespace R5T.F0034.Platform
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
