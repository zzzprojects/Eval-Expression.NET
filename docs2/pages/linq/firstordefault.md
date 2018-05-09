---
layout: default
title: LINQ Dynamic - FirstOrDefault
description: C# Dynamic LINQ FirstOrDefault examples using an Expression Evaluator.
permalink: linq-dynamic-firstordefault-examples
---

{% include template-h1.html %}

## LINQ Dynamic FirstOrDefault Examples
{{ page.description }}

- [FirstOrDefault - Simple](#firstordefault---simple)
- [FirstOrDefault - Condition](#firstordefault---condition)

## FirstOrDefault - Simple
This C# example uses the LINQ FirstOrDefault method with a dynamic expression to try to find the first element of the sequence, unless there are no elements, in which case the default value for that type is returned.

### LINQ
{% highlight csharp %}
private void uiFirstOrDefault_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {};

	var firstNumOrDefault = numbers.FirstOrDefault();

	var sb = new StringBuilder();

	sb.AppendLine(firstNumOrDefault.ToString());

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiFirstOrDefault_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {};

	var firstNumOrDefault = numbers.Execute<int>("FirstOrDefault()");

	var sb = new StringBuilder();

	sb.AppendLine(firstNumOrDefault.ToString());

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
0

{% endhighlight %}

## FirstOrDefault - Condition
This C# example uses the LINQ FirstOrDefault method with a dynamic expression to find the first product whose ProductID is 789 as a single Product object, unless there is no match, in which case null is returned.

### LINQ
{% highlight csharp %}
private void uiFirstOrDefault_Condition_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var product789 = products.FirstOrDefault(p => p.ProductID == 789);

	var sb = new StringBuilder();

	sb.AppendLine("Product 789 exists: {0}", product789 != null);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiFirstOrDefault_Condition_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var product789 = products.FirstOrDefault(p => "p.ProductID == 789");

	var sb = new StringBuilder();

	sb.AppendLine("Product 789 exists: {0}", product789 != null);

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiFirstOrDefault_Condition_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var product789 = products.Execute<My.Product>("FirstOrDefault(p => p.ProductID == 789)");

	var sb = new StringBuilder();

	sb.AppendLine("Product 789 exists: {0}", product789 != null);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Product 789 exists: False

{% endhighlight %}
