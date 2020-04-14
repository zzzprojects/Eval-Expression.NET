Evaluate, Compile and Execute C# code at runtime.

## Url

- [Website](https://eval-expression.net/)
- [Getting Started](https://eval-expression.net/overview)
- [Documentation](https://eval-expression.net/eval-execute)
- [Online Examples](https://eval-expression.net/online-examples)

## Example Eval.Execute

```csharp
// Parameter: Anonymous Type
int result = Eval.Execute<int>("X + Y", new { X = 1, Y = 2} );

// Parameter: Argument Position
int result = Eval.Execute<int>("{0} + {1}", 1, 2);

// Parameter: Class Member
dynamic expandoObject = new ExpandoObject();
expandoObject.X = 1;
expandoObject.Y = 2;
int result = Eval.Execute<int>("X + Y", expandoObject);

// Parameter: Dictionary Key
var values = new Dictionary<string, object>() { {"X", 1}, {"Y", 2} };
int result = Eval.Execute<int>("X + Y", values);
```

Try it: [https://dotnetfiddle.net/xquPID](https://dotnetfiddle.net/xquPID)

## Example Eval.Compile

```csharp
// Delegate Func
var compiled = Eval.Compile<Func<int, int, int>>("{0} + {1}");
int result = compiled(1, 2);

// Delegate Action
var compiled = Eval.Compile<Action<int, int>>("{0} + {1}");
compiled(1, 2);

// Named Parameter
var compiled = Eval.Compile<Func<int, int, int>>("X + Y", "X", "Y");
int result = compiled(1, 2);
```

Try it: [https://dotnetfiddle.net/MBHlX8](https://dotnetfiddle.net/MBHlX8)
