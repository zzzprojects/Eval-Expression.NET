---
layout: default
title: LINQ Dynamic - Reverse
description: C# Dynamic LINQ Reverse examples using an Expression Evaluator.
permalink: linq-dynamic-reverse-examples
---



## LINQ Dynamic Reverse Examples
{{ page.description }}

- [Reverse](#reverse)

## Where - Simple 1
This C# example uses the LINQ Where method with a dynamic expression to find all elements of an array less than 5.

### LINQ
```csharp
private void uiReverse_Simple_1_LINQ_Click(object sender, EventArgs e)
{
	string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

	var reversedIDigits = digits.Where(d => d[1] == 'i').Reverse();

	var sb = new StringBuilder();

	sb.AppendLine("A backwards list of the digits with a second character of 'i':");
		foreach (var d in reversedIDigits)
		{
			sb.AppendLine(d);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiReverse_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

	var reversedIDigits = digits.Where(d => d[1] == 'i').Execute<IEnumerable<string>>("Reverse()");

	var sb = new StringBuilder();

	sb.AppendLine("A backwards list of the digits with a second character of 'i':");
		foreach (var d in reversedIDigits)
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
A backwards list of the digits with a second character of 'i':
nine
eight
six
five

```
