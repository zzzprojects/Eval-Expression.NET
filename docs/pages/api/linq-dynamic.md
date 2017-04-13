---
layout: default
title: LINQ Dynamic
description: Extend the IEnumerable&lt;T&gt; and IQueryable&lt;T&gt; interface with methods to use LINQ with dynamic expressions.
permalink: linq-dynamic
---

{% include template-h1.html %}

## Description
{{ page.description }}

LINQ (Language Integrated Query) has been introduced in .NET 3.5 and since has been one of the most used features. ORM like Entity Framework takes advantage from this feature and allow you to write type-safe queries.

## LINQ Dynamic - Predicate
You can use any LINQ method that support predicate with a dynamic C# expression :

- Deferred
   - SkipWhile
   - TakeWhile
   - Where
- Immediate
   - All
   - Any
   - Count
   - First
   - FirstOrDefault
   - Last
   - LastOrDefault
   - LongCount
   - Single
   - SingleOrDefault

### Example
{% highlight csharp %}
var list = new List<int>() { 1, 2, 3, 4, 5 };

var list2 = list.Where(x => "x > 2");
var list3 = list.Where(x => "x > X", new { X = 2 }); // with parameter
{% endhighlight %}

## LINQ Dynamic - Ordering and Selecting
You can use any ordering and selecting method with a dynamic C# expression: 

 - OrderByDescendingDynamic
 - OrderByDynamic
 - SelectDynamic
 - SelectMany
 - ThenByDescendingDynamic
 - ThenByDynamic

> The **"Dynamic"** suffix is required for not overriding the default behavior (Ordering or selecting by a string is valid).

### Example
{% highlight csharp %}
var list = new List<int>() { 5, 2, 4, 1, 3 };

// SelectDynamic
var list2 = list.SelectDynamic(x => "new { y = x + 1 }");
var list3 = list.SelectDynamic(x => "new { y = x + 1 }", new { y = 1 });

// OrderByDynamic
var list4 = list.OrderByDynamic(x => "x + 1");
var list5 = list.OrderByDynamic(x => "x + Y", new { Y = 1 });
```

## LINQ Dynamic - Execute
You can push the LINQ Dynamic experience further by using the Execute method and chaining anything else:

- Execute
- Execute&lt;TResult&gt;

### Example
{% highlight csharp %}
var list = new List<int>() { 1, 2, 3, 4, 5 };

var list2 = list.Execute<List<int>>("Where(x => x > 2).OrderBy(x => x).ToList()");
var list3 = list.Execute<List<int>>("Where(x => x > y).OrderBy(x => x).ToList()", new { y = 2 });
{% endhighlight %}
