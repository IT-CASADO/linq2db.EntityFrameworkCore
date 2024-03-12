namespace LinqToDB.EntityFrameworkCore.SqlServer.Tests.Models.IssueModel
{
	public readonly record struct MyComplexType(string PropA) { }

	public sealed class Issue387Entity
	{
		public required int Id { get; set; }

		public required string Name { get; set; }

		public MyComplexType MyComplexType { get; set; } = new MyComplexType("CT-1");
	}
}
