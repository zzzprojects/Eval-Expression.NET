---
layout: default
title: String Extensions
description: Extend the String class with methods to Execute & Compile C# expression.
permalink: string-extensions
---

{% include template-h1.html %}

## Description
{{ page.description }}

Under the hood, string extensions use the default context to execute and compile expressions.
{% highlight csharp 
public static object Execute(this string code, params object[] parameters)
{
    return EvalManager.DefaultContext.Execute(code, parameters);
}
{% endhighlight %}

## "string".Execute
Execute a C# expression. Extend the String class.

- "string".Execute&lt;TResult&gt;()
- "string".Execute&lt;TResult&gt;(object parameters)
- "string".Execute&lt;TResult&gt;(params object[] parameters)
- "string".Execute()
- "string".Execute(object parameters)
- "string".Execute(params object[] parameters)

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.

var result1 = "1+2".Execute<int>(); // return 3
var result2 = "X+Y".Execute(new { X = 1, Y = 2 }); // return 3
{% endhighlight %}

## "string".Compile
Compile a C# expression. Extend the String class.

- "string".Compile&lt;TDelegate&gt;()
- "string".Compile&lt;TDelegate&gt;(IEnumerable&lt;string&gt; parameterNames)
- "string".Compile&lt;TDelegate&gt;(params string[] parameterNames)
- "string".Compile(): Func&lt;object&gt;
- "string".Compile(Type type1): Func&lt;object, object&gt;
- "string".Compile(Type type1, ... , Type type9): Func&lt;object, ... , object, object&gt;
- "string".Compile(IEnumerable&lt;Type&gt;): Func&lt;IEnumerable, object&gt;
- "string".Compile(params Type[]): Func&lt;IEnumerable, object&gt;
- "string".Compile(IDictionary&lt;string, Type&gt;): Func&lt;IDictionary, object&gt;

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.

string s = "Price * Quantity";
var compiled = s.Compile<Func<OrderItem, decimal>>(code);

decimal totals = 0;
foreach(var item in list)
{
    totals += compiled(item);
}
{% endhighlight %}
