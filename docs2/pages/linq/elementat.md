---
layout: default
title: LINQ Dynamic - ElementAt
description: C# Dynamic LINQ ElementAt examples using an Expression Evaluator.
permalink: linq-dynamic-elementat-examples
---



## LINQ Dynamic ElementAt Examples
{{ page.description }}

- [ElementAt](#elementat)
- [Where - Simple 2](#where---simple-2)
- [Where - Simple 3](#where---simple-3)
- [Where - Drilldown](#where---drilldown)
- [Where - Indexed](#where---indexed)

## ElementAt
This C# example uses the LINQ ElementAt method with a dynamic expression to retrieve the second number greater than 5 from an array.

### LINQ
```csharp
int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

var fourthLowNum = numbers.Where(n => n > 5).ElementAt(1); // second number is index 1 because sequences use 0-based indexing 

Console.WriteLine("Second number > 5: {0}", fourthLowNum);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/ML8HVw' %}

### LINQ Execute
```csharp
int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

var fourthLowNum = numbers.Where(n => n > 5).Execute<int>("ElementAt(1)"); // second number is index 1 because sequences use 0-based indexing 

Console.WriteLine("Second number > 5: {0}", fourthLowNum);
```
{% include  component-try-it.html href='https://dotnetfiddle.net/C77VYn' %}

### Result
{% highlight text %}
LINQ Execute Test
------------------------------
Second number > 5: 8

```
