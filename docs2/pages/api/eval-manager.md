# Eval Manager

## Description
{{ page.description }}

## Cache
Gets or sets the cache to use to cache compiled delegate.

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
EvalManager.Cache = MemoryCache.Default;
```

> You can use your own cache provider inheriting from System.Runtime.Caching.ObjectCache

## DefaultContext
Gets or sets the default context to use for all operations using the default context.

You can also directly change options
 - [Register & Unregister](register-unregister)
 - [Options](options)

The default context is used in static methods:
- [Eval.Execute](eval-execute)
- [Eval.Compile](eval-compile)
- [LINQ Dynamic](linq-dynamic)
- [string".Execute](string-extensions#stringexecute)
- [string".Compile](string-extensions#stringcompile)

### Example
```csharp
// using Z.Expressions; // Don't forget to include this.
EvalManager.DefaultContext.RegisterExtensionMethod(typeof(Z.ExtensionMethods))

// Make member case insensitive (Math.pOW = Math.Pow)
EvalManager.DefaultContext.BindingFlags = BindingFlags.IgnoreCase | context.BindingFlags
```


