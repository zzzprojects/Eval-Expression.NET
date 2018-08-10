# LINQ Dynamic - ToDictionary

## LINQ Dynamic ToDictionary Examples
C# Dynamic LINQ ToDictionary examples using an Expression Evaluator.

- [ToDictionary](#todictionary)

## ToDictionary
This C# example uses the LINQ ToDictionary method with a dynamic expression to immediately evaluate a sequence and a related key expression into a dictionary.

### LINQ
```csharp
private void uiToDictionary_LINQ_Click(object sender, EventArgs e)
{
	var scoreRecords = new[]
		{
			new {Name = "Alice", Score = 50},
			new {Name = "Bob", Score = 40},
			new {Name = "Cathy", Score = 45}
		};

	var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

	var sb = new StringBuilder();

	sb.AppendLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiToDictionary_LINQ_Execute_Click(object sender, EventArgs e)
{
	var scoreRecords = new[]
		{
			new {Name = "Alice", Score = 50},
			new {Name = "Bob", Score = 40},
			new {Name = "Cathy", Score = 45}
		};

	dynamic scoreRecordsDict = scoreRecords.Execute("ToDictionary(sr => sr.Name)");

	var sb = new StringBuilder();

	sb.AppendLine("Bob's score: {0}", (object)scoreRecordsDict["Bob"]);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Bob's score: { Name = Bob, Score = 40 }

```
