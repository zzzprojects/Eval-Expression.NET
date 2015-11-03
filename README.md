
###Evaluate, Compile and Execute code and expression at runtime.###

*From simple expression...*
```csharp
int result = Eval.Execute<int>("x + y", new { x = 1, y = 2})
```
*To complex code.*
```csharp
var sum = Eval.Execute(@"var list = new List<int>(x, y, z);
return list.Where(x => x > 2).Sum(x);", new { x = 1, y = 2, z = 3 });
```

## Download
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/v/Z.Expressions.Eval.svg?style=flat-square" /></a>
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/dt/Z.Expressions.Eval.svg?style=flat-square" /></a>

You will find the Z.Expressions.Eval library on nuget.org via package name
```
Z.Compiler.
```
To install EntityFramework.Extended, run the following command in the Package Manager Console
```
PM> Install-Package Z.Compiler
```

Enjoy all free features for an unlimited period and PRO features for the current month.

To unlock all PRO features, visit http://eval-expression.net/


## Eval.Execute
**Evaluate and execute a code or an expression.**

> *Using Anonymous Class*

```csharp
int result = Eval.Execute<int>("x + y", new { x = 1, y = 2})
```

> *Using Ordinal Position*

```csharp
int result = Eval.Execute<int>("{0} + {1}", x, y)
```

> *Using Extension Methods*

```csharp
string s = "x + y";
int result = s.Eval<int>(new { x = 1, y = 2 });
```
[Learn more](http://eval-expression.net/docs/#more-eval-execute)

## Eval.Compile
**Compile a code or an expression and return a delegate of type Func or Action to execute.**

*Using custom Delegate*
```csharp
Func<int> compiled = Eval.Compile<Func<int>>("x + y", new { x = 1, y = 2})
int result = compiled(1);
```

*Using Extension Methods*
```csharp
string code = "x + y";
var compiled = code.Compile<Func<int, int>>("x", "y");
foreach(var item in list)
{
}
```
[Learn more](http://eval-expression.net/docs/#more-eval-compile)

## Free VS Pro
Features | FREE Version | [PRO Version](http://eval-expression.net/#pro)
------------ | :-------------: | :-------------:
Maximum Characters | 50 | Unlimited
Commercial License | No | Yes
Royalty-Free | No | Yes
Support & Upgrades (1 year) | No | Yes
Learn more about the [PRO Version](http://eval-expression.net/#pro)

## Support
- [Website](http://eval-expression.net/)
- [Documentation](http://eval-expression.net/docs/)
- [Forum](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
- sales@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!

## More Projects
  - [NET Entity Framework Ext.](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
  - [NET Bulk Operations](http://www.zzzprojects.com/products/dotnet-development/bulk-operations/)
  - [Eval Expression.NET](http://eval-expression.net/)
  - [Eval SQL.NET](http://eval-sql.net/)


