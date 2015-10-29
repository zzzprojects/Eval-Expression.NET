
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
<a href="https://www.nuget.org/packages/EntityFramework/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/v/Z.Compiler.svg?style=flat-square" /></a>
<a href="https://www.nuget.org/packages/EntityFramework/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/dt/Z.Compiler.svg?style=flat-square" /></a>

```
PM> Install-Package Z.Compiler
```

## Eval.Execute
**Evaluate and execute a code or expression.**

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
[Learn more](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)

## Eval.Compile
**Compile a code or expression and return a delegate of type Func or Action to execute.**

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
[Learn more](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)

## Free VS Pro
Features | FREE Version | [PRO Version](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
------------ | :-------------: | :-------------:
Maximum Characters | 50 | Unlimited
Maximum Variables | 2 | Unlimited
Learn more about the [PRO Version](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)

## Support
- [Website](http://eval-sql.net/)
- [Documentation](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
- [Forum](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
- sales@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!

## More Projects
  - [NET Entity Framework Ext](sales@zzzprojects.com)
  - [NET Bulk Operations](sales@zzzprojects.com)
  - [Eval Expression.NET](sales@zzzprojects.com)
  - [Eval SQL.NET](sales@zzzprojects.com)


