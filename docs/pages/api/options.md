---
layout: default
title: Options
description: Options to customize the context under which the C# expression is compiled.
permalink: options
---

{% include template-h1.html %}

## Description
{{ page.description }}

## BindingFlags
Gets or sets the value of the BindingFlags to use to retrieve member (Constructor, Method, Property, and Field)

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();

// Make member case insensitive (Math.pOW = Math.Pow)
context.BindingFlags = BindingFlags.IgnoreCase | context.BindingFlags
{% endhighlight %}

## CacheKeyPrefix
Gets or sets the can key prefix to use to cache compiled delegate in the memory.

> We recommend always to use a different cache key prefix if you modify the options.

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.CacheKey = Guid.NewGuid().ToString();
{% endhighlight %}

## UseCache
Gets or sets if compiled delegate shoud be cached in the memory or not. 

> This configuration can be very useful to disable if you execute multiple expression only once, and you believe they will never be re-used.

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.UseCache = false;
{% endhighlight %}

## UseCaretForExponent
Gets or sets if the default behavior for the XOR operator '^' must act like an exponent operator instead.

> A new operator '^|' is available for the bitwise exclusive-OR operator.

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext() { UseCache = false };

var exclusiveOrValue = context.Eval("2^3"); // return 1;

context.UseCaretForExponent = true;
var exponentValue = = context.Eval("2^3"); // return 8;

var newExlusiveOrValue = = context.Eval("2^|3"); // return 1;
{% endhighlight %}

## Clone
Create a new a shallow copy of the current EvalContext

> Cloning the EvalContext can be useful to copy all options including all types already registered to use it to change only what's required for the expression to evaluate.

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = EvalManager.DefaultContext.Clone();
{% endhighlight %}
