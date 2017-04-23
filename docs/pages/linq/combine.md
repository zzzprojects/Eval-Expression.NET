---
layout: default
title: LINQ Dynamic - Combine
description: C# Dynamic LINQ Combine examples using an Expression Evaluator.
permalink: linq-dynamic-combine-examples
---

{% include template-h1.html %}

## LINQ Dynamic Combine Examples
{{ page.description }}

- [Combine](#combine)

## Combine
This C# example uses the LINQ Combine method with a dynamic expression to calculates the dot product of two integer vectors. It uses a user-created sequence operator, Combine, to calculate the dot product, passing it a lambda function to multiply two arrays, element by element, and sum the result.

### LINQ
{% highlight csharp %}
private void uiCombine_LINQ_Click(object sender, EventArgs e)
    {
        int[] vectorA = {0, 2, 4, 5, 6};
        int[] vectorB = {1, 3, 5, 7, 8};

        var dotProduct = vectorA.Combine(vectorB, (a, b) => a * b).Sum();

        var sb = new StringBuilder();

        sb.AppendLine("Dot product: {0}", dotProduct);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}


### LINQ Execute
{% highlight csharp %}
private void uiCombine_LINQ_Execute_Click(object sender, EventArgs e)
    {
        int[] vectorA = {0, 2, 4, 5, 6};
        int[] vectorB = {1, 3, 5, 7, 8};

        EvalManager.DefaultContext.RegisterExtensionMethod(typeof(CustomSequenceOperators));
        var dotProduct = vectorA.Execute<int>("Combine(vectorB, (a, b) => a * b).Sum()", new {vectorB});

        var sb = new StringBuilder();

        sb.AppendLine("Dot product: {0}", dotProduct);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Dot product: 109

{% endhighlight %}
