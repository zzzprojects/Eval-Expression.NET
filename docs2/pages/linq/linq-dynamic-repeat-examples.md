# LINQ Dynamic - Repeat

## LINQ Dynamic Repeat Examples
{{ page.description }}

- [Repeat](#repeat)

## Repeat
This C# example uses the LINQ Repeat method with a dynamic expression to generate a sequence that contains the number 7 ten times.

### LINQ
```csharp
private void uiRepeat_LINQ_Click(object sender, EventArgs e)
{
	var numbers = Enumerable.Repeat(7, 10);

	var sb = new StringBuilder();

		foreach (var n in numbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiRepeat_LINQ_Execute_Click(object sender, EventArgs e)
{
	EvalManager.DefaultContext.RegisterType(typeof(Enumerable));
	var numbers = Z.Expressions.Eval.Execute<IEnumerable<int>>("Enumerable.Repeat(7, 10)");

	var sb = new StringBuilder();

		foreach (var n in numbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
7
7
7
7
7
7
7
7
7
7

```
