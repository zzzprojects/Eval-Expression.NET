# LINQ Dynamic - Intersect

## LINQ Dynamic Intersect Examples
{{ page.description }}

- [Intersect - 1](#intersect---1)
- [Intersect - 2](#intersect---2)

## Intersect - 1
This C# example uses the LINQ Intersect method with a dynamic expression to create one sequence that contains the common first letter from both product and customer names.
### LINQ
```csharp
private void uiIntersect_1_LINQ_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var commonNumbers = numbersA.Intersect(numbersB);

	var sb = new StringBuilder();

	sb.AppendLine("Common numbers shared by both arrays:");
		foreach (var n in commonNumbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiIntersect_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var commonNumbers = numbersA.Execute<IEnumerable<int>>("Intersect(numbersB)", new {numbersB});

	var sb = new StringBuilder();

	sb.AppendLine("Common numbers shared by both arrays:");
		foreach (var n in commonNumbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Common numbers shared by both arrays:
5
8

```

## Intersect - 2
This C# example uses the LINQ Intersect method with a dynamic expression to find all products that are out of stock.

### LINQ
```csharp
private void uiIntersect_2_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();
	var customers = My.GetCustomerList();

	var productFirstChars = from p in products select p.ProductName[0];
	var customerFirstChars = from c in customers select c.CompanyName[0];

	var commonFirstChars = productFirstChars.Intersect(customerFirstChars);

	var sb = new StringBuilder();

	sb.AppendLine("Common first letters from Product names and Customer names:");
		foreach (var ch in commonFirstChars)
		{
			sb.AppendLine(ch.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiIntersect_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();
	var customers = My.GetCustomerList();

	var productFirstChars = from p in products select p.ProductName[0];
	var customerFirstChars = from c in customers select c.CompanyName[0];

	var commonFirstChars = productFirstChars.Execute<IEnumerable<char>>("Intersect(customerFirstChars)", new {customerFirstChars});

	var sb = new StringBuilder();

	sb.AppendLine("Common first letters from Product names and Customer names:");
		foreach (var ch in commonFirstChars)
		{
			sb.AppendLine(ch.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Common first letters from Product names and Customer names:
C
A
G
N
M
I
Q
K
T
P
S
R
B
V
F
E
W
L
O

```
