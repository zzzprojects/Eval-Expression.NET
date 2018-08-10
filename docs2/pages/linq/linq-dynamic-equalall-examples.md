# LINQ Dynamic - EqualAll

## LINQ Dynamic EqualAll Examples
C# Dynamic LINQ EqualAll examples using an Expression Evaluator.

- [EqualAll - 1](#equalall---1)
- [EqualAll - 2](#equalall---2)

## EqualAll - 1
This C# example uses the LINQ EqualAll method with a dynamic expression to see if two sequences match on all elements in the same order.

### LINQ
```csharp
var wordsA = new[] {"cherry", "apple", "blueberry"};
var wordsB = new[] {"cherry", "apple", "blueberry"};

var match = wordsA.SequenceEqual(wordsB);

Console.WriteLine("The sequences match: {0}", match);
```
{% include component-try-it.html href='https://dotnetfiddle.net/J7H8eE' %}

### LINQ Execute
```csharp
private void uiEqualAll_1_LINQ_Execute_Click(object sender, EventArgs e)
var wordsA = new[] {"cherry", "apple", "blueberry"};
var wordsB = new[] {"cherry", "apple", "blueberry"};

var match = wordsA.Execute<bool>("SequenceEqual(wordsB)", new {wordsB});

Console.WriteLine("The sequences match: {0}", match);
```
{% include component-try-it.html href='https://dotnetfiddle.net/Ahstcy' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The sequences match: True

```

## EqualAll - 2
This C# example uses the LINQ EqualAll method with a dynamic expression to see if two sequences match on all elements in the same order.

### LINQ
```csharp
var wordsA = new[] {"cherry", "apple", "blueberry"};
var wordsB = new[] {"apple", "blueberry", "cherry"};

var match = wordsA.SequenceEqual(wordsB);

Console.WriteLine("The sequences match: {0}", match);
```
{% include component-try-it.html href='https://dotnetfiddle.net/k3qskP' %}

### LINQ Execute
```csharp
var wordsA = new[] {"cherry", "apple", "blueberry"};
var wordsB = new[] {"apple", "blueberry", "cherry"};

var match = wordsA.Execute<bool>("SequenceEqual(wordsB)", new {wordsB});

Console.WriteLine("The sequences match: {0}", match);
```
{% include component-try-it.html href='https://dotnetfiddle.net/WK4OED' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The sequences match: False

```
