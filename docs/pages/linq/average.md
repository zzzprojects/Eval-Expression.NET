---
layout: default
title: LINQ Dynamic - Average
description: C# Dynamic LINQ Average examples using an Expression Evaluator.
permalink: linq-dynamic-average-examples
---

{% include template-h1.html %}

## LINQ Dynamic Average Examples
{{ page.description }}

- [Average - Simple](#average---simple)
- [Average - Projection](#average---projection)
- [Average - Grouped](#average---grouped)

## Average - Simple
This C# example uses the LINQ Average method with a dynamic expression to get the average of all numbers in an array.

### LINQ
{% highlight csharp %}
private void uiAverage_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var averageNum = numbers.Average();

	var sb = new StringBuilder();

	sb.AppendLine("The average number is {0}.", averageNum);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiAverage_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var averageNum = numbers.Execute<double>("Average()");

	var sb = new StringBuilder();

	sb.AppendLine("The average number is {0}.", averageNum);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The average number is 4.5.

{% endhighlight %}

## Average - Projection
This C# example uses the LINQ Average method with a dynamic expression to get the average length of the words in the array.

### LINQ
{% highlight csharp %}
private void uiAverage_Projection_LINQ_Click(object sender, EventArgs e)
{
	string[] words = {"cherry", "apple", "blueberry"};

	var averageLength = words.Average(w => w.Length);

	var sb = new StringBuilder();

	sb.AppendLine("The average word length is {0} characters.", averageLength);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiAverage_Projection_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] words = {"cherry", "apple", "blueberry"};

	var averageLength = words.Execute<double>("Average(w => w.Length)");

	var sb = new StringBuilder();

	sb.AppendLine("The average word length is {0} characters.", averageLength);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The average word length is 6.66666666666667 characters.

{% endhighlight %}

## Average - Grouped
This C# example uses the LINQ Average method with a dynamic expression to get the average price of each category's products.

### LINQ
{% highlight csharp %}
private void uiAverage_Grouped_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.GroupBy(prod => prod.Category).Select(g => new {Category = g.Key, AveragePrice = g.Average(prod => prod.UnitPrice)});

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}


### LINQ Execute
{% highlight csharp %}
private void uiAverage_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.Execute("GroupBy(prod => prod.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(prod => prod.UnitPrice) })");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Category=Beverages 
Category=Condiments 
Category=Produce 
Category=Meat/Poultry 
Category=Seafood 
Category=Dairy Products 
Category=Confections 
Category=Grains/Cereals	AveragePrice=37.979166666666666666666666667 
AveragePrice=23.0625 
AveragePrice=32.3700 
AveragePrice=54.006666666666666666666666667 
AveragePrice=20.6825 
AveragePrice=28.7300 
AveragePrice=25.1600 
AveragePrice=20.2500

{% endhighlight %}
