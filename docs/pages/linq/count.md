---
layout: default
title: LINQ Dynamic - Count
description: C# Dynamic LINQ Count examples using an Expression Evaluator.
permalink: linq-dynamic-count-examples
---

{% include template-h1.html %}

## LINQ Dynamic Count Examples
{{ page.description }}

- [Count - Simple](#count---simple)
- [Count - Conditional](#count---conditional)
- [Count - Nested](#count---nested)
- [Count - Grouped](#count---grouped)

## Count - Simple
This C# example uses the LINQ Count method with a dynamic expression to get the number of unique factors of 300.

### LINQ
{% highlight csharp %}
private void uiCount_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] factorsOf300 = {2, 2, 3, 5, 5};

	var uniqueFactors = factorsOf300.Distinct().Count();

	var sb = new StringBuilder();

	sb.AppendLine("There are {0} unique factors of 300.", uniqueFactors);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiCount_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] factorsOf300 = {2, 2, 3, 5, 5};

	var uniqueFactors = factorsOf300.Distinct().Execute<int>("Count()");

	var sb = new StringBuilder();

	sb.AppendLine("There are {0} unique factors of 300.", uniqueFactors);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
There are 3 unique factors of 300.

{% endhighlight %}

## Count - Conditional
This C# example uses the LINQ Count method with a dynamic expression to get the number of odd ints in the array.

### LINQ
{% highlight csharp %}
private void uiCount_Conditional_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var oddNumbers = numbers.Count(n => n % 2 == 1);

	var sb = new StringBuilder();

	sb.AppendLine("There are {0} odd numbers in the list.", oddNumbers);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiCount_Conditional_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var oddNumbers = numbers.Count(n => "n % 2 == 1");

	var sb = new StringBuilder();

	sb.AppendLine("There are {0} odd numbers in the list.", oddNumbers);

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiCount_Conditional_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var oddNumbers = numbers.Execute<int>("Count(n => n % 2 == 1)");

	var sb = new StringBuilder();

	sb.AppendLine("There are {0} odd numbers in the list.", oddNumbers);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
There are 5 odd numbers in the list.

{% endhighlight %}

## Count - Nested
This C# example uses the LINQ Count method with a dynamic expression to return a list of customers and how many orders each has.

### LINQ
{% highlight csharp %}
private void uiCount_Nested_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orderCounts = customers.Select(c => new {c.CustomerID, OrderCount = c.Orders.Count()});

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, orderCounts);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiCount_Nested_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orderCounts = customers.Execute("Select(c => new { c.CustomerID, OrderCount = c.Orders.Count() })");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, orderCounts);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
CustomerID=ALFKI 
CustomerID=ANATR 
CustomerID=ANTON 
CustomerID=AROUT 
CustomerID=BERGS 
CustomerID=BLAUS 
CustomerID=BLONP 
CustomerID=BOLID 
CustomerID=BONAP 
CustomerID=BOTTM 
CustomerID=BSBEV 
CustomerID=CACTU 
CustomerID=CENTC 
CustomerID=CHOPS 
CustomerID=COMMI 
CustomerID=CONSH 
CustomerID=DRACD 
CustomerID=DUMON 
CustomerID=EASTC 
CustomerID=ERNSH 
CustomerID=FAMIA 
CustomerID=FISSA 
CustomerID=FOLIG 
CustomerID=FOLKO 
CustomerID=FRANK 
CustomerID=FRANR 
CustomerID=FRANS 
CustomerID=FURIB 
CustomerID=GALED 
CustomerID=GODOS 
CustomerID=GOURL 
CustomerID=GREAL 
CustomerID=GROSR 
CustomerID=HANAR 
CustomerID=HILAA 
CustomerID=HUNGC 
CustomerID=HUNGO 
CustomerID=ISLAT 
CustomerID=KOENE 
CustomerID=LACOR 
CustomerID=LAMAI 
CustomerID=LAUGB 
CustomerID=LAZYK 
CustomerID=LEHMS 
CustomerID=LETSS 
CustomerID=LILAS 
CustomerID=LINOD 
CustomerID=LONEP 
CustomerID=MAGAA 
CustomerID=MAISD 
CustomerID=MEREP 
CustomerID=MORGK 
CustomerID=NORTS 
CustomerID=OCEAN 
CustomerID=OLDWO 
CustomerID=OTTIK 
CustomerID=PARIS 
CustomerID=PERIC 
CustomerID=PICCO 
CustomerID=PRINI 
CustomerID=QUEDE 
CustomerID=QUEEN 
CustomerID=QUICK 
CustomerID=RANCH 
CustomerID=RATTC 
CustomerID=REGGC 
CustomerID=RICAR 
CustomerID=RICSU 
CustomerID=ROMEY 
CustomerID=SANTG 
CustomerID=SAVEA 
CustomerID=SEVES 
CustomerID=SIMOB 
CustomerID=SPECD 
CustomerID=SPLIR 
CustomerID=SUPRD 
CustomerID=THEBI 
CustomerID=THECR 
CustomerID=TOMSP 
CustomerID=TORTU 
CustomerID=TRADH 
CustomerID=TRAIH 
CustomerID=VAFFE 
CustomerID=VICTE 
CustomerID=VINET 
CustomerID=WANDK 
CustomerID=WARTH 
CustomerID=WELLI 
CustomerID=WHITC 
CustomerID=WILMK 
CustomerID=WOLZA	OrderCount=6 
OrderCount=4 
OrderCount=7 
OrderCount=13 
OrderCount=18 
OrderCount=7 
OrderCount=11 
OrderCount=3 
OrderCount=17 
OrderCount=14 
OrderCount=10 
OrderCount=6 
OrderCount=1 
OrderCount=8 
OrderCount=5 
OrderCount=3 
OrderCount=6 
OrderCount=4 
OrderCount=8 
OrderCount=30 
OrderCount=7 
OrderCount=0 
OrderCount=5 
OrderCount=19 
OrderCount=15 
OrderCount=3 
OrderCount=6 
OrderCount=8 
OrderCount=5 
OrderCount=10 
OrderCount=9 
OrderCount=11 
OrderCount=2 
OrderCount=14 
OrderCount=18 
OrderCount=5 
OrderCount=19 
OrderCount=10 
OrderCount=14 
OrderCount=4 
OrderCount=14 
OrderCount=3 
OrderCount=2 
OrderCount=15 
OrderCount=4 
OrderCount=14 
OrderCount=12 
OrderCount=8 
OrderCount=10 
OrderCount=7 
OrderCount=13 
OrderCount=5 
OrderCount=3 
OrderCount=5 
OrderCount=10 
OrderCount=9 
OrderCount=0 
OrderCount=6 
OrderCount=10 
OrderCount=6 
OrderCount=9 
OrderCount=13 
OrderCount=28 
OrderCount=5 
OrderCount=18 
OrderCount=12 
OrderCount=11 
OrderCount=10 
OrderCount=5 
OrderCount=6 
OrderCount=31 
OrderCount=9 
OrderCount=7 
OrderCount=4 
OrderCount=9 
OrderCount=12 
OrderCount=4 
OrderCount=3 
OrderCount=5 
OrderCount=10 
OrderCount=7 
OrderCount=3 
OrderCount=11 
OrderCount=10 
OrderCount=4 
OrderCount=10 
OrderCount=15 
OrderCount=9 
OrderCount=14 
OrderCount=8 
OrderCount=7

{% endhighlight %}

## Count - Grouped
This C# example uses the LINQ Count method with a dynamic expression to return a list of categories and how many products each has.

### LINQ
{% highlight csharp %}
private void uiCount_Grouped_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categoryCounts = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, ProductCount = g.Count()});

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categoryCounts);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiCount_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var categoryCounts = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() })");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, categoryCounts);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

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
Category=Grains/Cereals	ProductCount=12 
ProductCount=12 
ProductCount=5 
ProductCount=6 
ProductCount=12 
ProductCount=10 
ProductCount=13 
ProductCount=7

{% endhighlight %}
