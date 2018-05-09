---
layout: default
title: LINQ Dynamic - Union
description: C# Dynamic LINQ Union examples using an Expression Evaluator.
permalink: linq-dynamic-union-examples
---

{% include template-h1.html %}

## LINQ Dynamic Union Examples
{{ page.description }}

- [Union - 1](#where---1)
- [Union - 2](#where---2)

## Union - 1
This C# example uses the LINQ Union method with a dynamic expression to create one sequence that contains the unique values from both arrays.

### LINQ
{% highlight csharp %}
private void uiUnion_1_LINQ_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var uniqueNumbers = numbersA.Union(numbersB);

	var sb = new StringBuilder();

	sb.AppendLine("Unique numbers from both arrays:");
		foreach (var n in uniqueNumbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiUnion_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var uniqueNumbers = numbersA.Execute<IEnumerable<int>>("Union(numbersB)", new {numbersB});

	var sb = new StringBuilder();

	sb.AppendLine("Unique numbers from both arrays:");
		foreach (var n in uniqueNumbers)
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
Unique numbers from both arrays:
0
2
4
5
6
8
9
1
3
7

{% endhighlight %}

## Union - 2
This C# example uses the LINQ Union method with a dynamic expression to create one sequence that contains the unique first letter from both product and customer names.

### LINQ
{% highlight csharp %}
private void uiUnion_2_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();
	var customers = My.GetCustomerList();

	var productFirstChars = from p in products select p.ProductName[0];
	var customerFirstChars = from c in customers select c.CompanyName[0];

	var uniqueFirstChars = productFirstChars.Union(customerFirstChars);

	var sb = new StringBuilder();

	sb.AppendLine("Unique first letters from Product names and Customer names:");
		foreach (var ch in uniqueFirstChars)
		{
			sb.AppendLine(ch.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiUnion_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();
	var customers = My.GetCustomerList();

	var productFirstChars = from p in products select p.ProductName[0];
	var customerFirstChars = from c in customers select c.CompanyName[0];

	var uniqueFirstChars = productFirstChars.Execute<IEnumerable<char>>("Union(customerFirstChars)", new {customerFirstChars});

	var sb = new StringBuilder();

	sb.AppendLine("Unique first letters from Product names and Customer names:");
		foreach (var ch in uniqueFirstChars)
		{
			sb.AppendLine(ch.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Unique first letters from Product names and Customer names:
C
A
G
U
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
J
Z
V
F
E
W
L
O
D
H

{% endhighlight %}
