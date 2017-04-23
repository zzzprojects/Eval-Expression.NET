---
layout: default
title: LINQ Dynamic - EqualAll
description: C# Dynamic LINQ EqualAll examples using an Expression Evaluator.
permalink: linq-dynamic-equalall-examples
---

{% include template-h1.html %}

## LINQ Dynamic EqualAll Examples
{{ page.description }}

- [EqualAll - 1](#equalall---1)
- [EqualAll - 2](#equalall---2)

## EqualAll - 1
This C# example uses the LINQ EqualAll method with a dynamic expression to see if two sequences match on all elements in the same order.

### LINQ
{% highlight csharp %}
private void uiEqualAll_1_LINQ_Click(object sender, EventArgs e)
{
	var wordsA = new[] {"cherry", "apple", "blueberry"};
	var wordsB = new[] {"cherry", "apple", "blueberry"};

	var match = wordsA.SequenceEqual(wordsB);

	var sb = new StringBuilder();

	sb.AppendLine("The sequences match: {0}", match);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiEqualAll_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	var wordsA = new[] {"cherry", "apple", "blueberry"};
	var wordsB = new[] {"cherry", "apple", "blueberry"};

	var match = wordsA.Execute<bool>("SequenceEqual(wordsB)", new {wordsB});

	var sb = new StringBuilder();

	sb.AppendLine("The sequences match: {0}", match);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The sequences match: True

{% endhighlight %}

## EqualAll - 2
This C# example uses the LINQ EqualAll method with a dynamic expression to see if two sequences match on all elements in the same order.

### LINQ
{% highlight csharp %}
private void uiEqualAll_2_LINQ_Click(object sender, EventArgs e)
{
	var wordsA = new[] {"cherry", "apple", "blueberry"};
	var wordsB = new[] {"apple", "blueberry", "cherry"};

	var match = wordsA.SequenceEqual(wordsB);

	var sb = new StringBuilder();

	sb.AppendLine("The sequences match: {0}", match);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiEqualAll_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var wordsA = new[] {"cherry", "apple", "blueberry"};
	var wordsB = new[] {"apple", "blueberry", "cherry"};

	var match = wordsA.Execute<bool>("SequenceEqual(wordsB)", new {wordsB});

	var sb = new StringBuilder();

	sb.AppendLine("The sequences match: {0}", match);

	 My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The sequences match: False

{% endhighlight %}
