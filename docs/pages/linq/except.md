---
layout: default
title: LINQ Dynamic - Except
description: C# Dynamic LINQ Except examples using an Expression Evaluator.
permalink: linq-dynamic-except-examples
---

{% include template-h1.html %}

## LINQ Dynamic Except Examples
{{ page.description }}

- [Except - 1](#except---1)
- [Except - 2](#except---2)

## Except - 1
This C# example uses the LINQ Except method with a dynamic expression to create a sequence that contains the values from numbersAthat are not also in numbersB.

### LINQ
{% highlight csharp %}
private void uiExcept_1_LINQ_Click(object sender, EventArgs e)
    {
        int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
        int[] numbersB = {1, 3, 5, 7, 8};

        var aOnlyNumbers = numbersA.Except(numbersB);

        var sb = new StringBuilder();

        sb.AppendLine("Numbers in first array but not second array:");
			foreach (var n in aOnlyNumbers)
            {
                sb.AppendLine(n.ToString());
            }

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiExcept_1_LINQ_Execute_Click(object sender, EventArgs e)
    {
        int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
        int[] numbersB = {1, 3, 5, 7, 8};

        var aOnlyNumbers = numbersA.Execute<IEnumerable<int>>("Except(numbersB)", new {numbersB});

        var sb = new StringBuilder();

        sb.AppendLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
            {
                sb.AppendLine(n.ToString());
            }

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }

{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Numbers in first array but not second array:
0
2
4
6
9

{% endhighlight %}

## Except - 2
This C# example uses the LINQ Except method with a dynamic expression to create one sequence that contains the first letters of product names that are not also first letters of customer names.

### LINQ
{% highlight csharp %}
private void uiExcept_2_LINQ_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();
        var customers = My.GetCustomerList();

		var productFirstChars = from p in products select p.ProductName[0];
        var customerFirstChars = from c in customers select c.CompanyName[0];

        var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

        var sb = new StringBuilder();

        sb.AppendLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}


### LINQ Execute
{% highlight csharp %}
private void uiExcept_2_LINQ_Execute_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();
        var customers = My.GetCustomerList();

        var productFirstChars = from p in products select p.ProductName[0];
        var customerFirstChars = from c in customers select c.CompanyName[0];

        var productOnlyFirstChars = productFirstChars.Execute<IEnumerable<char>>("Except(customerFirstChars)", new {customerFirstChars});

        var sb = new StringBuilder();

        sb.AppendLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
First letters from Product names, but not from Customer names:
U
J
Z

{% endhighlight %}
