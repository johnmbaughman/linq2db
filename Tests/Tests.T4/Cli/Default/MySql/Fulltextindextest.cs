// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.MySql
{
	[Table("fulltextindextest")]
	public class Fulltextindextest
	{
		[Column("id"        , IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public uint    Id         { get; set; } // int unsigned
		[Column("TestField1"                                                                                  )] public string? TestField1 { get; set; } // text
		[Column("TestField2"                                                                                  )] public string? TestField2 { get; set; } // text
	}
}