---
layout: default
title: Eval.Execute
permalink: eval-execute
description: Execute a C# expression and return the result.
---

{% include template-h1.html %}

## Description
{{ page.description }}

Under the hood, the fist time an expression is executed, it's before compiled and the delegate is stored in the memory before being returned and executed. All future call from the same expression will retrieve the delegate from the memory to optimize the performance.

Even with this optimization, if you have to evaluate consecutively the same expression, by example in a for loop, we highly recommend using directly the delegate returning from the Compile method. 

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.

var result = Eval.Execute<int>("X*Y", new { X = 2, Y = 3 }); // return 6
{% endhighlight %}

> Use Execute over Compile when you need to run the expression only once.

## Eval.Execute&lt;TResult&gt;

### Problem
You need to evaluate a dynamic C# code and return a strongly-typed value.

### Solution
Use the generic Eval.Execute method:

- Eval.Execute&lt;TResult&gt;(string code)
- Eval.Execute&lt;TResult&gt;(string code, object parameters)
- Eval.Execute&lt;TResult&gt;(string code, params object[] parameters)

### Example

{% highlight csharp %}
// Parameter: Anonymous Type
int result = Eval.Execute<int>("X + Y", new { X = 1, Y = 2} );

// Parameter: Class Member
dynamic expandoObject = new ExpandoObject();
expandoObject.X = 1;
expandoObject.Y = 2;
int result = Eval.Execute<int>("X + Y", expandoObject);

// Parameter: Dictionary Key
var values = new Dictionary<string, object>() { {"X", 1}, {"Y", 2} };
int result = Eval.Execute<int>("X + Y", values);

// Parameter: Argument Position
int result = Eval.Execute<int>("{0} + {1}", 1, 2);
{% endhighlight %}

## Eval.Execute

### Problem
You need to evaluate a dynamic C# code and return a value or nothing.

### Solution
Use the Eval.Execute method:
- Eval.Execute(string code)
- Eval.Execute(string code, object parameters)
- Eval.Execute(string code, params object[] parameters)

### Example
{% highlight csharp %}
// Parameter: Anonymous Type
object result = Eval.Execute("X + Y", new { X = 1, Y = 2} );

// Parameter: Class Member
dynamic expandoObject = new ExpandoObject();
expandoObject.X = 1;
expandoObject.Y = 2;
object result = Eval.Execute("X + Y", expandoObject);

// Parameter: Dictionary Key
var values = new Dictionary<string, object>() { {"X", 1}, {"Y", 2} };
object result = Eval.Execute("X + Y", values);

// Parameter: Argument Position
object result = Eval.Execute("{0} + {1}", 1, 2);
{% endhighlight %}

## Eval.Execute Parameter

### Problem
You need to evaluate a C# expression dynamically using one or many parameters.

### Solution
The Eval.Execute method supports all common parameter resolution

- By Anonymous Type
- By Class Member
- By Dictionary
- By Argument Position
