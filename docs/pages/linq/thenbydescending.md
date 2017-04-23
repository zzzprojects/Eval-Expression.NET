---
layout: default
title: LINQ Dynamic - ThenByDescending
description: C# Dynamic LINQ ThenByDescending examples using an Expression Evaluator.
permalink: linq-dynamic-thenbydescending-examples
---

{% include template-h1.html %}


## LINQ Dynamic ThenByDescending Examples
{{ page.description }}

- [ThenByDescending - Simple](#thenbydescending---simple)
- [ThenByDescending - Comparer](#thenbydescending---comparer)

## ThenByDescending - Simple
This C# example uses the LINQ ThenByDescending method with a dynamic expression to sort a list of products, first by category, and then by unit price, from highest to lowest.

### LINQ
{% highlight csharp %}
private void uiThenByDescending_Simple_1_LINQ_Click(object sender, EventArgs e)
{
	List<My.Product> products = My.GetProductList();

	var sortedProducts = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedProducts);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiThenByDescending_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	List<My.Product> products = My.GetProductList();

	var sortedProducts = products.OrderBy(p => p.Category).ThenByDescendingDynamic(p => "p.UnitPrice");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedProducts);

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiThenByDescending_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	List<My.Product> products = My.GetProductList();

	var sortedProducts = products.OrderBy(p => p.Category).Execute<IEnumerable<My.Product>>("ThenByDescending(p => p.UnitPrice)");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedProducts);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
ProductID=38 ProductName=CÃ´te de Blaye Category=Beverages UnitPrice=263.5000 UnitsInStock=17
ProductID=43 ProductName=Ipoh Coffee Category=Beverages UnitPrice=46.0000 UnitsInStock=17
ProductID=2 ProductName=Chang Category=Beverages UnitPrice=19.0000 UnitsInStock=17
ProductID=1 ProductName=Chai Category=Beverages UnitPrice=18.0000 UnitsInStock=39
ProductID=35 ProductName=Steeleye Stout Category=Beverages UnitPrice=18.0000 UnitsInStock=20
ProductID=39 ProductName=Chartreuse verte Category=Beverages UnitPrice=18.0000 UnitsInStock=69
ProductID=76 ProductName=LakkalikÃ¶Ã¶ri Category=Beverages UnitPrice=18.0000 UnitsInStock=57
ProductID=70 ProductName=Outback Lager Category=Beverages UnitPrice=15.0000 UnitsInStock=15
ProductID=34 ProductName=Sasquatch Ale Category=Beverages UnitPrice=14.0000 UnitsInStock=111
ProductID=67 ProductName=Laughing Lumberjack Lager Category=Beverages UnitPrice=14.0000 UnitsInStock=52
ProductID=75 ProductName=RhÃ¶nbrÃ¤u Klosterbier Category=Beverages UnitPrice=7.7500 UnitsInStock=125
ProductID=24 ProductName=GuaranÃ¡ FantÃ¡stica Category=Beverages UnitPrice=4.5000 UnitsInStock=20
ProductID=63 ProductName=Vegie-spread Category=Condiments UnitPrice=43.9000 UnitsInStock=24
ProductID=8 ProductName=Northwoods Cranberry Sauce Category=Condiments UnitPrice=40.0000 UnitsInStock=6
ProductID=61 ProductName=Sirop d'Ã©rable Category=Condiments UnitPrice=28.5000 UnitsInStock=113
ProductID=6 ProductName=Grandma's Boysenberry Spread Category=Condiments UnitPrice=25.0000 UnitsInStock=120
ProductID=4 ProductName=Chef Anton's Cajun Seasoning Category=Condiments UnitPrice=22.0000 UnitsInStock=53
ProductID=5 ProductName=Chef Anton's Gumbo Mix Category=Condiments UnitPrice=21.3500 UnitsInStock=0
ProductID=65 ProductName=Louisiana Fiery Hot Pepper Sauce Category=Condiments UnitPrice=21.0500 UnitsInStock=76
ProductID=44 ProductName=Gula Malacca Category=Condiments UnitPrice=19.4500 UnitsInStock=27
ProductID=66 ProductName=Louisiana Hot Spiced Okra Category=Condiments UnitPrice=17.0000 UnitsInStock=4
ProductID=15 ProductName=Genen Shouyu Category=Condiments UnitPrice=15.5000 UnitsInStock=39
ProductID=77 ProductName=Original Frankfurter grÃ¼ne SoÃŸe Category=Condiments UnitPrice=13.0000 UnitsInStock=32
ProductID=3 ProductName=Aniseed Syrup Category=Condiments UnitPrice=10.0000 UnitsInStock=13
ProductID=20 ProductName=Sir Rodney's Marmalade Category=Confections UnitPrice=81.0000 UnitsInStock=40
ProductID=62 ProductName=Tarte au sucre Category=Confections UnitPrice=49.3000 UnitsInStock=17
ProductID=27 ProductName=Schoggi Schokolade Category=Confections UnitPrice=43.9000 UnitsInStock=49
ProductID=26 ProductName=GumbÃ¤r GummibÃ¤rchen Category=Confections UnitPrice=31.2300 UnitsInStock=15
ProductID=49 ProductName=Maxilaku Category=Confections UnitPrice=20.0000 UnitsInStock=10
ProductID=16 ProductName=Pavlova Category=Confections UnitPrice=17.4500 UnitsInStock=29
ProductID=50 ProductName=Valkoinen suklaa Category=Confections UnitPrice=16.2500 UnitsInStock=65
ProductID=25 ProductName=NuNuCa NuÃŸ-Nougat-Creme Category=Confections UnitPrice=14.0000 UnitsInStock=76
ProductID=48 ProductName=Chocolade Category=Confections UnitPrice=12.7500 UnitsInStock=15
ProductID=68 ProductName=Scottish Longbreads Category=Confections UnitPrice=12.5000 UnitsInStock=6
ProductID=21 ProductName=Sir Rodney's Scones Category=Confections UnitPrice=10.0000 UnitsInStock=3
ProductID=47 ProductName=Zaanse koeken Category=Confections UnitPrice=9.5000 UnitsInStock=36
ProductID=19 ProductName=Teatime Chocolate Biscuits Category=Confections UnitPrice=9.2000 UnitsInStock=25
ProductID=59 ProductName=Raclette Courdavault Category=Dairy Products UnitPrice=55.0000 UnitsInStock=79
ProductID=12 ProductName=Queso Manchego La Pastora Category=Dairy Products UnitPrice=38.0000 UnitsInStock=86
ProductID=69 ProductName=Gudbrandsdalsost Category=Dairy Products UnitPrice=36.0000 UnitsInStock=26
ProductID=72 ProductName=Mozzarella di Giovanni Category=Dairy Products UnitPrice=34.8000 UnitsInStock=14
ProductID=60 ProductName=Camembert Pierrot Category=Dairy Products UnitPrice=34.0000 UnitsInStock=19
ProductID=32 ProductName=Mascarpone Fabioli Category=Dairy Products UnitPrice=32.0000 UnitsInStock=9
ProductID=71 ProductName=Flotemysost Category=Dairy Products UnitPrice=21.5000 UnitsInStock=26
ProductID=11 ProductName=Queso Cabrales Category=Dairy Products UnitPrice=21.0000 UnitsInStock=22
ProductID=31 ProductName=Gorgonzola Telino Category=Dairy Products UnitPrice=12.5000 UnitsInStock=0
ProductID=33 ProductName=Geitost Category=Dairy Products UnitPrice=2.5000 UnitsInStock=112
ProductID=56 ProductName=Gnocchi di nonna Alice Category=Grains/Cereals UnitPrice=38.0000 UnitsInStock=21
ProductID=64 ProductName=Wimmers gute SemmelknÃ¶del Category=Grains/Cereals UnitPrice=33.2500 UnitsInStock=22
ProductID=22 ProductName=Gustaf's KnÃ¤ckebrÃ¶d Category=Grains/Cereals UnitPrice=21.0000 UnitsInStock=104
ProductID=57 ProductName=Ravioli Angelo Category=Grains/Cereals UnitPrice=19.5000 UnitsInStock=36
ProductID=42 ProductName=Singaporean Hokkien Fried Mee Category=Grains/Cereals UnitPrice=14.0000 UnitsInStock=26
ProductID=23 ProductName=TunnbrÃ¶d Category=Grains/Cereals UnitPrice=9.0000 UnitsInStock=61
ProductID=52 ProductName=Filo Mix Category=Grains/Cereals UnitPrice=7.0000 UnitsInStock=38
ProductID=29 ProductName=ThÃ¼ringer Rostbratwurst Category=Meat/Poultry UnitPrice=123.7900 UnitsInStock=0
ProductID=9 ProductName=Mishi Kobe Niku Category=Meat/Poultry UnitPrice=97.0000 UnitsInStock=29
ProductID=17 ProductName=Alice Mutton Category=Meat/Poultry UnitPrice=39.0000 UnitsInStock=0
ProductID=53 ProductName=Perth Pasties Category=Meat/Poultry UnitPrice=32.8000 UnitsInStock=0
ProductID=55 ProductName=PÃ¢tÃ© chinois Category=Meat/Poultry UnitPrice=24.0000 UnitsInStock=115
ProductID=54 ProductName=TourtiÃ¨re Category=Meat/Poultry UnitPrice=7.4500 UnitsInStock=21
ProductID=51 ProductName=Manjimup Dried Apples Category=Produce UnitPrice=53.0000 UnitsInStock=20
ProductID=28 ProductName=RÃ¶ssle Sauerkraut Category=Produce UnitPrice=45.6000 UnitsInStock=26
ProductID=7 ProductName=Uncle Bob's Organic Dried Pears Category=Produce UnitPrice=30.0000 UnitsInStock=15
ProductID=14 ProductName=Tofu Category=Produce UnitPrice=23.2500 UnitsInStock=35
ProductID=74 ProductName=Longlife Tofu Category=Produce UnitPrice=10.0000 UnitsInStock=4
ProductID=18 ProductName=Carnarvon Tigers Category=Seafood UnitPrice=62.5000 UnitsInStock=42
ProductID=10 ProductName=Ikura Category=Seafood UnitPrice=31.0000 UnitsInStock=31
ProductID=37 ProductName=Gravad lax Category=Seafood UnitPrice=26.0000 UnitsInStock=11
ProductID=30 ProductName=Nord-Ost Matjeshering Category=Seafood UnitPrice=25.8900 UnitsInStock=10
ProductID=36 ProductName=Inlagd Sill Category=Seafood UnitPrice=19.0000 UnitsInStock=112
ProductID=40 ProductName=Boston Crab Meat Category=Seafood UnitPrice=18.4000 UnitsInStock=123
ProductID=73 ProductName=RÃ¶d Kaviar Category=Seafood UnitPrice=15.0000 UnitsInStock=101
ProductID=58 ProductName=Escargots de Bourgogne Category=Seafood UnitPrice=13.2500 UnitsInStock=62
ProductID=46 ProductName=Spegesild Category=Seafood UnitPrice=12.0000 UnitsInStock=95
ProductID=41 ProductName=Jack's New England Clam Chowder Category=Seafood UnitPrice=9.6500 UnitsInStock=85
ProductID=45 ProductName=Rogede sild Category=Seafood UnitPrice=9.5000 UnitsInStock=5
ProductID=13 ProductName=Konbu Category=Seafood UnitPrice=6.0000 UnitsInStock=24

{% endhighlight %}

## ThenByDescending - Comparer
This C# example uses the LINQ ThenByDescending method with a dynamic expression and a custom comparer to sort first by word length and then by a case-insensitive descending sort of the words in an array.

### LINQ
{% highlight csharp %}
private void uiThenByDescending_Comparer_LINQ_Click(object sender, EventArgs e)
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

	var sortedWords = words.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedWords);

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiThenByDescending_Comparer_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

	var sortedWords = words.OrderBy(a => a.Length).ThenByDescendingDynamic(a => "a", new CaseInsensitiveComparer());

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedWords);

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiThenByDescending_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

	EvalManager.DefaultContext.RegisterType(typeof(CaseInsensitiveComparer));

	var sortedWords = words.OrderBy(a => a.Length).Execute<IEnumerable<string>>("ThenByDescending(a => a, new CaseInsensitiveComparer())");

	var sb = new StringBuilder();

	My.ObjectDumper.Write(sb, sortedWords);

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
aPPLE
ClOvEr
cHeRry
bRaNcH
AbAcUs
BlUeBeRrY

{% endhighlight %}
