---
layout: default
title: LINQ Dynamic - First
description: C# Dynamic LINQ First examples using an Expression Evaluator.
permalink: linq-dynamic-first-examples
---

{% include template-h1.html %}

## LINQ Dynamic First Examples
{{ page.description }}

- [First - Simple](#first---simple)
- [First - Condition](#first---condition)

## First - Simple
This C# example uses the LINQ First method with a dynamic expression to find the first matching element as a Product, instead of as a sequence containing a Product.

### LINQ
{% highlight csharp %}
private void uiFirst_Simple_LINQ_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var product12 = products.Where(p => p.ProductID == 12).First();

        var sb = new StringBuilder();

        My.ObjectDumper.Write(sb, product12);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiFirst_Simple_LINQ_Execute_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var product12 = products.Where(p => p.ProductID == 12).Execute("First()");

        var sb = new StringBuilder();

        My.ObjectDumper.Write(sb, product12);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
ProductID=12 ProductName=Queso Manchego La Pastora Category=Dairy Products UnitPrice=38.0000 UnitsInStock=86

{% endhighlight %}

## First - Condition
This C# example uses the LINQ First method with a dynamic expression to find the first element in the array that starts with 'o'.

### LINQ
{% highlight csharp %}
private void uiFirst_Condition_LINQ_Click(object sender, EventArgs e)
    {
        string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        var startsWithO = strings.First(s => s[0] == 'o');

        var sb = new StringBuilder();

        sb.AppendLine("A string starting with 'o': {0}", startsWithO);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiFirst_Condition_LINQ_Dynamic_Click(object sender, EventArgs e)
    {
        string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        var startsWithO = strings.First(s => "s[0] == 'o'");

        var sb = new StringBuilder();

        sb.AppendLine("A string starting with 'o': {0}", startsWithO);

        My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiFirst_Condition_LINQ_Execute_Click(object sender, EventArgs e)
    {
        string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        var startsWithO = strings.Execute<string>("First(s => s[0] == 'o')");

        var sb = new StringBuilder();

        sb.AppendLine("A string starting with 'o': {0}", startsWithO);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
A string starting with 'o': one

{% endhighlight %}
