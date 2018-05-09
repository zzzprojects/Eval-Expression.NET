---
layout: default
title: LINQ Dynamic - OfType
description: C# Dynamic LINQ OfType examples using an Expression Evaluator.
permalink: linq-dynamic-oftype-examples
---

{% include template-h1.html %}

## LINQ Dynamic OfType Examples
{{ page.description }}

- [OfType](#oftype)

## OfType
This C# example uses the LINQ OfType method with a dynamic expression to return only the elements of the array that are of type double.

### LINQ
{% highlight csharp %}
private void uiOfType_LINQ_Click(object sender, EventArgs e)
{
	object[] numbers = {null, 1.0, "two", 3, "four", 5, "six", 7.0};

	var doubles = numbers.OfType<double>();

	var sb = new StringBuilder();

	sb.AppendLine("Numbers stored as doubles:");
		foreach (var d in doubles)
		{
			sb.AppendLine(d.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiOfType_LINQ_Execute_Click(object sender, EventArgs e)
{
	object[] numbers = {null, 1.0, "two", 3, "four", 5, "six", 7.0};

	var doubles = numbers.Execute<IEnumerable<double>>("OfType<double>()");

	var sb = new StringBuilder();

	sb.AppendLine("Numbers stored as doubles:");
		foreach (var d in doubles)
		{
			sb.AppendLine(d.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Numbers stored as doubles:
1
7

{% endhighlight %}
