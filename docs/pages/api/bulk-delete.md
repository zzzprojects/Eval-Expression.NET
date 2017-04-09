---
layout: default
title: Bulk Delete
permalink: bulk-delete
---

{% include template-h1.html %}

## Bulk Delete
Execute a DELETE operation.

### Example - Bulk Insert
{% highlight csharp %}
var dt = new DataTable();
// ...seed...

var bulk = new BulkOperation(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkDelete(dt);
{% endhighlight %}

### Example - Bulk Insert Generic
{% highlight csharp %}
var list = new List<Customer>();
// ...seed...

var bulk = new BulkOperation<Customer>(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkDelete(customers);
{% endhighlight %}

### Performance Benchmarks

| Operations      | 1,000 Rows     | 10,000 Rows    | 100,000 Rows   | 1,000,000 Rows |
| :-------------- | -------------: | -------------: | -------------: | -------------: |
| BulkDelete      | 45 ms          | 70 ms          | 625 ms         | 6,800 ms       |
