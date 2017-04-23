---
layout: default
title: LINQ Dynamic - Select
description: C# Dynamic LINQ Select examples using an Expression Evaluator.
permalink: linq-dynamic-select-examples
---

{% include template-h1.html %}

## LINQ Dynamic Select Examples
{{ page.description }}

- [Select - Simple 1](#select---simple-1)
- [Select - Simple 2](#select---simple-2)
- [Select - Transformation](#select---transformation)
- [Select - Anonymous Type 1](#select---anonymous-type-1)
- [Select - Anonymous Type 2](#select---anonymous-type-2)
- [Select - Anonymous Type 3](#select---anonymous-type-3)
- [Select - Indexed](#select---indexed)
- [Select - Filtered](#select---filtered)

## Select - Simple 1
This C# example uses the LINQ Select method with a dynamic expression to produce a sequence of ints one higher than those in an existing array of ints.

### LINQ
{% highlight csharp %}
private void uiSelect_Simple_1_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var numsPlusOne = numbers.Select(n => n + 1);

	var sb = new StringBuilder();

	sb.AppendLine("Numbers + 1:");
		foreach (var i in numsPlusOne)
		{
			sb.AppendLine(i.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var numsPlusOne = numbers.SelectDynamic(n => "n + 1");

	var sb = new StringBuilder();

	sb.AppendLine("Numbers + 1:");
		foreach (var i in numsPlusOne)
		{
			sb.AppendLine(i.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var numsPlusOne = numbers.Execute<IEnumerable<int>>("Select(n => n +1)");

	var sb = new StringBuilder();

	sb.AppendLine("Numbers + 1:");
		foreach (var i in numsPlusOne)
		{
			sb.AppendLine(i.ToString());
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Numbers + 1:
6
5
2
4
10
9
7
8
3
1
{% endhighlight %}

## Select - Simple 2
This C# example uses the LINQ Select method with a dynamic expression to produce a sequence of just the names of a list of products.

### LINQ
{% highlight csharp %}
private void uiSelect_Simple_2_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var productNames = products.Select(p => p.ProductName);

	var sb = new StringBuilder();

	sb.AppendLine("Product Names:");
		foreach (var productName in productNames)
		{
			sb.AppendLine(productName);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var productNames = (IEnumerable<string>) products.SelectDynamic(x => "x.ProductName");

	var sb = new StringBuilder();

	sb.AppendLine("Product Names:");
		foreach (var productName in productNames)
		{
			sb.AppendLine(productName);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var productNames = products.Execute<IEnumerable<string>>("Select(p => p.ProductName)");

	var sb = new StringBuilder();

	sb.AppendLine("Product Names:");
		foreach (var productName in productNames)
		{
			sb.AppendLine(productName);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Product Names:
Chai
Chang
Aniseed Syrup
Chef Anton's Cajun Seasoning
Chef Anton's Gumbo Mix
Grandma's Boysenberry Spread
Uncle Bob's Organic Dried Pears
Northwoods Cranberry Sauce
Mishi Kobe Niku
Ikura
Queso Cabrales
Queso Manchego La Pastora
Konbu
Tofu
Genen Shouyu
Pavlova
Alice Mutton
Carnarvon Tigers
Teatime Chocolate Biscuits
Sir Rodney's Marmalade
Sir Rodney's Scones
Gustaf's KnÃ¤ckebrÃ¶d
TunnbrÃ¶d
GuaranÃ¡ FantÃ¡stica
NuNuCa NuÃŸ-Nougat-Creme
GumbÃ¤r GummibÃ¤rchen
Schoggi Schokolade
RÃ¶ssle Sauerkraut
ThÃ¼ringer Rostbratwurst
Nord-Ost Matjeshering
Gorgonzola Telino
Mascarpone Fabioli
Geitost
Sasquatch Ale
Steeleye Stout
Inlagd Sill
Gravad lax
CÃ´te de Blaye
Chartreuse verte
Boston Crab Meat
Jack's New England Clam Chowder
Singaporean Hokkien Fried Mee
Ipoh Coffee
Gula Malacca
Rogede sild
Spegesild
Zaanse koeken
Chocolade
Maxilaku
Valkoinen suklaa
Manjimup Dried Apples
Filo Mix
Perth Pasties
TourtiÃ¨re
PÃ¢tÃ© chinois
Gnocchi di nonna Alice
Ravioli Angelo
Escargots de Bourgogne
Raclette Courdavault
Camembert Pierrot
Sirop d'Ã©rable
Tarte au sucre
Vegie-spread
Wimmers gute SemmelknÃ¶del
Louisiana Fiery Hot Pepper Sauce
Louisiana Hot Spiced Okra
Laughing Lumberjack Lager
Scottish Longbreads
Gudbrandsdalsost
Outback Lager
Flotemysost
Mozzarella di Giovanni
RÃ¶d Kaviar
Longlife Tofu
RhÃ¶nbrÃ¤u Klosterbier
LakkalikÃ¶Ã¶ri
Original Frankfurter grÃ¼ne SoÃŸe

{% endhighlight %}

## Select - Transformation
This C# example uses the LINQ Select method with a dynamic expression to produce a sequence of strings representing the text version of a sequence of ints.

### LINQ
{% highlight csharp %}
private void uiSelect_Transformation_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var sb = new StringBuilder();
	var textNums = numbers.Select(n => strings[n]);

	sb.AppendLine("Number strings:");
		foreach (var s in textNums)
		{
			sb.AppendLine(s);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Transformation_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var sb = new StringBuilder();
	var textNums = (IEnumerable<string>) numbers.SelectDynamic(n => "strings[n]", new {strings});

	sb.AppendLine("Number strings:");
		foreach (var s in textNums)
		{
			sb.AppendLine(s);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Transformation_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var sb = new StringBuilder();
	var textNums = numbers.Execute<IEnumerable<string>>("Select(n => strings[n])", new {strings});

	sb.AppendLine("Number strings:");
		foreach (var s in textNums)
		{
			sb.AppendLine(s);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Number strings:
five
four
one
three
nine
eight
six
seven
two
zero

{% endhighlight %}

## Select - Anonymous Types 1
This C# example uses the LINQ Select method with a dynamic expression to produce a sequence of the uppercase and lowercase versions of each word in the original array.

### LINQ
{% highlight csharp %}
private void uiSelect_Anonymous_1_LINQ_Click(object sender, EventArgs e)
{
	string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};

	var upperLowerWords = words.Select(word => new {Upper = word.ToUpper(), Lower = word.ToLower()});

	var sb = new StringBuilder();

		foreach (var ul in upperLowerWords)
		{
			sb.AppendLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Anonymous_1_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};

	dynamic upperLowerWords = words.SelectDynamic(word => "new { Upper = word.ToUpper(), Lower = word.ToLower() }");

	var sb = new StringBuilder();

		foreach (var ul in upperLowerWords)
		{
			sb.AppendLine("Uppercase: {0}, Lowercase: {1}", (object)ul.Upper, (object)ul.Lower);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Anonymous_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};

	dynamic upperLowerWords = words.Execute("Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() })");

	var sb = new StringBuilder();

		foreach (var ul in upperLowerWords)
		{
			sb.AppendLine("Uppercase: {0}, Lowercase: {1}", (object)ul.Upper, (object)ul.Lower);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Uppercase: APPLE, Lowercase: apple
Uppercase: BLUEBERRY, Lowercase: blueberry
Uppercase: CHERRY, Lowercase: cherry

{% endhighlight %}

## Select - Anonymous Types 2
This C# example uses the LINQ Select method to produce a sequence containing text representations of digits and whether their length is even or odd.

### LINQ
{% highlight csharp %}
private void uiSelect_Anonymous_2_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
	string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var digitOddEvens = numbers.Select(n => new {Digit = strings[n], Even = n % 2 == 0});

	var sb = new StringBuilder();

		foreach (var d in digitOddEvens)
		{
			sb.AppendLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Anonymous_2_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
	string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	dynamic digitOddEvens = numbers.SelectDynamic(n => "new { Digit = strings[n], Even = (n % 2 == 0) }", new {strings});

	var sb = new StringBuilder();

		foreach (var d in digitOddEvens)
		{
			sb.AppendLine("The digit {0} is {1}.", (object)d.Digit, d.Even ? "even" : "odd");
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Anonymous_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
	string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	dynamic digitOddEvens = numbers.Execute("Select(n => new { Digit = strings[n], Even = (n % 2 == 0) })", new { strings });

	var sb = new StringBuilder();

		foreach (var d in digitOddEvens)
		{
			sb.AppendLine("The digit {0} is {1}.", (object)d.Digit, d.Even ? "even" : "odd");
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The digit five is odd.
The digit four is even.
The digit one is odd.
The digit three is odd.
The digit nine is odd.
The digit eight is even.
The digit six is even.
The digit seven is odd.
The digit two is even.
The digit zero is even.

{% endhighlight %}

## Select - Anonymous Types 3
This C# example uses the LINQ Select method to produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

### LINQ
{% highlight csharp %}
private void uiSelect_Anonymous_3_LINQ_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	var productInfos = products.Select(p => new {p.ProductName, p.Category, Price = p.UnitPrice});

	var sb = new StringBuilder();

	sb.AppendLine("Product Info:");
		foreach (var productInfo in productInfos)
		{
			sb.AppendLine("{0} is in the category {1} and costs {2} per unit.", productInfo.ProductName, productInfo.Category, productInfo.Price);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Anonymous_3_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	dynamic productInfos = products.SelectDynamic(p => "new { p.ProductName, p.Category, Price = p.UnitPrice }");

	var sb = new StringBuilder();

	sb.AppendLine("Product Info:");
		foreach (var productInfo in productInfos)
		{
			sb.AppendLine("{0} is in the category {1} and costs {2} per unit.", (object)productInfo.ProductName, (object)productInfo.Category, (object)productInfo.Price);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Anonymous_3_LINQ_Execute_Click(object sender, EventArgs e)
{
	var products = My.GetProductList();

	dynamic productInfos = products.Execute("Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice })");

	var sb = new StringBuilder();

	sb.AppendLine("Product Info:");
		foreach (var productInfo in productInfos)
		{
			sb.AppendLine("{0} is in the category {1} and costs {2} per unit.", (object)productInfo.ProductName, (object)productInfo.Category, (object)productInfo.Price);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Product Info:
Chai is in the category Beverages and costs 18.0000 per unit.
Chang is in the category Beverages and costs 19.0000 per unit.
Aniseed Syrup is in the category Condiments and costs 10.0000 per unit.
Chef Anton's Cajun Seasoning is in the category Condiments and costs 22.0000 per unit.
Chef Anton's Gumbo Mix is in the category Condiments and costs 21.3500 per unit.
Grandma's Boysenberry Spread is in the category Condiments and costs 25.0000 per unit.
Uncle Bob's Organic Dried Pears is in the category Produce and costs 30.0000 per unit.
Northwoods Cranberry Sauce is in the category Condiments and costs 40.0000 per unit.
Mishi Kobe Niku is in the category Meat/Poultry and costs 97.0000 per unit.
Ikura is in the category Seafood and costs 31.0000 per unit.
Queso Cabrales is in the category Dairy Products and costs 21.0000 per unit.
Queso Manchego La Pastora is in the category Dairy Products and costs 38.0000 per unit.
Konbu is in the category Seafood and costs 6.0000 per unit.
Tofu is in the category Produce and costs 23.2500 per unit.
Genen Shouyu is in the category Condiments and costs 15.5000 per unit.
Pavlova is in the category Confections and costs 17.4500 per unit.
Alice Mutton is in the category Meat/Poultry and costs 39.0000 per unit.
Carnarvon Tigers is in the category Seafood and costs 62.5000 per unit.
Teatime Chocolate Biscuits is in the category Confections and costs 9.2000 per unit.
Sir Rodney's Marmalade is in the category Confections and costs 81.0000 per unit.
Sir Rodney's Scones is in the category Confections and costs 10.0000 per unit.
Gustaf's KnÃ¤ckebrÃ¶d is in the category Grains/Cereals and costs 21.0000 per unit.
TunnbrÃ¶d is in the category Grains/Cereals and costs 9.0000 per unit.
GuaranÃ¡ FantÃ¡stica is in the category Beverages and costs 4.5000 per unit.
NuNuCa NuÃŸ-Nougat-Creme is in the category Confections and costs 14.0000 per unit.
GumbÃ¤r GummibÃ¤rchen is in the category Confections and costs 31.2300 per unit.
Schoggi Schokolade is in the category Confections and costs 43.9000 per unit.
RÃ¶ssle Sauerkraut is in the category Produce and costs 45.6000 per unit.
ThÃ¼ringer Rostbratwurst is in the category Meat/Poultry and costs 123.7900 per unit.
Nord-Ost Matjeshering is in the category Seafood and costs 25.8900 per unit.
Gorgonzola Telino is in the category Dairy Products and costs 12.5000 per unit.
Mascarpone Fabioli is in the category Dairy Products and costs 32.0000 per unit.
Geitost is in the category Dairy Products and costs 2.5000 per unit.
Sasquatch Ale is in the category Beverages and costs 14.0000 per unit.
Steeleye Stout is in the category Beverages and costs 18.0000 per unit.
Inlagd Sill is in the category Seafood and costs 19.0000 per unit.
Gravad lax is in the category Seafood and costs 26.0000 per unit.
CÃ´te de Blaye is in the category Beverages and costs 263.5000 per unit.
Chartreuse verte is in the category Beverages and costs 18.0000 per unit.
Boston Crab Meat is in the category Seafood and costs 18.4000 per unit.
Jack's New England Clam Chowder is in the category Seafood and costs 9.6500 per unit.
Singaporean Hokkien Fried Mee is in the category Grains/Cereals and costs 14.0000 per unit.
Ipoh Coffee is in the category Beverages and costs 46.0000 per unit.
Gula Malacca is in the category Condiments and costs 19.4500 per unit.
Rogede sild is in the category Seafood and costs 9.5000 per unit.
Spegesild is in the category Seafood and costs 12.0000 per unit.
Zaanse koeken is in the category Confections and costs 9.5000 per unit.
Chocolade is in the category Confections and costs 12.7500 per unit.
Maxilaku is in the category Confections and costs 20.0000 per unit.
Valkoinen suklaa is in the category Confections and costs 16.2500 per unit.
Manjimup Dried Apples is in the category Produce and costs 53.0000 per unit.
Filo Mix is in the category Grains/Cereals and costs 7.0000 per unit.
Perth Pasties is in the category Meat/Poultry and costs 32.8000 per unit.
TourtiÃ¨re is in the category Meat/Poultry and costs 7.4500 per unit.
PÃ¢tÃ© chinois is in the category Meat/Poultry and costs 24.0000 per unit.
Gnocchi di nonna Alice is in the category Grains/Cereals and costs 38.0000 per unit.
Ravioli Angelo is in the category Grains/Cereals and costs 19.5000 per unit.
Escargots de Bourgogne is in the category Seafood and costs 13.2500 per unit.
Raclette Courdavault is in the category Dairy Products and costs 55.0000 per unit.
Camembert Pierrot is in the category Dairy Products and costs 34.0000 per unit.
Sirop d'Ã©rable is in the category Condiments and costs 28.5000 per unit.
Tarte au sucre is in the category Confections and costs 49.3000 per unit.
Vegie-spread is in the category Condiments and costs 43.9000 per unit.
Wimmers gute SemmelknÃ¶del is in the category Grains/Cereals and costs 33.2500 per unit.
Louisiana Fiery Hot Pepper Sauce is in the category Condiments and costs 21.0500 per unit.
Louisiana Hot Spiced Okra is in the category Condiments and costs 17.0000 per unit.
Laughing Lumberjack Lager is in the category Beverages and costs 14.0000 per unit.
Scottish Longbreads is in the category Confections and costs 12.5000 per unit.
Gudbrandsdalsost is in the category Dairy Products and costs 36.0000 per unit.
Outback Lager is in the category Beverages and costs 15.0000 per unit.
Flotemysost is in the category Dairy Products and costs 21.5000 per unit.
Mozzarella di Giovanni is in the category Dairy Products and costs 34.8000 per unit.
RÃ¶d Kaviar is in the category Seafood and costs 15.0000 per unit.
Longlife Tofu is in the category Produce and costs 10.0000 per unit.
RhÃ¶nbrÃ¤u Klosterbier is in the category Beverages and costs 7.7500 per unit.
LakkalikÃ¶Ã¶ri is in the category Beverages and costs 18.0000 per unit.
Original Frankfurter grÃ¼ne SoÃŸe is in the category Condiments and costs 13.0000 per unit.

{% endhighlight %}

## Select - Indexed
This C# example uses the LINQ Indexed Select method to determine if the value of ints in an array match their position in the array.

### LINQ
{% highlight csharp %}
private void uiSelect_Indexed_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	var numsInPlace = numbers.Select((num, index) => new {Num = num, InPlace = num == index});

	var sb = new StringBuilder();

	sb.AppendLine("Number: In-place?");
		foreach (var n in numsInPlace)
		{
			sb.AppendLine("{0}: {1}", n.Num, n.InPlace);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	dynamic numsInPlace = numbers.SelectDynamic((num, index) => "new { Num = num, InPlace = (num == index) }");

	var sb = new StringBuilder();

	sb.AppendLine("Number: In-place?");
		foreach (var n in numsInPlace)
		{
			sb.AppendLine("{0}: {1}", (object)n.Num, (object)n.InPlace);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

	dynamic numsInPlace = numbers.Execute("Select((num, index) => new { Num = num, InPlace = (num == index) })");

	var sb = new StringBuilder();

	sb.AppendLine("Number: In-place?");
		foreach (var n in numsInPlace)
		{
			sb.AppendLine("{0}: {1}", (object)n.Num, (object)n.InPlace);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Number: In-place?
5: False
4: False
1: False
3: True
9: False
8: False
6: True
7: True
2: False
0: False

{% endhighlight %}

## Select - Filtered
This C# example uses the LINQ Indexed Select method to make a simple query that returns the text form of each digit less than 5.

### LINQ
{% highlight csharp %}
private void uiSelect_Filtered_LINQ_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
	string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var lowNums = numbers.Where(n => n < 5).Select(n => digits[n]);

	var sb = new StringBuilder();

	sb.AppendLine("Numbers < 5:");
		foreach (var num in lowNums)
		{
			sb.AppendLine(num);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Dynamic
{% highlight csharp %}
private void uiSelect_Filtered_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
	string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var lowNums = (IEnumerable<string>) numbers.Where(n => n < 5).SelectDynamic(n => "digits[n]", new {digits});

	var sb = new StringBuilder();

	sb.AppendLine("Numbers < 5:");
		foreach (var num in lowNums)
		{
			sb.AppendLine(num);
		}

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiSelect_Filtered_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
	string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

	var lowNums = numbers.Where(n => n < 5).Execute<IEnumerable<string>>("Select(n => digits[n])", new { digits });

	var sb = new StringBuilder();

	sb.AppendLine("Numbers < 5:");
		foreach (var num in lowNums)
		{
			sb.AppendLine(num);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Numbers < 5:
four
one
three
two
zero
{% endhighlight %}
