---
layout: default
title: Eval Manager
permalink: eval-manager
---

{% include template-h1.html %}

## Introduction
The EvalManager static class keep global configuration shared between evaluation instance.

## Cache
### Problem
You want to use your own cache to cache compiled lambda expression.

### Solution
You can change the shared cache by any cache inheriting from System.Runtime.Caching.ObjectCache class.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
EvalManager.Cache = MemoryCache.Default;
```

> You can use your own cache provider inheriting from System.Runtime.Caching.ObjectCache

## DefaultContext
### Problem
You want to change default configuration for all evaluations context.

### Solution
Change default EvalContext configuration to
 - [Register & Unregister](https://github.com/zzzprojects/Eval-Expression.NET/wiki/EvalContext-Register-&-Unregister)
 - [Change Options](https://github.com/zzzprojects/Eval-Expression.NET/wiki/EvalContext-Options)

The default context is used in static methods:
- [Eval.Execute](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Eval-Execute)
- [Eval.Compile](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Eval-Compile)
- ["string".Execute](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Extension-Methods)
- ["string".Compile](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Extension-Methods)
- [Dynamic LINQ](https://github.com/zzzprojects/Eval-Expression.NET/wiki/LINQ-Dynamic)

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
EvalManager.DefaultContext.RegisterExtensionMethod(typeof(Z.ExtensionMethods))

// Make member case insensitive (Math.pOW = Math.Pow)
EvalManager.DefaultContext.BindingFlags = BindingFlags.IgnoreCase | context.BindingFlags
```


