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

Even with this optimization, if you have to evaluate multiple times the same expression, by example in a for loop, we highly recommend using directly the delegate returning from the Compile method.

- [Eval.Execute<TResult>](#execute-and-return-a-specific-type)
- [Eval.Execute<object>](#execute-and-return-an-object)
- [Execute with parameter](#execute-with-parameter)

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.

var result = Eval.Execute<int>("X*Y", new { X = 2, Y = 3 }); // return 6
{% endhighlight %}

## Execute with parameter
You can specify parameter from various way:

- By Anonymous Type
- By Class Member
- By Dictionary
- By Argument Position

## Execute and return a specific type
You can return the result as a specific type if you know it

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

## Execute and return an object
You can return the result as an object if you doesn’t know the type.

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
