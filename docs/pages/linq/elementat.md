---
layout: default
title: LINQ Dynamic - ElementAt
description: C# Dynamic LINQ ElementAt examples using an Expression Evaluator.
permalink: linq-dynamic-elementat-examples
---

{% include template-h1.html %}

## LINQ Dynamic ElementAt Examples
{{ page.description }}

- [ElementAt](#elementat)
- [Where - Simple 2](#where---simple-2)
- [Where - Simple 3](#where---simple-3)
- [Where - Drilldown](#where---drilldown)
- [Where - Indexed](#where---indexed)

## ElementAt
This C# example uses the LINQ ElementAt method with a dynamic expression to retrieve the second number greater than 5 from an array.

### LINQ
{% highlight csharp %}
private void uiElementAt_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var fourthLowNum = numbers.Where(n => n > 5).ElementAt(1); // second number is index 1 because sequences use 0-based indexing 

	var sb = new StringBuilder();

	sb.AppendLine("Second number > 5: {0}", fourthLowNum);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiElementAt_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var fourthLowNum = numbers.Where(n => n > 5).Execute<int>("ElementAt(1)"); // second number is index 1 because sequences use 0-based indexing 

	var sb = new StringBuilder();

	sb.AppendLine("Second number > 5: {0}", fourthLowNum);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Second number > 5: 8

{% endhighlight %}
