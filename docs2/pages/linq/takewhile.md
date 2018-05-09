---
layout: default
title: LINQ Dynamic - TakeWhile
description: C# Dynamic LINQ TakeWhile examples using an Expression Evaluator.
permalink: linq-dynamic-takewhile-examples
---



## LINQ Dynamic TakeWhile Examples
{{ page.description }}

- [TakeWhile - Simple](#takewhile---simple)
- [TakeWhile - Indexed](#takewhile---indexed)

## TakeWhile - Simple
This C# example uses the LINQ TakeWhile method with a dynamic expression to return elements starting from the beginning of the array until a number is hit that is not less than 6.

### LINQ
```csharp
private void uiTakeWhile_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

	var sb = new StringBuilder();

	sb.AppendLine("First numbers less than 6:");
		foreach (var n in firstNumbersLessThan6)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiTakeWhile_Simple_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var firstNumbersLessThan6 = numbers.TakeWhile(n => "n < 6");

	var sb = new StringBuilder();

	sb.AppendLine("First numbers less than 6:");
		foreach (var n in firstNumbersLessThan6)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiTakeWhile_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var firstNumbersLessThan6 = numbers.Execute<IEnumerable<int>>("TakeWhile(n => n < 6)");

	var sb = new StringBuilder();

	sb.AppendLine("First numbers less than 6:");
		foreach (var n in firstNumbersLessThan6)
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
First numbers less than 6:
5
4
1
3

```

## TakeWhile - Indexed
This C# example uses the LINQ Indexed TakeWhile method with a dynamic expression to return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

### LINQ
```csharp
private void uiTakeWhile_Indexed_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

	var sb = new StringBuilder();

	sb.AppendLine("First numbers not less than their position:");
		foreach (var n in firstSmallNumbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiTakeWhile_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var firstSmallNumbers = numbers.TakeWhile((n, index) => "n >= index");

	var sb = new StringBuilder();

	sb.AppendLine("First numbers not less than their position:");
		foreach (var n in firstSmallNumbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiTakeWhile_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var firstSmallNumbers = numbers.Execute<IEnumerable<int>>("TakeWhile((n, index) => n >= index)");

	var sb = new StringBuilder();

	sb.AppendLine("First numbers not less than their position:");
		foreach (var n in firstSmallNumbers)
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
First numbers not less than their position: 
5 
4

```
