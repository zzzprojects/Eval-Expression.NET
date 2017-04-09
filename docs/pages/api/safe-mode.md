---
layout: default
title: Safe Mode
permalink: safe-mode
---

### Problem
You want to allow your users to create and evaluate some generic expression. However, you need to limit access on what user can do!

### Solution
Use the **SafeMode** property.

When enabled, the user can only use registered:
- Constructor
- Field
- Method
- Property

##### Example
```csharp
var context = new EvalContext();
context.SafeMode = true;
context.UnregisterAll();
context.RegisterDefaultAliasSafe();

return context.Eval("1+2");
```
