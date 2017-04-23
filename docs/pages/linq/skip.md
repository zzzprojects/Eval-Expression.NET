---
layout: default
title: LINQ Dynamic - Skip
description: C# Dynamic LINQ Skip examples using an Expression Evaluator.
permalink: linq-dynamic-skip-examples
---

{% include template-h1.html %}

## LINQ Dynamic Skip Examples
{{ page.description }}

- [Skip - Simple](#skip---simple)
- [Skip - Nested](#skip---nested)

## Skip - Simple
This C# example uses the LINQ Skip method with a dynamic expression to get all but the first 4 elements of the array.

### LINQ
{% highlight csharp %}
private void uiSkip_Simple_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var allButFirst4Numbers = numbers.Skip(4);

	var sb = new StringBuilder();

	sb.AppendLine("All but first 4 numbers:");
		foreach (var n in allButFirst4Numbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSkip_Simple_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var allButFirst4Numbers = numbers.Execute<IEnumerable<int>>("Skip(4)");

	var sb = new StringBuilder();

	sb.AppendLine("All but first 4 numbers:");
		foreach (var n in allButFirst4Numbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
All but first 4 numbers: 
9 
8 
6 
7 
2 
0

{% endhighlight %}

## Skip - Nested
This C# example uses the LINQ Skip method with a dynamic expression to get all but the first 2 orders from customers in Washington.

### LINQ
{% highlight csharp %}
private void uiSkip_Nested_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var waOrders =
		from c in customers
		from o in c.Orders
		where c.Region == "WA"
		select new {c.CustomerID, o.OrderID, o.OrderDate};

	 var allButFirst2Orders = waOrders.Skip(2);

	var sb = new StringBuilder();

	sb.AppendLine("All but first 2 orders in WA:");
		foreach (var order in allButFirst2Orders)
		{
			My.ObjectDumper.Write(sb, order);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSkip_Nested_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var waOrders =
		from c in customers
		from o in c.Orders
		where c.Region == "WA"
		select new { c.CustomerID, o.OrderID, o.OrderDate };

	dynamic allButFirst2Orders = waOrders.Execute("Skip(2)");

	var sb = new StringBuilder();

	sb.AppendLine("All but first 2 orders in WA:");
		foreach (var order in allButFirst2Orders)
		{
			My.ObjectDumper.Write(sb, order);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
All but first 2 orders in WA:
CustomerID=TRAIH OrderID=10574 OrderDate=6/19/1997
CustomerID=TRAIH OrderID=10577 OrderDate=6/23/1997
CustomerID=TRAIH OrderID=10822 OrderDate=1/8/1998
CustomerID=WHITC OrderID=10269 OrderDate=7/31/1996
CustomerID=WHITC OrderID=10344 OrderDate=11/1/1996
CustomerID=WHITC OrderID=10469 OrderDate=3/10/1997
CustomerID=WHITC OrderID=10483 OrderDate=3/24/1997
CustomerID=WHITC OrderID=10504 OrderDate=4/11/1997
CustomerID=WHITC OrderID=10596 OrderDate=7/11/1997
CustomerID=WHITC OrderID=10693 OrderDate=10/6/1997
CustomerID=WHITC OrderID=10696 OrderDate=10/8/1997
CustomerID=WHITC OrderID=10723 OrderDate=10/30/1997
CustomerID=WHITC OrderID=10740 OrderDate=11/13/1997
CustomerID=WHITC OrderID=10861 OrderDate=1/30/1998
CustomerID=WHITC OrderID=10904 OrderDate=2/24/1998
CustomerID=WHITC OrderID=11032 OrderDate=4/17/1998
CustomerID=WHITC OrderID=11066 OrderDate=5/1/1998

{% endhighlight %}
