---
layout: default
title: Eval.Compile
permalink: eval-compile
---

{% include template-h1.html %}

## Introduction
The Eval.Compile method allows to compile a C# expression dynamically at runtime and return a delegate (Func or Action).

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.

string code = "Price * Quantity";
var compiled = Eval.Compile<Func<OrderItem, decimal>>(code);

decimal totals = 0;
foreach(var order in orders)
{
    totals += compiled(order);
}
```

> Use Compile over Execute when you need to run the expression multiple times.

## Eval.Compile&lt;TDelegate&gt;
### Problem
You need to compile a dynamic C# code and return a strongly typed delegate.

### Solution
Use the generic Eval.Compile method:
- Eval.Compile&lt;TDelegate&gt;(string code)
- Eval.Compile&lt;TDelegate&gt;(string code, IEnumerable&lt;string&gt; parameterNames)
- Eval.Compile&lt;TDelegate&gt;(string code, params string[] parameterNames)

### Example
```csharp
// Delegate Func
var compiled = Eval.Compile<Func<int, int, int>>("{0} + {1}");
int result = compiled(1, 2);

// Delegate Action
var compiled = Eval.Compile<Action<int, int>>("{0} + {1}");
compiled(1, 2);

// Named Parameter
var compiled = Eval.Compile<Func<int, int, int>>("X + Y", "X", "Y");
int result = compiled(1, 2);
```

## Eval.Compile
### Problem
You need to compile a dynamic C# code and return a delegate.

### Solution
Use the Eval.Compile method:
- Eval.Compile(string code): Func&lt;object&gt;
- Eval.Compile(string code, Type type1): Func&lt;object, object&gt;
- Eval.Compile(string code, Type type1, ... , Type type9): Func&lt;object, ... , object, object&gt;
- Eval.Compile(string code, IEnumerable&lt;Type&gt; types): Func&lt;IEnumerable, object&gt;
- Eval.Compile(string code, params Type[] types): Func&lt;IEnumerable, object&gt;
- Eval.Compile(string code, IDictionary&lt;string, Type&gt; nameTypes): Func&lt;IDictionary, object&gt;

### Example
```csharp
// Overload: Up to 9 parameters can be used
var compiled = Eval.Compile("{0} + {1}", typeof(int), typeof(int));
object result = compiled(1, 2);

// Overload: params Type[]
var values = new List<int>() {1, 2};
var types = values.Select(x => x.GetType()).ToArray();

var compiled = Eval.Compile("{0} + {1}", types);
var result = compiled(values);

// Overload: IDictionary<string, Type>
var values = new Dictionary<string, object> { {"X", 1}, {"Y", 2} };
var types = values.ToDictionary(x => x.Key, x => x.Value.GetType());

var compiled = Eval.Compile("X + Y", types);
var result = compiled(values);
```


