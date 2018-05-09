---
layout: default
title: Compile & Execute
description: Compile and execute a C# expression at runtime.
permalink: compile-execute
---

{% include template-h1.html %}

## Description
{{ page.description }}

## Execute
Execute a C# expression and return the result: 

- Execute&lt;TResult&gt;(string code)
- Execute&lt;TResult&gt;(string code, object parameters)
- Execute&lt;TResult&gt;(string code, params object[] parameters)
- Execute(string code)
- Execute(string code, object parameters)
- Execute(string code, params object[] parameters)

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.

var context = new EvalContext();
// ... context options ...

string code = "Price * Quantity";
var price = context.Execute<decimal>(code, orderItem);
{% endhighlight %}
{% include  component-try-it.html href='https://dotnetfiddle.net/tzBdMI' %}

## Compile
Compile a C# expression and return a delegate: 

- Compile&lt;TDelegate&gt;(string code)
- Compile&lt;TDelegate&gt;(string code, IEnumerable&lt;string&gt; parameterNames)
- Compile&lt;TDelegate&gt;(string code, params string[] parameterNames)
- Compile(string): **Func&lt;object&gt;**
- Compile(string, Type type1): **Func&lt;object, object&gt;**
- Compile(string, Type type1, ... , Type type9): **Func&lt;object, ... , object, object&gt;**
- Compile(string, IEnumerable&lt;Type&gt;): **Func&lt;IEnumerable, object&gt;**
- Compile(string, params Type[]): **Func&lt;IEnumerable, object&gt;**
- Compile(string, IDictionary&lt;string, Type&gt;): **Func&lt;IDictionary, object&gt;**

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.

var context = new EvalContext();
// ... context options ...

string code = "Price * Quantity";
var compiled = context.Compile<Func<OrderItem, decimal>>(code);

decimal totals = 0;
foreach(var item in list)
{
    totals += compiled(item);
}
{% endhighlight %}
{% include  component-try-it.html href='https://dotnetfiddle.net/00YSGK' %}
