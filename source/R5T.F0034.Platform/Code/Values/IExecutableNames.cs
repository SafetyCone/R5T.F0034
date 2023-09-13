using System;

using R5T.T0131;


namespace R5T.F0034.Platform
{
    [ValuesMarker]
    public partial interface IExecutableNames : IValuesMarker
    {
        public string Explorer => "explorer";
        public string Start => "start";
    }
}
