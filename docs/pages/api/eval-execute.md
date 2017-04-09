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

