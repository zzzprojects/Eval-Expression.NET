# LINQ Dynamic - Combine

## LINQ Dynamic Combine Examples
{{ page.description }}

- [Combine](#combine)

## Combine
This C# example uses the LINQ Combine method with a dynamic expression to calculates the dot product of two integer vectors. It uses a user-created sequence operator, Combine, to calculate the dot product, passing it a lambda function to multiply two arrays, element by element, and sum the result.

### LINQ
```csharp
int[] vectorA = {0, 2, 4, 5, 6};
int[] vectorB = {1, 3, 5, 7, 8};

var dotProduct = vectorA.Combine(vectorB, (a, b) => a * b).Sum();

Console.WriteLine("Dot product: {0}", dotProduct);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/sqa5uV' %}

### LINQ Execute
```csharp
int[] vectorA = {0, 2, 4, 5, 6};
int[] vectorB = {1, 3, 5, 7, 8};

EvalManager.DefaultContext.RegisterExtensionMethod(typeof(CustomSequenceOperators));
var dotProduct = vectorA.Execute<int>("Combine(vectorB, (a, b) => a * b).Sum()", new {vectorB});

Console.WriteLine("Dot product: {0}", dotProduct);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/DR5a6p' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Dot product: 109

```
