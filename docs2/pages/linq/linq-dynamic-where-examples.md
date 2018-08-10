# LINQ Dynamic - Where

## LINQ Dynamic Where Examples
C# Dynamic LINQ Where examples using an Expression Evaluator.

- [Where - Simple 1](#where---simple-1)
- [Where - Simple 2](#where---simple-2)
- [Where - Simple 3](#where---simple-3)
- [Where - Drilldown](#where---drilldown)
- [Where - Indexed](#where---indexed)

## Where - Simple 1
This C# example uses the LINQ Where method with a dynamic expression to find all elements of an array less than 5.

### LINQ
```csharp
private void uiWhere_Simple_1_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var lowNums = numbers.Where(n => n < 5);

	var sb = new StringBuilder();

	sb.AppendLine("Numbers < 5:");
	foreach (var x in lowNums)
	{
		sb.AppendLine(x.ToString());
	}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}

```

### LINQ Dynamic
```csharp
private void uiWhere_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var lowNums = numbers.Where(n => "n < 5");

	var sb = new StringBuilder();

	sb.AppendLine("Numbers < 5:");
	foreach (var x in lowNums)
	{
		sb.AppendLine(x.ToString());
	}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiWhere_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var lowNums = numbers.Execute<IEnumerable<int>>("Where(n => n < 5)");

	var sb = new StringBuilder();

	sb.AppendLine("Numbers < 5:");
	foreach (var x in lowNums)
	{
		sb.AppendLine(x.ToString());
	}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Numbers < 5:
4
1
3
2
0
```


## Where - Simple 2
This C# example uses the LINQ Where method with a dynamic expression to find all products that are out of stock.

### LINQ
```csharp
private void uiWhere_Simple_2_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var soldOutProducts = products.Where(prod => prod.UnitsInStock == 0);

	var sb = new StringBuilder();

	sb.AppendLine("Sold out products:");
		foreach (var product in soldOutProducts)
		{
			sb.AppendLine("{0} is sold out!", product.ProductName);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiWhere_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var soldOutProducts = products.Where(prod => "prod.UnitsInStock == 0");

	var sb = new StringBuilder();

	sb.AppendLine("Sold out products:");
		foreach (var product in soldOutProducts)
		{
			sb.AppendLine("{0} is sold out!", product.ProductName);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiWhere_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var soldOutProducts = products.Execute<IEnumerable<My.Product>>("Where(prod => prod.UnitsInStock == 0)");

	var sb = new StringBuilder();

	sb.AppendLine("Sold out products:");
		foreach (var product in soldOutProducts)
		{
			sb.AppendLine("{0} is sold out!", product.ProductName);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Sold out products: 
Chef Anton's Gumbo Mix is sold out! 
Alice Mutton is sold out! 
ThÃ¼ringer Rostbratwurst is sold out! 
Gorgonzola Telino is sold out! 
Perth Pasties is sold out!

```

## Where - Simple 3
This C# example uses the LINQ Where method with a dynamic expression to find all products that are in stock and cost more than 3.00 per unit.

### LINQ
```csharp
private void uiWhere_Simple_3_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var expensiveInStockProducts = from prod in products where (prod.UnitsInStock > 0) && (prod.UnitPrice > 3.00M) select prod;

	var sb = new StringBuilder();

	sb.AppendLine("In-stock products that cost more than 3.00:");
		foreach (var product in expensiveInStockProducts)
		{
			sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiWhere_Simple_3_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var expensiveInStockProducts = products.Where(prod => "prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M");

	var sb = new StringBuilder();

	sb.AppendLine("In-stock products that cost more than 3.00:");
		foreach (var product in expensiveInStockProducts)
		{
			sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiWhere_Simple_3_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var expensiveInStockProducts = products.Execute<IEnumerable<My.Product>>("Where(prod => prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M)");

	var sb = new StringBuilder();

	sb.AppendLine("In-stock products that cost more than 3.00:");
		foreach (var product in expensiveInStockProducts)
		{
			sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
In-stock products that cost more than 3.00: 
Chai is in stock and costs more than 3.00. 
Chang is in stock and costs more than 3.00. 
Aniseed Syrup is in stock and costs more than 3.00. 
Chef Anton's Cajun Seasoning is in stock and costs more than 3.00. 
Grandma's Boysenberry Spread is in stock and costs more than 3.00. 
Uncle Bob's Organic Dried Pears is in stock and costs more than 3.00. 
Northwoods Cranberry Sauce is in stock and costs more than 3.00. 
Mishi Kobe Niku is in stock and costs more than 3.00. 
Ikura is in stock and costs more than 3.00. 
Queso Cabrales is in stock and costs more than 3.00. 
Queso Manchego La Pastora is in stock and costs more than 3.00. 
Konbu is in stock and costs more than 3.00. 
Tofu is in stock and costs more than 3.00. 
Genen Shouyu is in stock and costs more than 3.00. 
Pavlova is in stock and costs more than 3.00. 
Carnarvon Tigers is in stock and costs more than 3.00. 
Teatime Chocolate Biscuits is in stock and costs more than 3.00. 
Sir Rodney's Marmalade is in stock and costs more than 3.00. 
Sir Rodney's Scones is in stock and costs more than 3.00. 
Gustaf's KnÃ¤ckebrÃ¶d is in stock and costs more than 3.00. 
TunnbrÃ¶d is in stock and costs more than 3.00. 
GuaranÃ¡ FantÃ¡stica is in stock and costs more than 3.00. 
NuNuCa NuÃŸ-Nougat-Creme is in stock and costs more than 3.00. 
GumbÃ¤r GummibÃ¤rchen is in stock and costs more than 3.00. 
Schoggi Schokolade is in stock and costs more than 3.00. 
RÃ¶ssle Sauerkraut is in stock and costs more than 3.00. 
Nord-Ost Matjeshering is in stock and costs more than 3.00. 
Mascarpone Fabioli is in stock and costs more than 3.00. 
Sasquatch Ale is in stock and costs more than 3.00. 
Steeleye Stout is in stock and costs more than 3.00. 
Inlagd Sill is in stock and costs more than 3.00. 
Gravad lax is in stock and costs more than 3.00. 
CÃ´te de Blaye is in stock and costs more than 3.00. 
Chartreuse verte is in stock and costs more than 3.00. 
Boston Crab Meat is in stock and costs more than 3.00. 
Jack's New England Clam Chowder is in stock and costs more than 3.00. 
Singaporean Hokkien Fried Mee is in stock and costs more than 3.00. 
Ipoh Coffee is in stock and costs more than 3.00. 
Gula Malacca is in stock and costs more than 3.00. 
Rogede sild is in stock and costs more than 3.00. 
Spegesild is in stock and costs more than 3.00. 
Zaanse koeken is in stock and costs more than 3.00. 
Chocolade is in stock and costs more than 3.00. 
Maxilaku is in stock and costs more than 3.00. 
Valkoinen suklaa is in stock and costs more than 3.00. 
Manjimup Dried Apples is in stock and costs more than 3.00. 
Filo Mix is in stock and costs more than 3.00. 
TourtiÃ¨re is in stock and costs more than 3.00. 
PÃ¢tÃ© chinois is in stock and costs more than 3.00. 
Gnocchi di nonna Alice is in stock and costs more than 3.00. 
Ravioli Angelo is in stock and costs more than 3.00. 
Escargots de Bourgogne is in stock and costs more than 3.00.
Raclette Courdavault is in stock and costs more than 3.00. 
Camembert Pierrot is in stock and costs more than 3.00. 
Sirop d'Ã©rable is in stock and costs more than 3.00. 
Tarte au sucre is in stock and costs more than 3.00. 
Vegie-spread is in stock and costs more than 3.00. 
Wimmers gute SemmelknÃ¶del is in stock and costs more than 3.00. 
Louisiana Fiery Hot Pepper Sauce is in stock and costs more than 3.00. 
Louisiana Hot Spiced Okra is in stock and costs more than 3.00. 
Laughing Lumberjack Lager is in stock and costs more than 3.00. 
Scottish Longbreads is in stock and costs more than 3.00. 
Gudbrandsdalsost is in stock and costs more than 3.00. 
Outback Lager is in stock and costs more than 3.00. 
Flotemysost is in stock and costs more than 3.00. 
Mozzarella di Giovanni is in stock and costs more than 3.00. 
RÃ¶d Kaviar is in stock and costs more than 3.00. 
Longlife Tofu is in stock and costs more than 3.00. 
RhÃ¶nbrÃ¤u Klosterbier is in stock and costs more than 3.00. 
LakkalikÃ¶Ã¶ri is in stock and costs more than 3.00. 
Original Frankfurter grÃ¼ne SoÃŸe is in stock and costs more than 3.00.

```

## Where - Drilldown
This C# example uses the LINQ Where method with a dynamic expression to find all customers in Washington and then uses the resulting sequence to drill down into their orders.

### LINQ
```csharp
private void uiWhere_DrillDown_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var waCustomers = from cust in customers where cust.Region == "WA" select cust;

	var sb = new StringBuilder();

	sb.AppendLine("Customers from Washington and their orders:");
		foreach (var customer in waCustomers)
		{
			sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);

			foreach (var order in customer.Orders)
			{
				sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
			}
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiWhere_DrillDown_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var waCustomers = customers.Where(cust => "cust.Region == 'WA'");

	var sb = new StringBuilder();

	sb.AppendLine("Customers from Washington and their orders:");
		foreach (var customer in waCustomers)
		{
			sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);

			foreach (var order in customer.Orders)
			{
				sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
			}
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiWhere_DrillDown_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var waCustomers = customers.Execute<IEnumerable<My.Customer>>("Where(cust => cust.Region == 'WA')");

	var sb = new StringBuilder();

	sb.AppendLine("Customers from Washington and their orders:");
		foreach (var customer in waCustomers)
		{
			sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
			foreach (var order in customer.Orders)
			{
				sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
			}
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Customers from Washington and their orders: 
Customer LAZYK: Lazy K Kountry Store
Order 10482: 3/21/1997 12:00:00 AM
Order 10545: 5/22/1997 12:00:00 AM 
Customer TRAIH: Trail's Head Gourmet Provisioners
Order 10574: 6/19/1997 12:00:00 AM
Order 10577: 6/23/1997 12:00:00 AM
Order 10822: 1/8/1998 12:00:00 AM 
Customer WHITC: White Clover Markets
Order 10269: 7/31/1996 12:00:00 AM
Order 10344: 11/1/1996 12:00:00 AM
Order 10469: 3/10/1997 12:00:00 AM
Order 10483: 3/24/1997 12:00:00 AM
Order 10504: 4/11/1997 12:00:00 AM
Order 10596: 7/11/1997 12:00:00 AM
Order 10693: 10/6/1997 12:00:00 AM
Order 10696: 10/8/1997 12:00:00 AM
Order 10723: 10/30/1997 12:00:00 AM
Order 10740: 11/13/1997 12:00:00 AM
Order 10861: 1/30/1998 12:00:00 AM
Order 10904: 2/24/1998 12:00:00 AM
Order 11032: 4/17/1998 12:00:00 AM
Order 11066: 5/1/1998 12:00:00 AM

```

## Where - Indexed
This C# example uses the LINQ Indexed Where method to find all digits whose name is shorter than their value.

### LINQ
```csharp
private void uiWhere_Indexed_LINQ_Click(object sender, EventArgs e)
{
	string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var shortDigits = digits.Where((digit, index) => digit.Length < index);

	var sb = new StringBuilder();

	sb.AppendLine("Short digits:");
		foreach (var d in shortDigits)
		{
			sb.AppendLine("The word {0} is shorter than its value.", d);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiWhere_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var shortDigits = digits.Where((digit, index) => digit.Length < index);

	var sb = new StringBuilder();

	sb.AppendLine("Short digits:");
		foreach (var d in shortDigits)
		{
			sb.AppendLine("The word {0} is shorter than its value.", d);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiWhere_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var shortDigits = digits.Where((digit, index) => digit.Length < index);

	var sb = new StringBuilder();

	sb.AppendLine("Short digits:");
		foreach (var d in shortDigits)
		{
			sb.AppendLine("The word {0} is shorter than its value.", d);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Short digits: 
The word five is shorter than its value. 
The word six is shorter than its value. 
The word seven is shorter than its value. 
The word eight is shorter than its value. 
The word nine is shorter than its value.

```
