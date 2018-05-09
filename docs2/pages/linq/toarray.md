---
layout: default
title: LINQ Dynamic - ToArray
description: C# Dynamic LINQ ToArray examples using an Expression Evaluator.
permalink: linq-dynamic-toarray-examples
---



## LINQ Dynamic ToArray Examples
{{ page.description }}

- [ToArray](#toarray)

## ToArray
This C# example uses the LINQ ToArray method with a dynamic expression to immediately evaluate a sequence into an array.

### LINQ
```csharp
private void uiToArray_LINQ_Click(object sender, EventArgs e)
{
	double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

	var sortedDoubles = from d in doubles orderby d descending select d;

	var doublesArray = sortedDoubles.ToArray();

	var sb = new StringBuilder();

	sb.AppendLine("Every other double from highest to lowest:");
		for (var d = 0; d < doublesArray.Length; d += 2)
		{
			sb.AppendLine(doublesArray[d].ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiToArray_LINQ_Execute_Click(object sender, EventArgs e)
{
	double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

	var sortedDoubles = from d in doubles orderby d descending select d;

	var doublesArray = sortedDoubles.Execute<double[]>("ToArray()");

	var sb = new StringBuilder();

	sb.AppendLine("Every other double from highest to lowest:");
		for (var d = 0; d < doublesArray.Length; d += 2)
		{
			sb.AppendLine(doublesArray[d].ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Every other double from highest to lowest:
4.1
2.3
1.7

```
