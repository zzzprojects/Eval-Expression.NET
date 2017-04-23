---
layout: default
title: LINQ Dynamic - Distinct
description: C# Dynamic LINQ Distinct examples using an Expression Evaluator.
permalink: linq-dynamic-distinct-examples
---

{% include template-h1.html %}

## LINQ Dynamic Distinct Examples
{{ page.description }}

- [Distinct - 1](#distinct---1)
- [Distinct - 2](#distinct---2)

## Distinct - 1
This C# example uses the LINQ Distinct method with a dynamic expression to remove duplicate elements in a sequence of factors of 300.

### LINQ
{% highlight csharp %}
 private void uiDistinct_1_LINQ_Click(object sender, EventArgs e)
    {
        int[] factorsOf300 = {2, 2, 3, 5, 5};

        var uniqueFactors = factorsOf300.Distinct();

        var sb = new StringBuilder();

        sb.AppendLine("Prime factors of 300:");
			foreach (var f in uniqueFactors)
            {
                sb.AppendLine(f.ToString());
            }

		My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
	}

{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiDistinct_1_LINQ_Execute_Click(object sender, EventArgs e)
    {
        int[] factorsOf300 = {2, 2, 3, 5, 5};

        var uniqueFactors = factorsOf300.Execute<IEnumerable<int>>("Distinct()");

        var sb = new StringBuilder();

        sb.AppendLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                sb.AppendLine(f.ToString());
            }

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Prime factors of 300:
2
3
5

{% endhighlight %}

## Distinct - 2
This C# example uses the LINQ Distinct method with a dynamic expression to find the unique Category names.

### LINQ
{% highlight csharp %}
private void uiDistinct_2_LINQ_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var categoryNames = products.Select(x => x.Category).Distinct();

        var sb = new StringBuilder();

        sb.AppendLine("Category names:");
            foreach (var n in categoryNames)
            {
                sb.AppendLine(n);
            }

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}


### LINQ Execute
{% highlight csharp %}
private void uiDistinct_2_LINQ_Execute_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var categoryNames = products.Execute<IEnumerable<string>>("Select(x => x.Category).Distinct()");

        var sb = new StringBuilder();

        sb.AppendLine("Category names:");
            foreach (var n in categoryNames)
            {
                sb.AppendLine(n);
            }

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Category names:
Beverages
Condiments
Produce
Meat/Poultry
Seafood
Dairy Products
Confections
Grains/Cereals

{% endhighlight %}
