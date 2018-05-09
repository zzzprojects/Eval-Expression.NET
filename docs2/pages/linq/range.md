---
layout: default
title: LINQ Dynamic - Range
description: C# Dynamic LINQ Range examples using an Expression Evaluator.
permalink: linq-dynamic-range-examples
---



## LINQ Dynamic Range Examples
{{ page.description }}

- [Range](#range)

## Range
This C# example uses the LINQ Range method with a dynamic expression to generate a sequence of numbers from 100 to 149 that is used to find which numbers in that range are odd and even.

### LINQ
```csharp
private void uiRange_LINQ_Click(object sender, EventArgs e)
{
	var numbers = Enumerable.Range(100, 50).Select(n => new {Number = n, OddEven = n % 2 == 1 ? "odd" : "even"});

	var sb = new StringBuilder();

		foreach (var n in numbers)
		{
			sb.AppendLine("The number {0} is {1}.", n.Number, n.OddEven);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiRange_LINQ_Execute_Click(object sender, EventArgs e)
{
	EvalManager.DefaultContext.RegisterType(typeof(Enumerable));
	dynamic numbers = Z.Expressions.Eval.Execute("Enumerable.Range(100, 50).Select(n => new { Number = n, OddEven = n % 2 == 1 ? 'odd' : 'even' })");

	var sb = new StringBuilder();

		foreach (var n in numbers)
		{
			sb.AppendLine("The number {0} is {1}.", (object) n.Number, (object) n.OddEven);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The number 100 is even.
The number 101 is odd.
The number 102 is even.
The number 103 is odd.
The number 104 is even.
The number 105 is odd.
The number 106 is even.
The number 107 is odd.
The number 108 is even.
The number 109 is odd.
The number 110 is even.
The number 111 is odd.
The number 112 is even.
The number 113 is odd.
The number 114 is even.
The number 115 is odd.
The number 116 is even.
The number 117 is odd.
The number 118 is even.
The number 119 is odd.
The number 120 is even.
The number 121 is odd.
The number 122 is even.
The number 123 is odd.
The number 124 is even.
The number 125 is odd.
The number 126 is even.
The number 127 is odd.
The number 128 is even.
The number 129 is odd.
The number 130 is even.
The number 131 is odd.
The number 132 is even.
The number 133 is odd.
The number 134 is even.
The number 135 is odd.
The number 136 is even.
The number 137 is odd.
The number 138 is even.
The number 139 is odd.
The number 140 is even.
The number 141 is odd.
The number 142 is even.
The number 143 is odd.
The number 144 is even.
The number 145 is odd.
The number 146 is even.
The number 147 is odd.
The number 148 is even.
The number 149 is odd.

```
