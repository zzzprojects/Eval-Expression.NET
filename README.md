##Evaluate, Compile and Execute code and expression in .NET at runtime##

*From simple expression...*
```csharp
int result = Eval.Execute<int>("X + Y", new { X = 1, Y = 2});
```
*To complex code.*
```csharp
int result = Eval.Execute<int>(@"
	var list = new List<int>() { 1..100 };
	var filter = list.Where(x => x < 3);
	return result.Sum(x => x);");
```

## Download
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/v/Z.Expressions.Eval.svg?style=flat-square" /></a>
<a href="https://www.nuget.org/packages/Z.Expressions.Eval/" target="_blank" alt="download nuget"><img src="https://img.shields.io/nuget/dt/Z.Expressions.Eval.svg?style=flat-square" /></a>

```
PM> Install-Package Z.Expressions.Eval
```
*FREE Version - up to 50 characters

## Eval.Execute
**Evaluate and execute the code or expression.**

**Support:**

_Anonymous Class_

```csharp
int result = Eval.Execute<int>("X + Y", new { X = 1, Y = 2});
```

_Argument Position_

```csharp
int result = Eval.Execute<int>("{0} + {1}", 1, 2);
```

_Class Member_

```csharp
var price = Eval.Execute<decimal>("ItemPrice * Quantity", orderItem);
```

_Extension Methods_

```csharp
string s = "X + Y";
int result = s.Eval<int>(new { X = 1, Y = 2 });
```
**[Learn more](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Eval-Execute)**

## Eval.Compile
**Compile the code or expression and return a delegate.**

**Support:**

*Custom Delegate*
```csharp
Func<int> compiled = Eval.Compile<Func<int, int ,int>>("X + Y", "X", "Y");
foreach(var item in list)
{
	int result = compiled(item.Value1, item.Value2);
}
```

*Extension Methods*
```csharp
string s = "X + Y";
var compiled = s.Compile<Func<int, int>>("X", "Y");
foreach(var item in list)
{
	int result = compiled(item.Value1, item.Value2);
}
```
**[Learn more](https://github.com/zzzprojects/Eval-Expression.NET/wiki/Eval-Compile)**

## FREE vs PRO
With the free version comes a month long trial of the pro license to let you evaluate all its functonalities without limits.

Features | FREE Version | [PRO Version](http://eval-expression.net/#pro)
------------ | :-------------: | :-------------:
Maximum Characters | 50 | Unlimited
Commercial License | No | Yes
Royalty-Free | No | Yes
Support & Upgrades (1 year) | No | Yes
Learn more about the **[PRO Version](http://eval-expression.net/#pro)**

## Support
Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!

- [Website](http://eval-expression.net/)
- [Documentation](https://github.com/zzzprojects/Eval-Expression.NET/wiki)
- [Forum](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
- sales@zzzprojects.com

## More Projects
  - [NET Entity Framework Extensions](http://www.zzzprojects.com/products/dotnet-development/entity-framework-extensions/)
  - [NET Bulk Operations](http://www.zzzprojects.com/products/dotnet-development/bulk-operations/)
  - [Eval Expression.NET](http://eval-expression.net/)
  - [Eval SQL.NET](http://eval-sql.net/)


