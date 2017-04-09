---
layout: default
title: Compile & Execute
permalink: compile-execute
---

{% include template-h1.html %}

## Introduction

The EvalContext allow specifying customer configuration for evaluating, compiling and executing C# code and expression at runtime.

## Execute
### Problem
You need to evaluate a dynamic C# code in an instance context.

### Solution
Create a new instance of EvalContext and use Execute method:
- Execute&lt;TResult&gt;(string code)
- Execute&lt;TResult&gt;(string code, object parameters)
- Execute&lt;TResult&gt;(string code, params object[] parameters)
- Execute(string code)
- Execute(string code, object parameters)
- Execute(string code, params object[] parameters)

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.

var context = new EvalContext();
// ... context options ...

string code = "Price * Quantity";
var price = context.Execute<decimal>(code, orderItem);
```

## Compile
### Problem
You need to compile a dynamic C# code in an instance context.

### Solution
Create a new instance of EvalContext and use Compile method:
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
```csharp
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
```
