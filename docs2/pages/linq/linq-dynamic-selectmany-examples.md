# LINQ Dynamic - SelectMany

## LINQ Dynamic SelectMany Examples
C# Dynamic LINQ SelectMany examples using an Expression Evaluator.

- [SelectMany - Compound from 1](#selectmany---compound-from-1)
- [SelectMany - Compound from 2](#selectmany---compound-from-2)
- [SelectMany - Compound from 3](#selectmany---compound-from-3)
- [SelectMany - from Assignment](#selectmany---from-assignment)
- [SelectMany - Multiple from](#selectmany---multiple-from)
- [SelectMany - Indexed](#selectmany---indexed)

## SelectMany - Compound from 1
This C# example uses the LINQ SelectMany method to make a query that returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

### LINQ
```csharp
private void uiSelectMany_CF_1_LINQ_Click(object sender, EventArgs e)
{
	int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
	int[] numbersB = {1, 3, 5, 7, 8};

	var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new {a, b}).Where(arg => arg.a < arg.b);

	var sb = new StringBuilder();

	sb.AppendLine("Pairs where a < b:");
		foreach (var pair in pairs)
		{
			sb.AppendLine("{0} is less than {1}", pair.a, pair.b);
		}

	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSelectMany_CF_1_LINQ_Execute_Click(object sender, EventArgs e)
{
	int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
	int[] numbersB = { 1, 3, 5, 7, 8 };

	var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(arg => arg.a < arg.b);

	var sb = new StringBuilder();

	sb.AppendLine("Pairs where a < b:");
		foreach (var pair in pairs)
		{
			sb.AppendLine("{0} is less than {1}", pair.a, pair.b);
		}

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Pairs where a < b:
0 is less than 1
0 is less than 3
0 is less than 5
0 is less than 7
0 is less than 8
2 is less than 3
2 is less than 5
2 is less than 7
2 is less than 8
4 is less than 5
4 is less than 7
4 is less than 8
5 is less than 7
5 is less than 8
6 is less than 7
6 is less than 8

```

## SelectMany - Compound from 2
This C# example uses the LINQ SelectMany method to select all orders where the order total is less than 500.00.

### LINQ
```csharp
private void uiSelectMany_CF_2_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.Total < 500.00M select new {c.CustomerID, o.OrderID, o.Total};

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiSelectMany_CF_2_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.Total < 500.00M select new {c.CustomerID, o.OrderID, o.Total};

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSelectMany_CF_2_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.Total < 500.00M select new {c.CustomerID, o.OrderID, o.Total};

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
CustomerID=ALFKI OrderID=10702 Total=330.00
CustomerID=ALFKI OrderID=10952 Total=471.20
CustomerID=ANATR OrderID=10308 Total=88.80
CustomerID=ANATR OrderID=10625 Total=479.75
CustomerID=ANATR OrderID=10759 Total=320.00
CustomerID=ANTON OrderID=10365 Total=403.20
CustomerID=ANTON OrderID=10682 Total=375.50
CustomerID=AROUT OrderID=10355 Total=480.00
CustomerID=AROUT OrderID=10453 Total=407.70
CustomerID=AROUT OrderID=10741 Total=228.00
CustomerID=AROUT OrderID=10743 Total=319.20
CustomerID=AROUT OrderID=10793 Total=191.10
CustomerID=AROUT OrderID=10864 Total=282.00
CustomerID=AROUT OrderID=10920 Total=390.00
CustomerID=AROUT OrderID=11016 Total=491.50
CustomerID=BERGS OrderID=10445 Total=174.90
CustomerID=BERGS OrderID=10689 Total=472.50
CustomerID=BERGS OrderID=10778 Total=96.50
CustomerID=BLAUS OrderID=10501 Total=149.00
CustomerID=BLAUS OrderID=10509 Total=136.80
CustomerID=BLAUS OrderID=10582 Total=330.00
CustomerID=BLAUS OrderID=10614 Total=464.00
CustomerID=BLONP OrderID=10628 Total=450.00
CustomerID=BOLID OrderID=10970 Total=224.00
CustomerID=BONAP OrderID=10331 Total=88.50
CustomerID=BONAP OrderID=10730 Total=484.26
CustomerID=BONAP OrderID=10732 Total=360.00
CustomerID=BONAP OrderID=10940 Total=360.00
CustomerID=BSBEV OrderID=10289 Total=479.40
CustomerID=BSBEV OrderID=10484 Total=386.20
CustomerID=BSBEV OrderID=10538 Total=139.80
CustomerID=BSBEV OrderID=10539 Total=355.50
CustomerID=BSBEV OrderID=10578 Total=477.00
CustomerID=BSBEV OrderID=10599 Total=493.00
CustomerID=BSBEV OrderID=10947 Total=220.00
CustomerID=CACTU OrderID=10521 Total=225.50
CustomerID=CACTU OrderID=10782 Total=12.50
CustomerID=CACTU OrderID=10819 Total=477.00
CustomerID=CACTU OrderID=10881 Total=150.00
CustomerID=CACTU OrderID=11054 Total=305.00
CustomerID=CENTC OrderID=10259 Total=100.80
CustomerID=COMMI OrderID=10466 Total=216.00
CustomerID=COMMI OrderID=10969 Total=108.00
CustomerID=COMMI OrderID=11042 Total=405.75
CustomerID=CONSH OrderID=10462 Total=156.00
CustomerID=DRACD OrderID=10363 Total=447.20
CustomerID=DRACD OrderID=10391 Total=86.40
CustomerID=DRACD OrderID=10797 Total=420.00
CustomerID=DRACD OrderID=11067 Total=86.85
CustomerID=DUMON OrderID=10311 Total=268.80
CustomerID=DUMON OrderID=10609 Total=424.00
CustomerID=DUMON OrderID=10683 Total=63.00
CustomerID=ERNSH OrderID=10771 Total=344.00
CustomerID=FAMIA OrderID=10386 Total=166.00
CustomerID=FAMIA OrderID=10414 Total=224.83
CustomerID=FAMIA OrderID=10581 Total=310.00
CustomerID=FAMIA OrderID=10725 Total=287.80
CustomerID=FOLKO OrderID=10378 Total=103.20
CustomerID=FOLKO OrderID=10434 Total=321.12
CustomerID=FOLKO OrderID=10460 Total=176.10
CustomerID=FOLKO OrderID=10824 Total=250.80
CustomerID=FOLKO OrderID=10955 Total=74.40
CustomerID=FOLKO OrderID=10980 Total=248.00
CustomerID=FRANS OrderID=10422 Total=49.80
CustomerID=FRANS OrderID=10710 Total=93.50
CustomerID=FRANS OrderID=10753 Total=88.00
CustomerID=FRANS OrderID=10807 Total=18.40
CustomerID=FRANS OrderID=11060 Total=266.00
CustomerID=FURIB OrderID=10352 Total=136.30
CustomerID=FURIB OrderID=10491 Total=259.50
CustomerID=FURIB OrderID=10604 Total=230.85
CustomerID=FURIB OrderID=10963 Total=57.80
CustomerID=GALED OrderID=10366 Total=136.00
CustomerID=GALED OrderID=10426 Total=338.20
CustomerID=GALED OrderID=10568 Total=155.00
CustomerID=GALED OrderID=10887 Total=70.00
CustomerID=GALED OrderID=10928 Total=137.50
CustomerID=GODOS OrderID=10874 Total=310.00
CustomerID=GODOS OrderID=11037 Total=60.00
CustomerID=GOURL OrderID=10652 Total=318.84
CustomerID=GOURL OrderID=10777 Total=224.00
CustomerID=GOURL OrderID=10959 Total=131.75
CustomerID=GOURL OrderID=11049 Total=273.60
CustomerID=GREAL OrderID=10528 Total=392.20
CustomerID=GREAL OrderID=10589 Total=72.00
CustomerID=GREAL OrderID=10936 Total=456.00
CustomerID=GREAL OrderID=11006 Total=329.68
CustomerID=GREAL OrderID=11040 Total=200.00
CustomerID=GROSR OrderID=10785 Total=387.50
CustomerID=HANAR OrderID=10770 Total=236.25
CustomerID=HANAR OrderID=10925 Total=475.15
CustomerID=HILAA OrderID=10476 Total=180.48
CustomerID=HILAA OrderID=10613 Total=353.20
CustomerID=HILAA OrderID=10705 Total=378.00
CustomerID=HILAA OrderID=10863 Total=441.15
CustomerID=HILAA OrderID=10960 Total=265.35
CustomerID=HUNGC OrderID=10375 Total=338.00
CustomerID=HUNGC OrderID=10394 Total=442.00
CustomerID=HUNGC OrderID=10415 Total=102.40
CustomerID=HUNGC OrderID=10600 Total=479.80
CustomerID=ISLAT OrderID=10318 Total=240.40
CustomerID=ISLAT OrderID=10321 Total=144.00
CustomerID=ISLAT OrderID=10473 Total=230.40
CustomerID=ISLAT OrderID=10674 Total=45.00
CustomerID=ISLAT OrderID=10798 Total=446.60
CustomerID=KOENE OrderID=10323 Total=164.40
CustomerID=KOENE OrderID=10506 Total=415.80
CustomerID=KOENE OrderID=10542 Total=469.11
CustomerID=LACOR OrderID=10972 Total=251.50
CustomerID=LACOR OrderID=10973 Total=291.55
CustomerID=LAMAI OrderID=10358 Total=429.40
CustomerID=LAMAI OrderID=10371 Total=72.96
CustomerID=LAMAI OrderID=10425 Total=360.00
CustomerID=LAMAI OrderID=10454 Total=331.20
CustomerID=LAMAI OrderID=10610 Total=299.25
CustomerID=LAMAI OrderID=10631 Total=55.80
CustomerID=LAMAI OrderID=10832 Total=475.11
CustomerID=LAMAI OrderID=11051 Total=36.00
CustomerID=LAUGB OrderID=10495 Total=278.00
CustomerID=LAUGB OrderID=10620 Total=57.50
CustomerID=LAUGB OrderID=10810 Total=187.00
CustomerID=LAZYK OrderID=10482 Total=147.00
CustomerID=LAZYK OrderID=10545 Total=210.00
CustomerID=LEHMS OrderID=10279 Total=351.00
CustomerID=LEHMS OrderID=10534 Total=465.70
CustomerID=LEHMS OrderID=10891 Total=368.93
CustomerID=LETSS OrderID=10579 Total=317.75
CustomerID=LILAS OrderID=10381 Total=112.00
CustomerID=LILAS OrderID=10899 Total=122.40
CustomerID=LILAS OrderID=11065 Total=189.42
CustomerID=LILAS OrderID=11071 Total=484.50
CustomerID=LINOD OrderID=10405 Total=400.00
CustomerID=LINOD OrderID=10840 Total=211.20
CustomerID=LINOD OrderID=11014 Total=243.18
CustomerID=LONEP OrderID=10307 Total=424.00
CustomerID=LONEP OrderID=10317 Total=288.00
CustomerID=LONEP OrderID=10544 Total=417.20
CustomerID=LONEP OrderID=10662 Total=125.00
CustomerID=LONEP OrderID=10867 Total=98.40
CustomerID=LONEP OrderID=10883 Total=36.00
CustomerID=MAGAA OrderID=10275 Total=291.84
CustomerID=MAGAA OrderID=10467 Total=235.20
CustomerID=MAGAA OrderID=10754 Total=55.20
CustomerID=MAGAA OrderID=10950 Total=110.00
CustomerID=MAISD OrderID=11004 Total=295.38
CustomerID=MEREP OrderID=10376 Total=399.00
CustomerID=MEREP OrderID=10505 Total=147.90
CustomerID=MORGK OrderID=10699 Total=114.00
CustomerID=MORGK OrderID=10945 Total=245.00
CustomerID=NORTS OrderID=10517 Total=352.00
CustomerID=NORTS OrderID=10752 Total=252.00
CustomerID=NORTS OrderID=11057 Total=45.00
CustomerID=OCEAN OrderID=10409 Total=319.20
CustomerID=OCEAN OrderID=10531 Total=110.00
CustomerID=OCEAN OrderID=10898 Total=30.00
CustomerID=OTTIK OrderID=10508 Total=240.00
CustomerID=PERIC OrderID=10322 Total=112.00
CustomerID=PERIC OrderID=11073 Total=300.00
CustomerID=PICCO OrderID=10489 Total=439.20
CustomerID=PRINI OrderID=10336 Total=285.12
CustomerID=QUEDE OrderID=10261 Total=448.00
CustomerID=QUEDE OrderID=10291 Total=497.52
CustomerID=QUEDE OrderID=10794 Total=314.76
CustomerID=QUICK OrderID=10313 Total=182.40
CustomerID=RANCH OrderID=10448 Total=443.40
CustomerID=RANCH OrderID=11019 Total=76.00
CustomerID=REGGC OrderID=10288 Total=80.10
CustomerID=REGGC OrderID=10428 Total=192.00
CustomerID=REGGC OrderID=10562 Total=488.70
CustomerID=REGGC OrderID=10586 Total=23.80
CustomerID=REGGC OrderID=10655 Total=154.40
CustomerID=REGGC OrderID=11062 Total=406.40
CustomerID=RICAR OrderID=10299 Total=349.50
CustomerID=RICAR OrderID=10648 Total=372.38
CustomerID=RICSU OrderID=10951 Total=458.76
CustomerID=RICSU OrderID=11075 Total=498.10
CustomerID=ROMEY OrderID=10281 Total=86.50
CustomerID=ROMEY OrderID=10282 Total=155.40
CustomerID=ROMEY OrderID=10306 Total=498.50
CustomerID=ROMEY OrderID=10917 Total=365.89
CustomerID=ROMEY OrderID=11013 Total=361.00
CustomerID=SANTG OrderID=10520 Total=200.00
CustomerID=SAVEA OrderID=10815 Total=40.00
CustomerID=SIMOB OrderID=10341 Total=352.60
CustomerID=SIMOB OrderID=11074 Total=232.08
CustomerID=SPECD OrderID=10738 Total=52.35
CustomerID=SPECD OrderID=10907 Total=108.50
CustomerID=SPECD OrderID=11043 Total=210.00
CustomerID=SPLIR OrderID=10271 Total=48.00
CustomerID=SPLIR OrderID=10349 Total=141.60
CustomerID=SPLIR OrderID=10432 Total=485.00
CustomerID=SPLIR OrderID=10974 Total=439.00
CustomerID=SUPRD OrderID=10767 Total=28.00
CustomerID=THEBI OrderID=10310 Total=336.00
CustomerID=THEBI OrderID=10708 Total=180.40
CustomerID=THEBI OrderID=10992 Total=69.60
CustomerID=THECR OrderID=10775 Total=228.00
CustomerID=THECR OrderID=11003 Total=326.00
CustomerID=TOMSP OrderID=10438 Total=454.00
CustomerID=TOMSP OrderID=10446 Total=246.24
CustomerID=TOMSP OrderID=10548 Total=240.10
CustomerID=TORTU OrderID=10276 Total=420.00
CustomerID=TORTU OrderID=11069 Total=360.00
CustomerID=TRADH OrderID=10496 Total=190.00
CustomerID=TRAIH OrderID=10822 Total=237.90
CustomerID=VAFFE OrderID=10602 Total=48.75
CustomerID=VICTE OrderID=10334 Total=144.80
CustomerID=VICTE OrderID=10450 Total=425.12
CustomerID=VICTE OrderID=10478 Total=471.20
CustomerID=VICTE OrderID=10806 Total=439.60
CustomerID=VICTE OrderID=10843 Total=159.00
CustomerID=VINET OrderID=10295 Total=121.60
CustomerID=VINET OrderID=10737 Total=139.80
CustomerID=VINET OrderID=10739 Total=240.00
CustomerID=WANDK OrderID=10348 Total=363.60
CustomerID=WANDK OrderID=10651 Total=397.80
CustomerID=WARTH OrderID=10266 Total=346.56
CustomerID=WARTH OrderID=10412 Total=334.80
CustomerID=WARTH OrderID=10437 Total=393.00
CustomerID=WARTH OrderID=11025 Total=270.00
CustomerID=WELLI OrderID=10585 Total=142.50
CustomerID=WELLI OrderID=10809 Total=140.00
CustomerID=WELLI OrderID=10900 Total=33.75
CustomerID=WELLI OrderID=10905 Total=342.00
CustomerID=WHITC OrderID=10723 Total=468.45
CustomerID=WILMK OrderID=10248 Total=440.00
CustomerID=WILMK OrderID=10615 Total=120.00
CustomerID=WILMK OrderID=10673 Total=412.35
CustomerID=WILMK OrderID=10873 Total=336.80
CustomerID=WILMK OrderID=10910 Total=452.90
CustomerID=WOLZA OrderID=10374 Total=459.00
CustomerID=WOLZA OrderID=10792 Total=399.85
CustomerID=WOLZA OrderID=10870 Total=160.00
CustomerID=WOLZA OrderID=10906 Total=427.50

```

## SelectMany - Compound from 3
This C# example uses the LINQ SelectMany method with a dynamic expression to select all orders where the order was made in 1998 or later.

### LINQ
```csharp
private void uiSelectMany_CF_3_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new {c.CustomerID, o.OrderID, o.OrderDate};

	var sb = new StringBuilder();
   
	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiSelectMany_CF_3_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new {c.CustomerID, o.OrderID, o.OrderDate};

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSelectMany_CF_3_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new {c.CustomerID, o.OrderID, o.OrderDate};

	var sb = new StringBuilder();

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
CustomerID=ALFKI OrderID=10835 OrderDate=1/15/1998
CustomerID=ALFKI OrderID=10952 OrderDate=3/16/1998
CustomerID=ALFKI OrderID=11011 OrderDate=4/9/1998
CustomerID=ANATR OrderID=10926 OrderDate=3/4/1998
CustomerID=ANTON OrderID=10856 OrderDate=1/28/1998
CustomerID=AROUT OrderID=10864 OrderDate=2/2/1998
CustomerID=AROUT OrderID=10920 OrderDate=3/3/1998
CustomerID=AROUT OrderID=10953 OrderDate=3/16/1998
CustomerID=AROUT OrderID=11016 OrderDate=4/10/1998
CustomerID=BERGS OrderID=10837 OrderDate=1/16/1998
CustomerID=BERGS OrderID=10857 OrderDate=1/28/1998
CustomerID=BERGS OrderID=10866 OrderDate=2/3/1998
CustomerID=BERGS OrderID=10875 OrderDate=2/6/1998
CustomerID=BERGS OrderID=10924 OrderDate=3/4/1998
CustomerID=BLAUS OrderID=10853 OrderDate=1/27/1998
CustomerID=BLAUS OrderID=10956 OrderDate=3/17/1998
CustomerID=BLAUS OrderID=11058 OrderDate=4/29/1998
CustomerID=BLONP OrderID=10826 OrderDate=1/12/1998
CustomerID=BOLID OrderID=10970 OrderDate=3/24/1998
CustomerID=BONAP OrderID=10827 OrderDate=1/12/1998
CustomerID=BONAP OrderID=10871 OrderDate=2/5/1998
CustomerID=BONAP OrderID=10876 OrderDate=2/9/1998
CustomerID=BONAP OrderID=10932 OrderDate=3/6/1998
CustomerID=BONAP OrderID=10940 OrderDate=3/11/1998
CustomerID=BONAP OrderID=11076 OrderDate=5/6/1998
CustomerID=BOTTM OrderID=10918 OrderDate=3/2/1998
CustomerID=BOTTM OrderID=10944 OrderDate=3/12/1998
CustomerID=BOTTM OrderID=10949 OrderDate=3/13/1998
CustomerID=BOTTM OrderID=10975 OrderDate=3/25/1998
CustomerID=BOTTM OrderID=10982 OrderDate=3/27/1998
CustomerID=BOTTM OrderID=11027 OrderDate=4/16/1998
CustomerID=BOTTM OrderID=11045 OrderDate=4/23/1998
CustomerID=BOTTM OrderID=11048 OrderDate=4/24/1998
CustomerID=BSBEV OrderID=10943 OrderDate=3/11/1998
CustomerID=BSBEV OrderID=10947 OrderDate=3/13/1998
CustomerID=BSBEV OrderID=11023 OrderDate=4/14/1998
CustomerID=CACTU OrderID=10819 OrderDate=1/7/1998
CustomerID=CACTU OrderID=10881 OrderDate=2/11/1998
CustomerID=CACTU OrderID=10937 OrderDate=3/10/1998
CustomerID=CACTU OrderID=11054 OrderDate=4/28/1998
CustomerID=CHOPS OrderID=10966 OrderDate=3/20/1998
CustomerID=CHOPS OrderID=11029 OrderDate=4/16/1998
CustomerID=CHOPS OrderID=11041 OrderDate=4/22/1998
CustomerID=COMMI OrderID=10969 OrderDate=3/23/1998
CustomerID=COMMI OrderID=11042 OrderDate=4/22/1998
CustomerID=CONSH OrderID=10848 OrderDate=1/23/1998
CustomerID=DRACD OrderID=10825 OrderDate=1/9/1998
CustomerID=DRACD OrderID=11036 OrderDate=4/20/1998
CustomerID=DRACD OrderID=11067 OrderDate=5/4/1998
CustomerID=DUMON OrderID=10890 OrderDate=2/16/1998
CustomerID=EASTC OrderID=10987 OrderDate=3/31/1998
CustomerID=EASTC OrderID=11024 OrderDate=4/15/1998
CustomerID=EASTC OrderID=11047 OrderDate=4/24/1998
CustomerID=EASTC OrderID=11056 OrderDate=4/28/1998
CustomerID=ERNSH OrderID=10836 OrderDate=1/16/1998
CustomerID=ERNSH OrderID=10854 OrderDate=1/27/1998
CustomerID=ERNSH OrderID=10895 OrderDate=2/18/1998
CustomerID=ERNSH OrderID=10968 OrderDate=3/23/1998
CustomerID=ERNSH OrderID=10979 OrderDate=3/26/1998
CustomerID=ERNSH OrderID=10990 OrderDate=4/1/1998
CustomerID=ERNSH OrderID=11008 OrderDate=4/8/1998
CustomerID=ERNSH OrderID=11017 OrderDate=4/13/1998
CustomerID=ERNSH OrderID=11072 OrderDate=5/5/1998
CustomerID=FOLKO OrderID=10824 OrderDate=1/9/1998
CustomerID=FOLKO OrderID=10880 OrderDate=2/10/1998
CustomerID=FOLKO OrderID=10902 OrderDate=2/23/1998
CustomerID=FOLKO OrderID=10955 OrderDate=3/17/1998
CustomerID=FOLKO OrderID=10977 OrderDate=3/26/1998
CustomerID=FOLKO OrderID=10980 OrderDate=3/27/1998
CustomerID=FOLKO OrderID=10993 OrderDate=4/1/1998
CustomerID=FOLKO OrderID=11001 OrderDate=4/6/1998
CustomerID=FOLKO OrderID=11050 OrderDate=4/27/1998
CustomerID=FRANK OrderID=10859 OrderDate=1/29/1998
CustomerID=FRANK OrderID=10929 OrderDate=3/5/1998
CustomerID=FRANK OrderID=11012 OrderDate=4/9/1998
CustomerID=FRANR OrderID=10860 OrderDate=1/29/1998
CustomerID=FRANR OrderID=10971 OrderDate=3/24/1998
CustomerID=FRANS OrderID=11026 OrderDate=4/15/1998
CustomerID=FRANS OrderID=11060 OrderDate=4/30/1998
CustomerID=FURIB OrderID=10963 OrderDate=3/19/1998
CustomerID=GALED OrderID=10887 OrderDate=2/13/1998
CustomerID=GALED OrderID=10928 OrderDate=3/5/1998
CustomerID=GODOS OrderID=10872 OrderDate=2/5/1998
CustomerID=GODOS OrderID=10874 OrderDate=2/6/1998
CustomerID=GODOS OrderID=10888 OrderDate=2/16/1998
CustomerID=GODOS OrderID=10911 OrderDate=2/26/1998
CustomerID=GODOS OrderID=10948 OrderDate=3/13/1998
CustomerID=GODOS OrderID=11009 OrderDate=4/8/1998
CustomerID=GODOS OrderID=11037 OrderDate=4/21/1998
CustomerID=GOURL OrderID=10959 OrderDate=3/18/1998
CustomerID=GOURL OrderID=11049 OrderDate=4/24/1998
CustomerID=GREAL OrderID=10816 OrderDate=1/6/1998
CustomerID=GREAL OrderID=10936 OrderDate=3/9/1998
CustomerID=GREAL OrderID=11006 OrderDate=4/7/1998
CustomerID=GREAL OrderID=11040 OrderDate=4/22/1998
CustomerID=GREAL OrderID=11061 OrderDate=4/30/1998
CustomerID=HANAR OrderID=10886 OrderDate=2/13/1998
CustomerID=HANAR OrderID=10903 OrderDate=2/24/1998
CustomerID=HANAR OrderID=10922 OrderDate=3/3/1998
CustomerID=HANAR OrderID=10925 OrderDate=3/4/1998
CustomerID=HANAR OrderID=10981 OrderDate=3/27/1998
CustomerID=HANAR OrderID=11022 OrderDate=4/14/1998
CustomerID=HANAR OrderID=11052 OrderDate=4/27/1998
CustomerID=HILAA OrderID=10863 OrderDate=2/2/1998
CustomerID=HILAA OrderID=10901 OrderDate=2/23/1998
CustomerID=HILAA OrderID=10957 OrderDate=3/18/1998
CustomerID=HILAA OrderID=10960 OrderDate=3/19/1998
CustomerID=HILAA OrderID=10976 OrderDate=3/25/1998
CustomerID=HILAA OrderID=11055 OrderDate=4/28/1998
CustomerID=HUNGO OrderID=10897 OrderDate=2/19/1998
CustomerID=HUNGO OrderID=10912 OrderDate=2/26/1998
CustomerID=HUNGO OrderID=10985 OrderDate=3/30/1998
CustomerID=HUNGO OrderID=11063 OrderDate=4/30/1998
CustomerID=ISLAT OrderID=10829 OrderDate=1/13/1998
CustomerID=ISLAT OrderID=10933 OrderDate=3/6/1998
CustomerID=KOENE OrderID=10817 OrderDate=1/6/1998
CustomerID=KOENE OrderID=10849 OrderDate=1/23/1998
CustomerID=KOENE OrderID=10893 OrderDate=2/18/1998
CustomerID=KOENE OrderID=11028 OrderDate=4/16/1998
CustomerID=LACOR OrderID=10858 OrderDate=1/29/1998
CustomerID=LACOR OrderID=10927 OrderDate=3/5/1998
CustomerID=LACOR OrderID=10972 OrderDate=3/24/1998
CustomerID=LACOR OrderID=10973 OrderDate=3/24/1998
CustomerID=LAMAI OrderID=10832 OrderDate=1/14/1998
CustomerID=LAMAI OrderID=10923 OrderDate=3/3/1998
CustomerID=LAMAI OrderID=11051 OrderDate=4/27/1998
CustomerID=LAUGB OrderID=10810 OrderDate=1/1/1998
CustomerID=LEHMS OrderID=10862 OrderDate=1/30/1998
CustomerID=LEHMS OrderID=10891 OrderDate=2/17/1998
CustomerID=LEHMS OrderID=10934 OrderDate=3/9/1998
CustomerID=LEHMS OrderID=11070 OrderDate=5/5/1998
CustomerID=LETSS OrderID=10884 OrderDate=2/12/1998
CustomerID=LILAS OrderID=10823 OrderDate=1/9/1998
CustomerID=LILAS OrderID=10899 OrderDate=2/20/1998
CustomerID=LILAS OrderID=10997 OrderDate=4/3/1998
CustomerID=LILAS OrderID=11065 OrderDate=5/1/1998
CustomerID=LILAS OrderID=11071 OrderDate=5/5/1998
CustomerID=LINOD OrderID=10811 OrderDate=1/2/1998
CustomerID=LINOD OrderID=10838 OrderDate=1/19/1998
CustomerID=LINOD OrderID=10840 OrderDate=1/19/1998
CustomerID=LINOD OrderID=10919 OrderDate=3/2/1998
CustomerID=LINOD OrderID=10954 OrderDate=3/17/1998
CustomerID=LINOD OrderID=11014 OrderDate=4/10/1998
CustomerID=LINOD OrderID=11039 OrderDate=4/21/1998
CustomerID=LONEP OrderID=10867 OrderDate=2/3/1998
CustomerID=LONEP OrderID=10883 OrderDate=2/12/1998
CustomerID=LONEP OrderID=11018 OrderDate=4/13/1998
CustomerID=MAGAA OrderID=10818 OrderDate=1/7/1998
CustomerID=MAGAA OrderID=10939 OrderDate=3/10/1998
CustomerID=MAGAA OrderID=10950 OrderDate=3/16/1998
CustomerID=MAISD OrderID=10892 OrderDate=2/17/1998
CustomerID=MAISD OrderID=10896 OrderDate=2/19/1998
CustomerID=MAISD OrderID=10978 OrderDate=3/26/1998
CustomerID=MAISD OrderID=11004 OrderDate=4/7/1998
CustomerID=MORGK OrderID=10945 OrderDate=3/12/1998
CustomerID=NORTS OrderID=11057 OrderDate=4/29/1998
CustomerID=OCEAN OrderID=10898 OrderDate=2/20/1998
CustomerID=OCEAN OrderID=10958 OrderDate=3/18/1998
CustomerID=OCEAN OrderID=10986 OrderDate=3/30/1998
CustomerID=OLDWO OrderID=10855 OrderDate=1/27/1998
CustomerID=OLDWO OrderID=10965 OrderDate=3/20/1998
CustomerID=OLDWO OrderID=11034 OrderDate=4/20/1998
CustomerID=OTTIK OrderID=10833 OrderDate=1/15/1998
CustomerID=OTTIK OrderID=10999 OrderDate=4/3/1998
CustomerID=OTTIK OrderID=11020 OrderDate=4/14/1998
CustomerID=PERIC OrderID=10995 OrderDate=4/2/1998
CustomerID=PERIC OrderID=11073 OrderDate=5/5/1998
CustomerID=PICCO OrderID=10844 OrderDate=1/21/1998
CustomerID=PICCO OrderID=11053 OrderDate=4/27/1998
CustomerID=PRINI OrderID=10808 OrderDate=1/1/1998
CustomerID=PRINI OrderID=11007 OrderDate=4/8/1998
CustomerID=QUEDE OrderID=10989 OrderDate=3/31/1998
CustomerID=QUEEN OrderID=10868 OrderDate=2/4/1998
CustomerID=QUEEN OrderID=10913 OrderDate=2/26/1998
CustomerID=QUEEN OrderID=10914 OrderDate=2/27/1998
CustomerID=QUEEN OrderID=10961 OrderDate=3/19/1998
CustomerID=QUEEN OrderID=11068 OrderDate=5/4/1998
CustomerID=QUICK OrderID=10845 OrderDate=1/21/1998
CustomerID=QUICK OrderID=10865 OrderDate=2/2/1998
CustomerID=QUICK OrderID=10878 OrderDate=2/10/1998
CustomerID=QUICK OrderID=10938 OrderDate=3/10/1998
CustomerID=QUICK OrderID=10962 OrderDate=3/19/1998
CustomerID=QUICK OrderID=10991 OrderDate=4/1/1998
CustomerID=QUICK OrderID=10996 OrderDate=4/2/1998
CustomerID=QUICK OrderID=11021 OrderDate=4/14/1998
CustomerID=RANCH OrderID=10828 OrderDate=1/13/1998
CustomerID=RANCH OrderID=10916 OrderDate=2/27/1998
CustomerID=RANCH OrderID=11019 OrderDate=4/13/1998
CustomerID=RATTC OrderID=10820 OrderDate=1/7/1998
CustomerID=RATTC OrderID=10852 OrderDate=1/26/1998
CustomerID=RATTC OrderID=10889 OrderDate=2/16/1998
CustomerID=RATTC OrderID=10988 OrderDate=3/31/1998
CustomerID=RATTC OrderID=11000 OrderDate=4/6/1998
CustomerID=RATTC OrderID=11077 OrderDate=5/6/1998
CustomerID=REGGC OrderID=10812 OrderDate=1/2/1998
CustomerID=REGGC OrderID=10908 OrderDate=2/26/1998
CustomerID=REGGC OrderID=10942 OrderDate=3/11/1998
CustomerID=REGGC OrderID=11010 OrderDate=4/9/1998
CustomerID=REGGC OrderID=11062 OrderDate=4/30/1998
CustomerID=RICAR OrderID=10813 OrderDate=1/5/1998
CustomerID=RICAR OrderID=10851 OrderDate=1/26/1998
CustomerID=RICAR OrderID=10877 OrderDate=2/9/1998
CustomerID=RICAR OrderID=11059 OrderDate=4/29/1998
CustomerID=RICSU OrderID=10931 OrderDate=3/6/1998
CustomerID=RICSU OrderID=10951 OrderDate=3/16/1998
CustomerID=RICSU OrderID=11033 OrderDate=4/17/1998
CustomerID=RICSU OrderID=11075 OrderDate=5/6/1998
CustomerID=ROMEY OrderID=10917 OrderDate=3/2/1998
CustomerID=ROMEY OrderID=11013 OrderDate=4/9/1998
CustomerID=SANTG OrderID=10831 OrderDate=1/14/1998
CustomerID=SANTG OrderID=10909 OrderDate=2/26/1998
CustomerID=SANTG OrderID=11015 OrderDate=4/10/1998
CustomerID=SAVEA OrderID=10815 OrderDate=1/5/1998
CustomerID=SAVEA OrderID=10847 OrderDate=1/22/1998
CustomerID=SAVEA OrderID=10882 OrderDate=2/11/1998
CustomerID=SAVEA OrderID=10894 OrderDate=2/18/1998
CustomerID=SAVEA OrderID=10941 OrderDate=3/11/1998
CustomerID=SAVEA OrderID=10983 OrderDate=3/27/1998
CustomerID=SAVEA OrderID=10984 OrderDate=3/30/1998
CustomerID=SAVEA OrderID=11002 OrderDate=4/6/1998
CustomerID=SAVEA OrderID=11030 OrderDate=4/17/1998
CustomerID=SAVEA OrderID=11031 OrderDate=4/17/1998
CustomerID=SAVEA OrderID=11064 OrderDate=5/1/1998
CustomerID=SEVES OrderID=10869 OrderDate=2/4/1998
CustomerID=SIMOB OrderID=11074 OrderDate=5/6/1998
CustomerID=SPECD OrderID=10907 OrderDate=2/25/1998
CustomerID=SPECD OrderID=10964 OrderDate=3/20/1998
CustomerID=SPECD OrderID=11043 OrderDate=4/22/1998
CustomerID=SPLIR OrderID=10821 OrderDate=1/8/1998
CustomerID=SPLIR OrderID=10974 OrderDate=3/25/1998
CustomerID=SUPRD OrderID=10841 OrderDate=1/20/1998
CustomerID=SUPRD OrderID=10846 OrderDate=1/22/1998
CustomerID=SUPRD OrderID=10885 OrderDate=2/12/1998
CustomerID=SUPRD OrderID=10930 OrderDate=3/6/1998
CustomerID=SUPRD OrderID=11035 OrderDate=4/20/1998
CustomerID=SUPRD OrderID=11038 OrderDate=4/21/1998
CustomerID=THEBI OrderID=10992 OrderDate=4/1/1998
CustomerID=THECR OrderID=11003 OrderDate=4/6/1998
CustomerID=TOMSP OrderID=10967 OrderDate=3/23/1998
CustomerID=TORTU OrderID=10842 OrderDate=1/20/1998
CustomerID=TORTU OrderID=10915 OrderDate=2/27/1998
CustomerID=TORTU OrderID=11069 OrderDate=5/4/1998
CustomerID=TRADH OrderID=10830 OrderDate=1/13/1998
CustomerID=TRADH OrderID=10834 OrderDate=1/15/1998
CustomerID=TRADH OrderID=10839 OrderDate=1/19/1998
CustomerID=TRAIH OrderID=10822 OrderDate=1/8/1998
CustomerID=VAFFE OrderID=10921 OrderDate=3/3/1998
CustomerID=VAFFE OrderID=10946 OrderDate=3/12/1998
CustomerID=VAFFE OrderID=10994 OrderDate=4/2/1998
CustomerID=VICTE OrderID=10814 OrderDate=1/5/1998
CustomerID=VICTE OrderID=10843 OrderDate=1/21/1998
CustomerID=VICTE OrderID=10850 OrderDate=1/23/1998
CustomerID=WANDK OrderID=11046 OrderDate=4/23/1998
CustomerID=WARTH OrderID=11025 OrderDate=4/15/1998
CustomerID=WELLI OrderID=10809 OrderDate=1/1/1998
CustomerID=WELLI OrderID=10900 OrderDate=2/20/1998
CustomerID=WELLI OrderID=10905 OrderDate=2/24/1998
CustomerID=WELLI OrderID=10935 OrderDate=3/9/1998
CustomerID=WHITC OrderID=10861 OrderDate=1/30/1998
CustomerID=WHITC OrderID=10904 OrderDate=2/24/1998
CustomerID=WHITC OrderID=11032 OrderDate=4/17/1998
CustomerID=WHITC OrderID=11066 OrderDate=5/1/1998
CustomerID=WILMK OrderID=10873 OrderDate=2/6/1998
CustomerID=WILMK OrderID=10879 OrderDate=2/10/1998
CustomerID=WILMK OrderID=10910 OrderDate=2/26/1998
CustomerID=WILMK OrderID=11005 OrderDate=4/7/1998
CustomerID=WOLZA OrderID=10870 OrderDate=2/4/1998
CustomerID=WOLZA OrderID=10906 OrderDate=2/25/1998
CustomerID=WOLZA OrderID=10998 OrderDate=4/3/1998
CustomerID=WOLZA OrderID=11044 OrderDate=4/23/1998

```

## SelectMany - from Assignment
This C# example uses the LINQ SelectMany method with a dynamic expression to select all orders where the order total is greater than 2000.00 and uses from assignment to avoid requesting the total twice.

### LINQ
```csharp
private void uiSelectMany_From_Assignment_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiSelectMany_From_Assignment_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();		

	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSelectMany_From_Assignment_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
CustomerID=ANTON OrderID=10573 Total=2082.00
CustomerID=AROUT OrderID=10558 Total=2142.90
CustomerID=AROUT OrderID=10953 Total=4441.25
CustomerID=BERGS OrderID=10384 Total=2222.40
CustomerID=BERGS OrderID=10524 Total=3192.65
CustomerID=BERGS OrderID=10672 Total=3815.25
CustomerID=BERGS OrderID=10857 Total=2048.21
CustomerID=BLONP OrderID=10360 Total=7390.20
CustomerID=BOLID OrderID=10801 Total=3026.85
CustomerID=BONAP OrderID=10340 Total=2436.18
CustomerID=BONAP OrderID=10511 Total=2550.00
CustomerID=BOTTM OrderID=10742 Total=3118.00
CustomerID=BOTTM OrderID=10949 Total=4422.00
CustomerID=CHOPS OrderID=10519 Total=2314.20
CustomerID=CHOPS OrderID=10746 Total=2311.70
CustomerID=COMMI OrderID=10290 Total=2169.00
CustomerID=EASTC OrderID=10400 Total=3063.00
CustomerID=EASTC OrderID=10987 Total=2772.00
CustomerID=EASTC OrderID=11056 Total=3740.00
CustomerID=ERNSH OrderID=10351 Total=5398.72
CustomerID=ERNSH OrderID=10382 Total=2900.00
CustomerID=ERNSH OrderID=10390 Total=2090.88
CustomerID=ERNSH OrderID=10402 Total=2713.50
CustomerID=ERNSH OrderID=10430 Total=4899.20
CustomerID=ERNSH OrderID=10514 Total=8623.45
CustomerID=ERNSH OrderID=10595 Total=4725.00
CustomerID=ERNSH OrderID=10633 Total=5510.59
CustomerID=ERNSH OrderID=10698 Total=3436.44
CustomerID=ERNSH OrderID=10764 Total=2286.00
CustomerID=ERNSH OrderID=10773 Total=2030.40
CustomerID=ERNSH OrderID=10776 Total=6635.28
CustomerID=ERNSH OrderID=10795 Total=2158.00
CustomerID=ERNSH OrderID=10836 Total=4705.50
CustomerID=ERNSH OrderID=10854 Total=2966.50
CustomerID=ERNSH OrderID=10895 Total=6379.40
CustomerID=ERNSH OrderID=10979 Total=4813.50
CustomerID=ERNSH OrderID=10990 Total=4288.85
CustomerID=ERNSH OrderID=11008 Total=4680.90
CustomerID=ERNSH OrderID=11017 Total=6750.00
CustomerID=ERNSH OrderID=11072 Total=5218.00
CustomerID=FOLIG OrderID=10634 Total=4985.50
CustomerID=FOLIG OrderID=10789 Total=3687.00
CustomerID=FOLKO OrderID=10533 Total=2222.20
CustomerID=FOLKO OrderID=10561 Total=2844.50
CustomerID=FOLKO OrderID=10703 Total=2545.00
CustomerID=FOLKO OrderID=10762 Total=4337.00
CustomerID=FOLKO OrderID=10977 Total=2233.00
CustomerID=FOLKO OrderID=10993 Total=4895.44
CustomerID=FOLKO OrderID=11001 Total=2769.00
CustomerID=FRANK OrderID=10267 Total=3536.60
CustomerID=FRANK OrderID=10337 Total=2467.00
CustomerID=FRANK OrderID=10670 Total=2301.75
CustomerID=FRANK OrderID=11012 Total=2825.30
CustomerID=GODOS OrderID=10629 Total=2775.05
CustomerID=GODOS OrderID=10872 Total=2058.46
CustomerID=GODOS OrderID=10948 Total=2362.25
CustomerID=GOURL OrderID=10709 Total=3424.00
CustomerID=GREAL OrderID=10616 Total=4807.00
CustomerID=GREAL OrderID=10816 Total=8446.45
CustomerID=HANAR OrderID=10886 Total=3127.50
CustomerID=HANAR OrderID=10981 Total=15810.00
CustomerID=HILAA OrderID=10395 Total=2122.92
CustomerID=HILAA OrderID=10490 Total=3163.20
CustomerID=HILAA OrderID=10601 Total=2285.00
CustomerID=HILAA OrderID=10641 Total=2054.00
CustomerID=HILAA OrderID=10796 Total=2341.36
CustomerID=HUNGO OrderID=10298 Total=2645.00
CustomerID=HUNGO OrderID=10335 Total=2036.16
CustomerID=HUNGO OrderID=10503 Total=2048.50
CustomerID=HUNGO OrderID=10516 Total=2381.05
CustomerID=HUNGO OrderID=10567 Total=2519.00
CustomerID=HUNGO OrderID=10687 Total=4960.90
CustomerID=HUNGO OrderID=10701 Total=2864.50
CustomerID=HUNGO OrderID=10897 Total=10835.24
CustomerID=HUNGO OrderID=10912 Total=6200.55
CustomerID=HUNGO OrderID=10985 Total=2023.38
CustomerID=KOENE OrderID=10718 Total=3463.00
CustomerID=KOENE OrderID=10817 Total=10952.84
CustomerID=KOENE OrderID=10893 Total=5502.11
CustomerID=KOENE OrderID=11028 Total=2160.00
CustomerID=LAMAI OrderID=10413 Total=2123.20
CustomerID=LAMAI OrderID=10787 Total=2622.76
CustomerID=LEHMS OrderID=10522 Total=2318.24
CustomerID=LEHMS OrderID=10772 Total=3603.22
CustomerID=LILAS OrderID=10823 Total=2826.00
CustomerID=LINOD OrderID=10638 Total=2720.05
CustomerID=LINOD OrderID=11039 Total=3090.00
CustomerID=MAISD OrderID=10760 Total=2917.00
CustomerID=MAISD OrderID=10892 Total=2090.00
CustomerID=MEREP OrderID=10339 Total=3354.00
CustomerID=MEREP OrderID=10424 Total=9194.56
CustomerID=MEREP OrderID=10570 Total=2465.25
CustomerID=MEREP OrderID=10605 Total=4109.70
CustomerID=MEREP OrderID=10618 Total=2697.50
CustomerID=MORGK OrderID=10575 Total=2147.40
CustomerID=OCEAN OrderID=10986 Total=2220.00
CustomerID=OLDWO OrderID=10305 Total=3741.30
CustomerID=OLDWO OrderID=10855 Total=2227.89
CustomerID=OTTIK OrderID=10766 Total=2310.00
CustomerID=PICCO OrderID=10353 Total=8593.28
CustomerID=PICCO OrderID=10530 Total=4180.00
CustomerID=PICCO OrderID=11053 Total=3055.00
CustomerID=PRINI OrderID=11007 Total=2633.90
CustomerID=QUEEN OrderID=10372 Total=9210.90
CustomerID=QUEEN OrderID=10637 Total=2761.94
CustomerID=QUEEN OrderID=11068 Total=2027.08
CustomerID=QUICK OrderID=10273 Total=2037.28
CustomerID=QUICK OrderID=10286 Total=3016.00
CustomerID=QUICK OrderID=10345 Total=2924.80
CustomerID=QUICK OrderID=10361 Total=2046.24
CustomerID=QUICK OrderID=10451 Total=3849.66
CustomerID=QUICK OrderID=10515 Total=9921.30
CustomerID=QUICK OrderID=10540 Total=10191.70
CustomerID=QUICK OrderID=10549 Total=3554.28
CustomerID=QUICK OrderID=10588 Total=3120.00
CustomerID=QUICK OrderID=10658 Total=4464.60
CustomerID=QUICK OrderID=10691 Total=10164.80
CustomerID=QUICK OrderID=10694 Total=4825.00
CustomerID=QUICK OrderID=10745 Total=4529.80
CustomerID=QUICK OrderID=10845 Total=3812.70
CustomerID=QUICK OrderID=10865 Total=16387.50
CustomerID=QUICK OrderID=10938 Total=2731.88
CustomerID=QUICK OrderID=10962 Total=3584.00
CustomerID=QUICK OrderID=10991 Total=2296.00
CustomerID=QUICK OrderID=11021 Total=6306.24
CustomerID=RATTC OrderID=10314 Total=2094.30
CustomerID=RATTC OrderID=10316 Total=2835.00
CustomerID=RATTC OrderID=10401 Total=3868.60
CustomerID=RATTC OrderID=10479 Total=10495.60
CustomerID=RATTC OrderID=10598 Total=2388.50
CustomerID=RATTC OrderID=10852 Total=2984.00
CustomerID=RATTC OrderID=10889 Total=11380.00
CustomerID=RATTC OrderID=10988 Total=3574.80
CustomerID=RICAR OrderID=10851 Total=2603.00
CustomerID=RICSU OrderID=10255 Total=2490.50
CustomerID=RICSU OrderID=10419 Total=2097.60
CustomerID=RICSU OrderID=10666 Total=4666.94
CustomerID=RICSU OrderID=11033 Total=3232.80
CustomerID=SANTG OrderID=10831 Total=2684.40
CustomerID=SAVEA OrderID=10324 Total=5275.72
CustomerID=SAVEA OrderID=10393 Total=2556.95
CustomerID=SAVEA OrderID=10398 Total=2505.60
CustomerID=SAVEA OrderID=10440 Total=4924.14
CustomerID=SAVEA OrderID=10452 Total=2018.50
CustomerID=SAVEA OrderID=10510 Total=4707.54
CustomerID=SAVEA OrderID=10555 Total=2944.40
CustomerID=SAVEA OrderID=10607 Total=6475.40
CustomerID=SAVEA OrderID=10612 Total=6375.00
CustomerID=SAVEA OrderID=10657 Total=4371.60
CustomerID=SAVEA OrderID=10678 Total=5256.50
CustomerID=SAVEA OrderID=10711 Total=4451.70
CustomerID=SAVEA OrderID=10713 Total=2827.90
CustomerID=SAVEA OrderID=10714 Total=2205.75
CustomerID=SAVEA OrderID=10748 Total=2196.00
CustomerID=SAVEA OrderID=10757 Total=3082.00
CustomerID=SAVEA OrderID=10847 Total=4931.92
CustomerID=SAVEA OrderID=10894 Total=2753.10
CustomerID=SAVEA OrderID=10941 Total=4011.75
CustomerID=SAVEA OrderID=11030 Total=12615.05
CustomerID=SAVEA OrderID=11031 Total=2393.50
CustomerID=SAVEA OrderID=11064 Total=4330.40
CustomerID=SEVES OrderID=10359 Total=3471.68
CustomerID=SEVES OrderID=10523 Total=2444.31
CustomerID=SEVES OrderID=10804 Total=2278.40
CustomerID=SIMOB OrderID=10417 Total=11188.40
CustomerID=SIMOB OrderID=10802 Total=2942.81
CustomerID=SPECD OrderID=10964 Total=2052.50
CustomerID=SPLIR OrderID=10329 Total=4578.43
CustomerID=SPLIR OrderID=10369 Total=2390.40
CustomerID=SUPRD OrderID=10252 Total=3597.90
CustomerID=SUPRD OrderID=10302 Total=2708.80
CustomerID=SUPRD OrderID=10458 Total=3891.00
CustomerID=SUPRD OrderID=10841 Total=4581.00
CustomerID=SUPRD OrderID=10930 Total=2255.50
CustomerID=THEBI OrderID=10805 Total=2775.00
CustomerID=TORTU OrderID=10518 Total=4150.05
CustomerID=VAFFE OrderID=10465 Total=2518.00
CustomerID=VAFFE OrderID=10688 Total=3160.60
CustomerID=VICTE OrderID=10546 Total=2812.00
CustomerID=WARTH OrderID=10455 Total=2684.00
CustomerID=WARTH OrderID=10583 Total=2237.50
CustomerID=WHITC OrderID=10344 Total=2296.00
CustomerID=WHITC OrderID=10693 Total=2071.20
CustomerID=WHITC OrderID=10861 Total=3523.40
CustomerID=WHITC OrderID=11032 Total=8902.50

```

## SelectMany - Multiple from
This C# example uses the LINQ SelectMany method with a dynamic expression to filter on customers before selecting their orders. This makes the query more efficient by not selecting and then discarding orders for customers outside of Washington.

### LINQ
```csharp
private void uiSelectMany_Multiple_From_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiSelectMany_Multiple_From_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSelectMany_Multiple_From_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
CustomerID=LAZYK OrderID=10482
CustomerID=LAZYK OrderID=10545
CustomerID=TRAIH OrderID=10574
CustomerID=TRAIH OrderID=10577
CustomerID=TRAIH OrderID=10822
CustomerID=WHITC OrderID=10469
CustomerID=WHITC OrderID=10483
CustomerID=WHITC OrderID=10504
CustomerID=WHITC OrderID=10596
CustomerID=WHITC OrderID=10693
CustomerID=WHITC OrderID=10696
CustomerID=WHITC OrderID=10723
CustomerID=WHITC OrderID=10740
CustomerID=WHITC OrderID=10861
CustomerID=WHITC OrderID=10904
CustomerID=WHITC OrderID=11032
CustomerID=WHITC OrderID=11066

```


## SelectMany - Indexed
This C# example uses the LINQ Indexed SelectMany method with a dynamic expression to select all orders, while referring to customers by the order in which they are returned from the query.

### LINQ
```csharp
private void uiSelectMany_Indexed_LINQ_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
}
```

### LINQ Dynamic
```csharp
private void uiSelectMany_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();
	
	My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
}
```

### LINQ Execute
```csharp
private void uiSelectMany_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
{
	var customers = My.GetCustomerList();

	var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

	var sb = new StringBuilder();

	My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
}
```

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Customer #1 has an order with OrderID 10643
Customer #1 has an order with OrderID 10692
Customer #1 has an order with OrderID 10702
Customer #1 has an order with OrderID 10835
Customer #1 has an order with OrderID 10952
Customer #1 has an order with OrderID 11011
Customer #2 has an order with OrderID 10308
Customer #2 has an order with OrderID 10625
Customer #2 has an order with OrderID 10759
Customer #2 has an order with OrderID 10926

...
Customer #90 has an order with OrderID 10248
Customer #90 has an order with OrderID 10615
Customer #90 has an order with OrderID 10673
Customer #90 has an order with OrderID 10695
Customer #90 has an order with OrderID 10873
Customer #90 has an order with OrderID 10879
Customer #90 has an order with OrderID 10910
Customer #90 has an order with OrderID 11005
Customer #91 has an order with OrderID 10374
Customer #91 has an order with OrderID 10611
Customer #91 has an order with OrderID 10792
Customer #91 has an order with OrderID 10870
Customer #91 has an order with OrderID 10906
Customer #91 has an order with OrderID 10998
Customer #91 has an order with OrderID 11044

```
