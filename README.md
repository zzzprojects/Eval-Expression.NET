# What's Eval Expression.NET?
Eval Expression.NET improves performance dramatically to access public and private methods, field, property value, or create object instances overusing C# reflection.

It allows you to evaluate, Compile and Execute dynamic C# code and expression at runtime.

*From simple C# math expression...*
```csharp
int result = Eval.Execute<int>("X + Y", new { X = 1, Y = 2});
```
*To complex code to parse.*
```csharp
int result = Eval.Execute<int>(@"
	var list = new List<int>() { 1, 2, 3, 4, 5 };
	var filter = list.Where(x => x < 4);
	return filter.Sum(x => x);");
```

## Download
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/eval-expression-net-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/eval-expression-net-d.svg" alt="" /></a>

```
PM> Install-Package Z.Expressions.Eval
```

_* PRO Version unlocked for the current month_

## Eval.Execute
**Evaluate and execute the code or expression.**

**Support:**

_Anonymous Class_

```csharp
// using Z.Expressions; // Don't forget to include this.
int result = Eval.Execute<int>("X + Y", new { X = 1, Y = 2});
```

_Argument Position_

```csharp
// using Z.Expressions; // Don't forget to include this.
int result = Eval.Execute<int>("{0} + {1}", 1, 2);
```

_Class Member_

```csharp
// using Z.Expressions; // Don't forget to include this.
dynamic expandoObject = new ExpandoObject();
expandoObject.X = 1;
expandoObject.Y = 2;
int result = Eval.Execute<int>("X + Y", expandoObject);
```

_Extension Methods_

```csharp
// using Z.Expressions; // Don't forget to include this.
string s = "X + Y";
int result = s.Execute<int>(new { X = 1, Y = 2 });
```
**[Learn more](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Eval-Execute)**

## Eval.Compile
**Compile the code or expression and return a delegate.**

**Support:**

*Custom Delegate*
```csharp
// using Z.Expressions; // Don't forget to include this.
var compiled = Eval.Compile<Func<int, int, int>>("X + Y", "X", "Y");
foreach(var item in list)
{
	int result = compiled(item.Value1, item.Value2);
}
```

*Extension Methods*
```csharp
// using Z.Expressions; // Don't forget to include this.
string s = "X + Y";
var compiled = s.Compile<Func<int, int, int>>("X", "Y");
foreach(var item in list)
{
	int result = compiled(item.Value1, item.Value2);
}
```
**[Learn more](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Eval-Compile)**

## What's supported?
Eval Expression.NET supports all C# Syntax:
- All C# Keywords ([MSDN Documentation](https://msdn.microsoft.com/en-us/library/x53a06bb.aspx))
- All C# Operators ([MSDN Documentation](https://msdn.microsoft.com/en-CA/library/6a71f45d.aspx))
- Constant Folding
- Extension Methods
- Generic Type
- Lambda Expression
- Number Suffix

You can even access C# 6.0 features even if you are using C# 4.0.
- string interpolation
- typename
- null conditional member access

**[Learn more](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Syntax-Supported)**

## PRO
Every month, a new monthly trial of the PRO Version is available to let you evaluate all its features without limitations.

Features | [PRO Version](https://eval-expression.net/#pro)
------------ | :-------------:
Maximum Characters | Unlimited
Commercial License | Yes
Royalty-Free | Yes
Support & Upgrades (1 year) | Yes
Learn more about the **[PRO Version](https://eval-expression.net/#pro)**

- Starting from version 2.x, there is no longer a free limited version.
- `LINQ` extension method is free with [EF Classic - Community](https://entityframework-classic.net/)

## Contribute

The best way to contribute is by **spreading the word** about the library:

 - Blog it
 - Comment it
 - Star it
 - Share it
 
A **HUGE THANKS** for your help.

## More Projects

- [Entity Framework Extensions](https://entityframework-extensions.net/)
- [Dapper Plus](https://dapper-plus.net/)
- [Bulk Operations](https://bulk-operations.net/)
- and much more! 

To view all our free and paid projects, visit our [website](https://zzzprojects.com/).

Contact our outstanding **[customer support](https://eval-expression.net/contact-us)** for any request. We usually answer within the next day, hour, or minutes!
