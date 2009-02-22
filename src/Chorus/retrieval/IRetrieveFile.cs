﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chorus.retrieval
{
	public interface IRetrieveFile
	{
		/// <summary>
		/// Gets a version of a file  from a repository
		/// </summary>
		/// <returns>path to a temp file. caller is responsible for deleting the file.</returns>
		string RetrieveHistoricalVersionOfFile(string relativePath, string versionDescriptor);
	}
}
