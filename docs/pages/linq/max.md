---
layout: default
title: LINQ Dynamic - Max
description: C# Dynamic LINQ Max examples using an Expression Evaluator.
permalink: linq-dynamic-max-examples
---

{% include template-h1.html %}

## LINQ Dynamic Max Examples
{{ page.description }}

- [Max - Simple](#max---simple)
- [Max - Projection](#max---projection)
- [Max - Grouped](#max---grouped)
- [Max - Elements](#max---elements)

## Max - Simple
This C# example uses the LINQ Max method with a dynamic expression to get the highest number in an array.

### LINQ
{% highlight csharp %}
private void uiMax_Simple_LINQ_Click(object sender, EventArgs e)
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var maxNum = numbers.Max();

        var sb = new StringBuilder();

        sb.AppendLine("The maximum number is {0}.", maxNum);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiMax_Simple_LINQ_Execute_Click(object sender, EventArgs e)
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var maxNum = numbers.Execute<int>("Max()");

        var sb = new StringBuilder();

        sb.AppendLine("The maximum number is {0}.", maxNum);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The maximum number is 9.

{% endhighlight %}

## Max - Projection
This C# example uses the LINQ Max method with a dynamic expression to get the length of the longest word in an array.

### LINQ
{% highlight csharp %}
private void uiMax_Projection_LINQ_Click(object sender, EventArgs e)
    {
        string[] words = {"cherry", "apple", "blueberry"};

        var longestLength = words.Max(w => w.Length);

        var sb = new StringBuilder();

        sb.AppendLine("The longest word is {0} characters long.", longestLength);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiMax_Projection_LINQ_Execute_Click(object sender, EventArgs e)
    {
        string[] words = {"cherry", "apple", "blueberry"};

        var longestLength = words.Execute<int>("Max(w => w.Length)");

        var sb = new StringBuilder();

        sb.AppendLine("The longest word is {0} characters long.", longestLength);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
The longest word is 9 characters long.

{% endhighlight %}

## Max - Grouped
This C# example uses the LINQ Max method with a dynamic expression to get the most expensive price among each category's products.

### LINQ
{% highlight csharp %}
private void uiMax_Grouped_LINQ_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice)});

        var sb = new StringBuilder();

        My.ObjectDumper.Write(sb, categories);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiMax_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) })");

        var sb = new StringBuilder();

        My.ObjectDumper.Write(sb, categories);

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
Category=Grains/Cereals	MostExpensivePrice=263.5000 
MostExpensivePrice=43.9000 
MostExpensivePrice=53.0000 
MostExpensivePrice=123.7900 
MostExpensivePrice=62.5000 
MostExpensivePrice=55.0000 
MostExpensivePrice=81.0000 
MostExpensivePrice=38.0000

{% endhighlight %}

## Max - Elements
This C# example uses the LINQ Max method with a dynamic expression to get the products with the most expensive price in each category.

### LINQ
{% highlight csharp %}
private void uiMax_Elements_LINQ_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var categories = products.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)) });

        var sb = new StringBuilder();

        My.ObjectDumper.Write(sb, categories, 1);

        My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
    }
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiMax_Elements_LINQ_Execute_Click(object sender, EventArgs e)
    {
        var products = My.GetProductList();

        var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)) })");

        var sb = new StringBuilder();

        My.ObjectDumper.Write(sb, categories, 1);

        My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
    }
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Category=Beverages      MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=38    ProductName=CÃ´te de Blaye      Category=Beverages      UnitPrice=263.5000      UnitsInStock=17 
Category=Condiments    MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=63    ProductName=Vegie-spread        Category=Condiments    UnitPrice=43.9000      UnitsInStock=24 
Category=Produce        MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=51    ProductName=Manjimup Dried Apples      Category=Produce        UnitPrice=53.0000      UnitsInStock=20 
Category=Meat/Poultry  MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=29    ProductName=ThÃ¼ringer Rostbratwurst    Category=Meat/Poultry  UnitPrice=123.7900      UnitsInStock=0 
Category=Seafood        MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=18    ProductName=Carnarvon Tigers    Category=Seafood        UnitPrice=62.5000      UnitsInStock=42 
Category=Dairy Products        MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=59    ProductName=Raclette Courdavault        Category=Dairy Products        UnitPrice=55.0000      UnitsInStock=79 
Category=Confections    MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=20    ProductName=Sir Rodney's Marmalade      Category=Confections    UnitPrice=81.0000      UnitsInStock=40 
Category=Grains/Cereals        MostExpensiveProducts=... 
  MostExpensiveProducts: ProductID=56    ProductName=Gnocchi di nonna Alice      Category=Grains/Cereals        UnitPrice=38.0000      UnitsInStock=21

{% endhighlight %}
