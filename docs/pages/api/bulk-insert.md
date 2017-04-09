---
layout: default
title: Bulk Insert
permalink: bulk-insert
---

{% include template-h1.html %}

## Bulk Insert
Execute an INSERT operation.

### Example - Bulk Insert
{% highlight csharp %}
var dt = new DataTable();
// ...seed...

var bulk = new BulkOperation(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkInsert(dt);
{% endhighlight %}

### Example - Bulk Insert Generic
{% highlight csharp %}
var list = new List<Customer>();
// ...seed...

var bulk = new BulkOperation<Customer>(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkInsert(customers);
{% endhighlight %}

### Performance Benchmarks

| Operations      | 1,000 Rows     | 10,000 Rows    | 100,000 Rows   | 1,000,000 Rows |
| :-------------- | -------------: | -------------: | -------------: | -------------: |
| BulkInsert      | 6 ms           | 25 ms          | 200 ms         | 2,000 ms       |
