---
layout: default
title: String Extensions
permalink: string-extensions
---

{% include template-h1.html %}

## Introduction
String extension methods extend the String class and let you execute or compile a C# expression containing in the string value.

## "string".Execute
### Problem
You need to execute a C# expression from a string.

### Solution
Use the string Execute extension methods:

- "string".Execute&lt;TResult&gt;()
- "string".Execute&lt;TResult&gt;(object parameters)
- "string".Execute&lt;TResult&gt;(params object[] parameters)
- "string".Execute()
- "string".Execute(object parameters)
- "string".Execute(params object[] parameters)

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.

var result1 = "1+2".Execute<int>(); // return 3
var result2 = "X+Y".Execute(new { X = 1, Y = 2 }); // return 3
```

## "string".Compile
### Problem
You need to compile a C# expression from a string.

### Solution
Use the string Compile extension methods:

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
```csharp
// using Z.Expressions; // Don't forget to include this.

string s = "Price * Quantity";
var compiled = s.Compile<Func<OrderItem, decimal>>(code);

decimal totals = 0;
foreach(var item in list)
{
    totals += compiled(item);
}
```
