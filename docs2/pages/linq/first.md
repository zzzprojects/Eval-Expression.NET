# LINQ Dynamic - First

## LINQ Dynamic First Examples
{{ page.description }}

- [First - Simple](#first---simple)
- [First - Condition](#first---condition)

## First - Simple
This C# example uses the LINQ First method with a dynamic expression to find the first matching element as a Product, instead of as a sequence containing a Product.

### LINQ
```csharp
var products =getList();

var product = products.Where(p => p.ProductID == 12).First();

Console.WriteLine("ProductID : " + product.ProductID+ " ,ProductName : " + product.ProductName+ " ,Category : "+ product.Category+ " ,UnitPrice : "+ product.UnitPrice+" ,UnitsInStock : "+ product.UnitsInStock);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/klY7P0' %}

### LINQ Execute
```csharp
var products =getList();

var product = products.Where(p => p.ProductID == 12).Execute<Product>("First()");

Console.WriteLine("ProductID : " + product.ProductID+ " ,ProductName : " + product.ProductName+ " ,Category : "+ product.Category+ " ,UnitPrice : "+ product.UnitPrice+" ,UnitsInStock : "+ product.UnitsInStock);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/BOAG8x' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
ProductID=12 ProductName=Queso Manchego La Pastora Category=Dairy Products UnitPrice=38.0000 UnitsInStock=86

```

## First - Condition
This C# example uses the LINQ First method with a dynamic expression to find the first element in the array that starts with 'o'.

### LINQ
```csharp
private void uiFirst_Condition_LINQ_Click(object sender, EventArgs e)
string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

var startsWithO = strings.First(s => s[0] == 'o');

Console.WriteLine("A string starting with 'o': {0}", startsWithO);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/GjrQL8' %}

### LINQ Dynamic
```csharp
string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

var startsWithO = strings.First(s => "s[0] == 'o'");

Console.WriteLine("A string starting with 'o': {0}", startsWithO);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/B3H2GQ' %}

### LINQ Execute
```csharp
string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

var startsWithO =  strings.Execute<string>("First(s => s[0] == 'o')");

Console.WriteLine("A string starting with 'o': {0}", startsWithO);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/pqhtyM' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
A string starting with 'o': one

```
