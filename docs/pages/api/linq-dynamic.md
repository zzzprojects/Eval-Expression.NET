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

However, the reality is some developer still need to write LINQ with dynamic query expression.

The Eval-Expression.NET library makes it possible and very easy by allowing dynamic query with the same syntax as LINQ.

Everything you do in LINQ, you can do it dynamically with this library. The C# dynamic expression is not interpreted but compiled into LINQ expression.

### Example
```csharp
var list = new List<int>() { 1, 2, 3, 4, 5 };

var linqStatic  = list.Where(x => x > 2);
var linqDynamic = list.Where(x => "x > 2");
```

## Eval Dynamic LINQ - Predicate

### Problem
You need to filter a LINQ query using a C# dynamic expression.

### Solution
All LINQ predicate methods are supported:

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

You can even pass parameters to make the dynamic query expression even more generic.

### Example
```csharp
var list = new List<int>() { 1, 2, 3, 4, 5 };

var list2 = list.Where(x => "x > 2");
var list3 = list.Where(x => "x > X", new { X = 2 }); // with parameter
```

## Eval Dynamic LINQ - Order && Select
### Problem
You need to select or order by a LINQ query using a C# dynamic expression.

### Solution
All LINQ selector and order are supported.

 - OrderByDescendingDynamic
 - OrderByDynamic
 - SelectDynamic
 - SelectMany
 - ThenByDescendingDynamic
 - ThenByDynamic

### Example
```csharp
var list = new List<int>() { 5, 2, 4, 1, 3 };

var list2 = list.SelectDynamic(x => "new { y = x + 1 }");
var list3 = list.SelectDynamic(x => "new { y = x + 1 }", new { y = 1 });
```
```csharp
var list = new List<int>() { 5, 2, 4, 1, 3 };

var list2 = list.OrderByDynamic(x => "x + 1");
var list3 = list.OrderByDynamic(x => "x + Y", new { Y = 1 });
```

### Discussion
The **"Dynamic"** suffix is required for not overriding the default behavior (Ordering or selecting by a string is valid).

## Eval Dynamic LINQ - Execute
### Problem
You need to chain multiple LINQ methods from a LINQ query using a C# dynamic expression.

### Solution
The Execute method is the Eval Dynamic LINQ ultimate methods which let you evaluate and execute a dynamic expression and return the result.

- Execute
- Execute&lt;TResult&gt;

### Example
```csharp
var list = new List<int>() { 1, 2, 3, 4, 5 };

var list2 = list.Execute<List<int>>("Where(x => x > 2).OrderBy(x => x).ToList()");
var list3 = list.Execute<List<int>>("Where(x => x > y).OrderBy(x => x).ToList()", new { y = 2 });
```
