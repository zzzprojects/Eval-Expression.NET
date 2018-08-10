# LINQ Dynamic - Sum

## LINQ Dynamic Sum Examples
C# Dynamic LINQ Sum examples using an Expression Evaluator.

- [Sum - Simple](#sum---simple)
- [Sum - Projection](#sum---projection)
- [Sum - Grouped](#sum---grouped)

## Sum - Simple
This C# example uses the LINQ Sum method with a dynamic expression to get the total of the numbers in an array.

### LINQ
```csharp
private void uiSum_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	double numSum = numbers.Sum();

	var sb = new StringBuilder();

	sb.AppendLine("The sum of the numbers is {0}.", numSum);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSum_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var numSum = numbers.Execute<int>("Sum()");

	var sb = new StringBuilder();

	sb.AppendLine("The sum of the numbers is {0}.", numSum);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The sum of the numbers is 45.

```

## Sum - Projection
This C# example uses the LINQ Sum method with a dynamic expression to get the total number of characters of all words in the array.

### LINQ
```csharp
private void uiSum_Projection_LINQ_Click(object sender, EventArgs e)
{
	string[] words = {"cherry", "apple", "blueberry"};

	double totalChars = words.Sum(w => w.Length);

	var sb = new StringBuilder();

	sb.AppendLine("There are a total of {0} characters in these words.", totalChars);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSum_Projection_LINQ_Execute_Click(object sender, EventArgs e)
    {
        string[] words = {"cherry", "apple", "blueberry"};

        var totalChars = words.Execute<int>("Sum(w => w.Length)");

        var sb = new StringBuilder();

        sb.AppendLine("There are a total of {0} characters in these words.", totalChars);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
There are a total of 20 characters in these words.

```

## Sum - Grouped
This C# example uses the LINQ Sum method with a dynamic expression to get the total units in stock for each product category.

### LINQ
```csharp
private void uiSum_Grouped_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock)});

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categories); 

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSum_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) })");

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
Category=Grains/Cereals	TotalUnitsInStock=559 
TotalUnitsInStock=507 
TotalUnitsInStock=100 
TotalUnitsInStock=165 
TotalUnitsInStock=701 
TotalUnitsInStock=393 
TotalUnitsInStock=386 
TotalUnitsInStock=308

```
