---
layout: default
title: LINQ Dynamic - Aggregate
description: C# Dynamic LINQ Aggregate examples using an Expression Evaluator.
permalink: linq-dynamic-aggregate-examples
---

{% include template-h1.html %}

## LINQ Dynamic Aggregate Examples
{{ page.description }}

- [Aggregate - Simple](#aggregate---simple)
- [Aggregate - Seed](#aggregate---seed)

## Aggregate - Simple
This C# example uses the LINQ Aggregate method with a dynamic expression to create a running product on the array that calculates the total product of all elements.

### LINQ
{% highlight csharp %}
double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

var product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

Console.WriteLine("Total product of all numbers: {0}", product);
{% endhighlight %}
{% include  component-try-it.html href='https://dotnetfiddle.net/BZLbt5' %}

### LINQ Execute
{% highlight csharp %}
double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

var product = doubles.Execute<double>("Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor)");

Console.WriteLine("Total product of all numbers: {0}", product);
{% include  component-try-it.html href='https://dotnetfiddle.net/HbOEOt' %}
{% endhighlight %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Total product of all numbers: 88.33081

{% endhighlight %}

## Aggregate - Seed
This C# example uses the LINQ Aggregate method with a dynamic expression to create a running account balance that subtracts each withdrawal from the initial balance of 100, as long as the balance never drops below 0.

### LINQ
{% highlight csharp %}
var startBalance = 100.0;

int[] attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30};

var endBalance = attemptedWithdrawals.Aggregate(startBalance, (balance, nextWithdrawal) => nextWithdrawal <= balance ? balance - nextWithdrawal : balance);

Console.WriteLine("Ending balance: {0}", endBalance);
{% endhighlight %}
{% include  component-try-it.html href='https://dotnetfiddle.net/LqobT0' %}

### LINQ Execute
{% highlight csharp %}
var startBalance = 100.0;

int[] attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30};

var endBalance = attemptedWithdrawals.Execute<double>("Aggregate(startBalance, (balance, nextWithdrawal) => ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance)", new {startBalance});

Console.WriteLine("Ending balance: {0}", endBalance);

{% endhighlight %}
{% include  component-try-it.html href='https://dotnetfiddle.net/p67L8v' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Ending balance: 20

{% endhighlight %}
