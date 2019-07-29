# LINQ Dynamic - ThenBy

## LINQ Dynamic ThenBy Examples
C# Dynamic LINQ ThenBy examples using an Expression Evaluator.

- [ThenBy - Simple](#thenby---simple)
- [ThenBy - Comparer](#thenby---comparer)

## ThenBy - Simple
This C# example uses the LINQ ThenBy method with a dynamic expression to sort a list of digits, first by length of their names, and then alphabetically by the name itself.

### LINQ
```csharp
private void uiThenBy_Simple_1_LINQ_Click(object sender, EventArgs e)
{
	string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

	var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);

	var sb = new StringBuilder();

	sb.AppendLine("Sorted digits:");
		foreach (var d in sortedDigits)
		{
			sb.AppendLine(d);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiThenBy_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

	var sortedDigits = digits.OrderBy(d => d.Length).ThenByDynamic(d => "d");

	var sb = new StringBuilder();

	sb.AppendLine("Sorted digits:");
		foreach (var d in sortedDigits)
		{
			sb.AppendLine(d);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiThenBy_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

	var sortedDigits = digits.OrderBy(d => d.Length).Execute<IEnumerable<string>>("ThenBy(d => d)");

	var sb = new StringBuilder();

	sb.AppendLine("Sorted digits:");
		foreach (var d in sortedDigits)
		{
			sb.AppendLine(d);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Sorted digits:
one
six
two
five
four
nine
zero
eight
seven
three

```

## ThenBy - Comparer
This C# example uses the LINQ ThenBy method with a dynamic expression and a custom comparer to sort first by word length and then by a case-insensitive sort of the words in an array.

### LINQ
```csharp
private void uiThenBy_Comparer_LINQ_Click(object sender, EventArgs e)
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

	var sortedWords = words.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedWords);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiThenBy_Comparer_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

	var sortedWords = words.OrderBy(a => a.Length).ThenByDynamic(a => "a", new CaseInsensitiveComparer());

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedWords);

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiThenBy_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

	EvalManager.DefaultContext.RegisterType(typeof(CaseInsensitiveComparer));

	var sortedWords = words.OrderBy(a => a.Length).Execute<IEnumerable<string>>("ThenBy(a => a, new CaseInsensitiveComparer())");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedWords);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
aPPLE
AbAcUs
bRaNcH
cHeRry
ClOvEr
BlUeBeRrY

```
