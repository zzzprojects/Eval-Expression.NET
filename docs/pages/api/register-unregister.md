---
layout: default
title: Register & Unregister
description: Register and unregister assembly, constant, method, type, and more.
permalink: register-unregister
---

{% include template-h1.html %}

## Description
{{ page.description }}

By default, all .NET common class/type/extension methods are already registered.

## Register
You can register:

- RegisterAlias(string alias, string name)
- RegisterAssembly(param Assembly[])
- RegisterDomainAssemblies()
- RegisterExtensionMethod(param Type[])
- RegisterExtensionMethod(param MethodInfo[])
- RegisterGlobalConstant(string key, object value)
- RegisterGlobalVariable(string key, object value)
- RegisterStaticMember(param Type[])
- RegisterStaticMember(param MemberInfo[])
- RegisterType(param Type[])

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.RegisterAlias("Math2", "System.Math");
context.RegisterAssembly(Assembly.GetEntryAssembly());
context.RegisterDomainAssemblies();
context.RegisterExtensionMethod(typeof(Enumerable));
context.RegisterExtensionMethod(whereMethodInfo, selectMethodInfo)
context.RegisterGlobalConstant("sessionMax", 1000);
context.RegisterGlobalVariable("sessionCount", 0);
context.RegisterStaticMember(typeof(Math), typeof(Int));
context.RegisterStaticMember(powMemberInfo, RoundMemberInfo);
context.RegisterType(typeof (bool), typeof(char);
{% endhighlight %}

### Static Member
You can use static member name without qualifying them with their namespace or type name. Static member is a new feature in C# 6.0.

{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.RegisterStaticMember(typeof(Math), typeof(Int));

bool result = context.Execute<double>("Pow(2, 3)"); // Math.Pow(2, 3) = 8"
int result = context.Execute<int>("MinValue"); // Int.MinValue
{% endhighlight %}

## Unregister
### Problem
You can unregister: 

- UnregisterAlias(param string[] aliases)
- UnregisterAll
- UnregisterAssembly(param Assembly[])
- UnregisterExtensionMethod(param Type[])
- UnregisterExtensionMethod(param MethodInfo[])
- UnregisterGlobalConstant(param string[] aliases)
- UnregisterGlobalVariable(param string[] aliases)
- UnregisterStaticMember(param Type[])
- UnregisterStaticMember(param MemberInfo[])
- UnregisterType(param Type[])

### Example
{% highlight csharp %}
// using Z.Expressions; // Don't forget to include this.
var context = new EvalContext();
context.UnregisterAlias("Math2");
context.UnregisterAll();
context.UnregisterAssembly(Assembly.GetEntryAssembly());
context.UnregisterExtensionMethod(typeof(Enumerable));
context.UnregisterExtensionMethod(whereMethodInfo, selectMethodInfo)
context.UnregisterGlobalConstant("sessionMax");
context.UnregisterGlobalVariables("sessionCount");
context.UnregisterStaticMember(typeof(Math), typeof(Int));
context.UnregisterStaticMember(powMemberInfo, RoundMemberInfo);
context.UnregisterType(typeof (bool), typeof(char);
{% endhighlight %}
