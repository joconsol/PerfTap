namespace PerfTap.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Collections.ObjectModel;

	public interface ICounterConfiguration
	{
		ReadOnlyCollection<string> DefinitionPaths { get; }

		TimeSpan SampleInterval { get; }
	}
}