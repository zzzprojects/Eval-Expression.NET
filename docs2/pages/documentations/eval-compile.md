# Eval.Compile

## Description
Compile a C# expression and return a delegate.

Under the hood, the expression is parsed into tokens and then transformed into syntax node before being compiled using Expression Tree.

## Compile and return a strongly typed delegate
You can return the delegate as a strongly typed function or action:

- Eval.Compile&lt;TDelegate&gt;(string code)
- Eval.Compile&lt;TDelegate&gt;(string code, IEnumerable&lt;string&gt; parameterNames)
- Eval.Compile&lt;TDelegate&gt;(string code, params string[] parameterNames)

### Example
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
{% include  component-try-it.html href='https://dotnetfiddle.net/MBHlX8' %}

## Compile and return a delegate
You can return the delegate as a generic delegate:

- Eval.Compile(string code): Func&lt;object&gt;
- Eval.Compile(string code, Type type1): Func&lt;object, object&gt;
- Eval.Compile(string code, Type type1, ... , Type type9): Func&lt;object, ... , object, object&gt;
- Eval.Compile(string code, IEnumerable&lt;Type&gt; types): Func&lt;IEnumerable, object&gt;
- Eval.Compile(string code, params Type[] types): Func&lt;IEnumerable, object&gt;
- Eval.Compile(string code, IDictionary&lt;string, Type&gt; nameTypes): Func&lt;IDictionary, object&gt;

### Example
```csharp
// Overload: Up to 9 parameters can be used
var compiled = Eval.Compile("{0} + {1}", typeof(int), typeof(int));
object result = compiled(1, 2);

// Overload: params Type[]
var values = new List<int>() {1, 2};
var types = values.Select(x => x.GetType()).ToArray();

var compiled = Eval.Compile("{0} + {1}", types);
var result = compiled(values);

// Overload: IDictionary<string, Type>
var values = new Dictionary<string, object> { {"X", 1}, {"Y", 2} };
var types = values.ToDictionary(x => x.Key, x => x.Value.GetType());

var compiled = Eval.Compile("X + Y", types);
var result = compiled(values);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/870F71' %}


