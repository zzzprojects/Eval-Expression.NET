---
layout: default
title: LINQ Dynamic - Concat
description: C# Dynamic LINQ Concat examples using an Expression Evaluator.
permalink: linq-dynamic-concat-examples
---

{% include template-h1.html %}

## LINQ Dynamic Concat Examples
{{ page.description }}

- [Concat - 1](#concat---1)
- [Concat - 2](#concat---2)

## Concat - 1
This C# example uses the LINQ Concat method with a dynamic expression to create one sequence that contains each array's values, one after the other.

### LINQ
{% highlight csharp %}
private void uiConcat_1_LINQ_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var allNumbers = numbersA.Concat(numbersB);

	var sb = new StringBuilder();

	sb.AppendLine("All numbers from both arrays:");
		foreach (var n in allNumbers)
		{
			sb.AppendLine(n.ToString());
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiConcat_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var allNumbers = numbersA.Execute<IEnumerable<int>>("Concat(numbersB)", new {numbersB});

	var sb = new StringBuilder();

	sb.AppendLine("All numbers from both arrays:");
		foreach (var n in allNumbers)
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
All numbers from both arrays: 
0 
2 
4 
5 
6 
8 
9 
1 
3 
5 
7 
8

{% endhighlight %}

## Concat - 2
This C# example uses the LINQ Concat method with a dynamic expression to create one sequence that contains the names of all customers and products, including any duplicates.

### LINQ
{% highlight csharp %}
private void uiConcat_2_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();
	var products = My.GetProductList();

	var customerNames = from c in customers select c.CompanyName;
	var productNames = from p in products select p.ProductName;

	var allNames = customerNames.Concat(productNames);

	var sb = new StringBuilder();

	sb.AppendLine("Customer and product names:");
		foreach (var n in allNames)
		{
			sb.AppendLine(n);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
{% endhighlight %}

### LINQ Execute
{% highlight csharp %}
private void uiConcat_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();
	var products = My.GetProductList();

	var customerNames = from c in customers select c.CompanyName;
	var productNames = from p in products select p.ProductName;

	var allNames = customerNames.Execute<IEnumerable<string>>("Concat(productNames)", new {productNames});

	var sb = new StringBuilder();

	sb.AppendLine("Customer and product names:");
		foreach (var n in allNames)
		{
			sb.AppendLine(n);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Customer and product names:
Alfreds Futterkiste
Ana Trujillo Emparedados y helados
Antonio Moreno TaquerÃ­a
Around the Horn
Berglunds snabbkÃ¶p
Blauer See Delikatessen
Blondel pÃ¨re et fils
BÃ³lido Comidas preparadas
Bon app'
Bottom-Dollar Markets
B's Beverages
Cactus Comidas para llevar
Centro comercial Moctezuma
Chop-suey Chinese
ComÃ©rcio Mineiro
Consolidated Holdings
Drachenblut Delikatessen
Du monde entier
Eastern Connection
Ernst Handel
Familia Arquibaldo
FISSA Fabrica Inter. Salchichas S.A.
Folies gourmandes
Folk och fÃ¤ HB
Frankenversand
France restauration
Franchi S.p.A.
Furia Bacalhau e Frutos do Mar
GalerÃ­a del gastrÃ³nomo
Godos Cocina TÃ­pica
Gourmet Lanchonetes
Great Lakes Food Market
GROSELLA-Restaurante
Hanari Carnes
HILARIÃ“N-Abastos
Hungry Coyote Import Store
Hungry Owl All-Night Grocers
Island Trading
KÃ¶niglich Essen
La corne d'abondance
La maison d'Asie
Laughing Bacchus Wine Cellars
Lazy K Kountry Store
Lehmanns Marktstand
Let's Stop N Shop
LILA-Supermercado
LINO-Delicateses
Lonesome Pine Restaurant
Magazzini Alimentari Riuniti
Maison Dewey MÃ¨re Paillarde
Morgenstern Gesundkost
North/South
OcÃ©ano AtlÃ¡ntico Ltda.
Old World Delicatessen
Ottilies KÃ¤seladen
Paris spÃ©cialitÃ©s
Pericles Comidas clÃ¡sicas
Piccolo und mehr
Princesa Isabel Vinhos
Que DelÃ­cia
Queen Cozinha
QUICK-Stop
Rancho grande
Rattlesnake Canyon Grocery
Reggiani Caseifici
Ricardo Adocicados
Richter Supermarkt
Romero y tomillo SantÃ© Gourmet
Save-a-lot Markets
Seven Seas Imports
Simons bistro
SpÃ©cialitÃ©s du monde
Split Rail Beer & Ale
SuprÃªmes dÃ©lices
The Big Cheese
The Cracker Box
Toms SpezialitÃ¤ten
Tortuga Restaurante
TradiÃ§Ã£o Hipermercados
Trail's Head Gourmet Provisioners
Vaffeljernet
Victuailles en stock
Vins et alcools Chevalier
Die Wandernde Kuh
Wartian Herkku
Wellington Importadora
White Clover Markets
Wilman Kala
Wolski Zajazd
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
