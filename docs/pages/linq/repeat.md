---
layout: default
title: LINQ Dynamic - Repeat
description: C# Dynamic LINQ Repeat examples using an Expression Evaluator.
permalink: linq-dynamic-repeat-examples
---

{% include template-h1.html %}

## LINQ Dynamic Repeat Examples
{{ page.description }}

- [Repeat](#repeat)

## Repeat
This C# example uses the LINQ Repeat method with a dynamic expression to generate a sequence that contains the number 7 ten times.

### LINQ
{% highlight csharp %}
private void uiRepeat_LINQ_Click(object sender, EventArgs e)
    {
        var numbers = Enumerable.Repeat(7, 10);

        var sb = new StringBuilder();

            foreach (var n in numbers)
            {
                sb.AppendLine(n.ToString());
            }

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiRepeat_LINQ_Execute_Click(object sender, EventArgs e)
    {
        EvalManager.DefaultContext.RegisterType(typeof(Enumerable));
        var numbers = Z.Expressions.Eval.Execute<IEnumerable<int>>("Enumerable.Repeat(7, 10)");

        var sb = new StringBuilder();

            foreach (var n in numbers)
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
7
7
7
7
7
7
7
7
7
7

{% endhighlight %}
