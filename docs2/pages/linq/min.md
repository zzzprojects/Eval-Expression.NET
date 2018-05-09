# LINQ Dynamic - Min

## LINQ Dynamic Min Examples
{{ page.description }}

- [Min - Simple](#min---simple)
- [Min - Projection](#min---projection)
- [Min - Grouped](#min---grouped)
- [Min - Elements](#min---elements)

## Min - Simple
This C# example uses the LINQ Min method with a dynamic expression to get the lowest number in an array.

### LINQ
```csharp
private void uiMin_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var minNum = numbers.Min();

	var sb = new StringBuilder();

	sb.AppendLine("The minimum number is {0}.", minNum);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiMin_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var minNum = numbers.Execute<int>("Min()");

	var sb = new StringBuilder();

	sb.AppendLine("The minimum number is {0}.", minNum);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The minimum number is 0.

```

## Min - Projection
This C# example uses the LINQ Min method with a dynamic expression to get the length of the shortest word in an array.

### LINQ
```csharp
private void uiMin_Projection_LINQ_Click(object sender, EventArgs e)
{
	string[] words = {"cherry", "apple", "blueberry"};

	var shortestWord = words.Min(w => w.Length);

	var sb = new StringBuilder();

	sb.AppendLine("The shortest word is {0} characters long.", shortestWord);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiMin_Projection_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] words = {"cherry", "apple", "blueberry"};

	var shortestWord = words.Execute<int>("Min(w => w.Length)");

	var sb = new StringBuilder();

	sb.AppendLine("The shortest word is {0} characters long.", shortestWord);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The shortest word is 5 characters long.

```

## Min - Grouped
This C# example uses the LINQ Min method with a dynamic expression to get the cheapest price among each category's products.

### LINQ
```csharp
private void uiMin_Grouped_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice)});

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiMin_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) })");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Category=Beverages
Category=Condiments
Category=Produce
Category=Meat/Poultry
Category=Seafood
Category=Dairy Products
Category=Confections
Category=Grains/Cereals	CheapestPrice=4.5000
CheapestPrice=10.0000
CheapestPrice=10.0000
CheapestPrice=7.4500
CheapestPrice=6.0000
CheapestPrice=2.5000
CheapestPrice=9.2000
CheapestPrice=7.0000

```

## Min - Elements
This C# example uses the LINQ Min method with a dynamic expression to get the products with the cheapest price in each category.

### LINQ
```csharp
private void uiMin_Elements_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice))});

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories, 1);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiMin_Elements_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice)) })");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories, 1);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Category=Beverages      CheapestProducts=... 
  CheapestProducts: ProductID=24  ProductName=GuaranÃ¡ FantÃ¡stica  Category=Beverages      UnitPrice=4.5000        UnitsInStock=20 
Category=Condiments    CheapestProducts=... 
  CheapestProducts: ProductID=3  ProductName=Aniseed Syrup      Category=Condiments    UnitPrice=10.0000      UnitsInStock=13 
Category=Produce        CheapestProducts=... 
  CheapestProducts: ProductID=74  ProductName=Longlife Tofu      Category=Produce        UnitPrice=10.0000      UnitsInStock=4 
Category=Meat/Poultry  CheapestProducts=... 
  CheapestProducts: ProductID=54  ProductName=TourtiÃ¨re  Category=Meat/Poultry  UnitPrice=7.4500        UnitsInStock=21 
Category=Seafood        CheapestProducts=... 
  CheapestProducts: ProductID=13  ProductName=Konbu      Category=Seafood        UnitPrice=6.0000        UnitsInStock=24 
Category=Dairy Products        CheapestProducts=... 
  CheapestProducts: ProductID=33  ProductName=Geitost    Category=Dairy Products        UnitPrice=2.5000        UnitsInStock=112 
Category=Confections    CheapestProducts=... 
  CheapestProducts: ProductID=19  ProductName=Teatime Chocolate Biscuits  Category=Confections    UnitPrice=9.2000        UnitsInStock=25 
Category=Grains/Cereals        CheapestProducts=... 
  CheapestProducts: ProductID=52  ProductName=Filo Mix    Category=Grains/Cereals        UnitPrice=7.0000        UnitsInStock=38

```
