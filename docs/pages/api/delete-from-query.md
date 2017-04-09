---
layout: default
title: Delete from Query
permalink: delete-from-query
---

{% include template-h1.html %}

## Delete From Query
Execute a DELETE operation using a LINQ Query.

### Example
{% highlight csharp %}
var bulk = new BulkOperation<Customer>(connection);

// DELETE all customers inactive for more than 2 years
bulk.DeleteFromQuery(
    c => c.Where(x => x.LastLogin < DateTime.Now.AddYears(-2)));
{% endhighlight %}

### Performance Benchmarks

| Operations      | 1,000 Entities | 2,000 Entities | 5,000 Entities |
| :-------------- | -------------: | -------------: | -------------: |
| DeleteFromQuery | 1 ms           | 1 ms           | 1 ms           |

### Support
- SQL Server 2008+
- SQL Azure
