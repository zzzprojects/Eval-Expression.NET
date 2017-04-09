---
layout: default
title: Eval.Execute
permalink: eval-execute
---

{% include template-h1.html %}

## Introduction

The Eval.Execute method allows executing a C# expression dynamically at runtime.

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
