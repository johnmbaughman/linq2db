// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using Microsoft.SqlServer.Types;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.SqlServer
{
	public class AllTypes2
	{
		public int             Id                     { get; set; } // int
		public DateTime?       DateDataType           { get; set; } // date
		public DateTimeOffset? DatetimeoffsetDataType { get; set; } // datetimeoffset(7)
		public DateTime?       Datetime2DataType      { get; set; } // datetime2(7)
		public TimeSpan?       TimeDataType           { get; set; } // time(7)
		public SqlHierarchyId? HierarchyidDataType    { get; set; } // hierarchyid
		public SqlGeography?   GeographyDataType      { get; set; } // geography
		public SqlGeometry?    GeometryDataType       { get; set; } // geometry
	}
}