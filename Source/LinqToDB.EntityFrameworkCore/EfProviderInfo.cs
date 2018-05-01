﻿using System.Data.Common;

using Microsoft.EntityFrameworkCore;

namespace LinqToDB.EntityFrameworkCore
{
	/// <summary>
	/// Required integration information about underlying database provider, extracted from EF.Core.
	/// </summary>
	public class EFProviderInfo
	{
		/// <summary>
		/// Gets or sets database connection instance.
		/// </summary>
		public DbConnection Connection { get; set; }

		/// <summary>
		/// Gets or sets EF.Core context instance.
		/// </summary>
		public DbContext Context { get; set; }

		/// <summary>
		/// Gets or sets EF.Core context options instance.
		/// </summary>
		public DbContextOptions Options { get; set; }
	}
}
