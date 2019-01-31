# Evaluate, Compile and Execute dynamic C# code and expression at runtime

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

> Eval Expression.NET improve dramatically performance to access public and private method, field, property value or to create object instance over using C# reflection.

## Download
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/eval-expression-net-v.svg" alt="download" /></a>
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank"><img src="https://zzzprojects.github.io/images/nuget/eval-expression-net-d.svg" alt="" /></a>

```
PM> Install-Package Z.Expressions.Eval
```

_* PRO Version unlocked for the current month_

Stay updated with latest changes

<a href="https://twitter.com/zzzprojects" target="_blank"><img src="http://www.zzzprojects.com/images/twitter_follow.png" alt="Twitter Follow" height="24" /></a>
<a href="https://www.facebook.com/zzzprojects/" target="_blank"><img src="http://www.zzzprojects.com/images/facebook_like.png" alt="Facebook Like" height="24" /></a>

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
Eval Expression.NET support all C# Syntax:
- All C# Keywords ([MSDN Documentation](https://msdn.microsoft.com/en-us/library/x53a06bb.aspx))
- All C# Operators ([MSDN Documentation](https://msdn.microsoft.com/en-CA/library/6a71f45d.aspx))
- Constant Folding
- Extension Methods
- Generic Type
- Lambda Expression
- Number Suffix

You can even access to C# 6.0 features even if you are using C# 4.0.
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
 - Fork it
 - Star it
 - Share it
 
A **HUGE THANKS** for your help.

## More Projects

**Entity Framework**
- [EntityFramework Extensions](https://entityframework-extensions.net/)
- [EntityFramework Plus](https://entityframework-plus.net)

**Bulk Operations**
- [Bulk Operations](https://bulk-operations.net/)
- [Dapper Plus](https://dapper-plus.net/)

**Expression Evaluator**
- [Eval-SQL.NET](https://eval-sql.net/)
- [Eval-Expression.NET](https://eval-expression.net/)

**Utilities**
- [Extension Methods Library](https://github.com/zzzprojects/Z.ExtensionMethods/)
- [Html Agility Pack](https://html-agility-pack.net/)

**Need more info?** info@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!
