---
layout: default
title: From Query Methods
permalink: tutorial-from-query-methods
---

{% include template-h1.html %}

## Introduction
FromQuery operations allow you to use LINQ Query to execute an operation directly in the database

| Name      | Description |
| :-------------- | :------------- |
| DeleteFromQuery | Execute a DELETE operation using a LINQ Query. |
| UpdateFromQuery | Execute an UPDATE operation using a LINQ Query. |



### Example
{% highlight csharp %}
var bulk = new BulkOperation<Customer>(connection);

// DELETE all customers inactive for more than 2 years
bulk.DeleteFromQuery(
    c => c.Where(x => x.LastLogin < DateTime.Now.AddYears(-2)));

// UPDATE all customers inactive for more than 2 years
bulk.UpdateFromQuery(
    c => c.Where(x => x.Actif && x.LastLogin < DateTime.Now.AddYears(-2)),
    c => new Customer {Actif = false});
{% endhighlight %}


### Performance Benchmarks

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| DeleteFromQuery | 1 ms           | 1 ms           | 1 ms           |
| UpdateFromQuery | 1 ms           | 1 ms           | 1 ms           |

### Support
- SQL Server 2008+
- SQL Azure
