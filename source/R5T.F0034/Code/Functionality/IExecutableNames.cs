using System;

using R5T.T0132;


namespace R5T.F0034
{
	[FunctionalityMarker]
	public partial interface IExecutableNames : IFunctionalityMarker
	{
		public string Explorer => "explorer";
		public string Start => "start";
	}
}