---
layout: default
title: Options
permalink: options
---

{% include template-h1.html %}

## Introduction
The EvalContext allow customizing multiple options to change the context under which the code or expression is compiled.

## BindingFlags
### Problem
You want to change default BindingFlags used to retrieve member (Constructor, Method, Property, and Field)

### Solution
Use the **BindingFlags** property.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();

// Make member case insensitive (Math.pOW = Math.Pow)
context.BindingFlags = BindingFlags.IgnoreCase | context.BindingFlags
```

## CacheKeyPrefix
### Problem
You want to change the cache key prefix used to cache compiled expression.

### Solution
Use the **CacheKey** property.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.CacheKey = Guid.NewGuid().ToString();
```

### Discussion
We recommend always to use a different cache key prefix if you use different options.

## UseCache
### Problem
You want to disable the caching for compiled expression.

### Solution
Use the **UseCache** property.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.UseCache = false;
```

### Discussion
This configuration can be very useful to disable if you execute multiple expression only once, and you believe they will never be re-used.

## UseCaretForExponent
### Problem
You want to change the XOR operator '^' to act like an exponent operator instead.

### Solution
Use the **UseCaretForExponent** property.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext() { UseCache = false };

var exclusiveOrValue = context.Eval("2^3"); // return 1;

context.UseCaretForExponent = true;
var exponentValue = = context.Eval("2^3"); // return 8;

var newExlusiveOrValue = = context.Eval("2^|3"); // return 1;
```

### Discussion
A new operator '^|' is available for the bitwise exclusive-OR operator.

## Clone
### Problem
You want to make a shallow copy of the current EvalContext

### Solution
Use the **Clone** method.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
var context = EvalManager.DefaultContext.Clone();
```

### Discussion
Cloning the EvalContext can be useful to copy all options including all types already registered to use it to change only what's required for the expression to evaluate.
