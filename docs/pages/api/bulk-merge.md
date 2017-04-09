---
layout: default
title: Bulk Merge
permalink: bulk-merge
---

{% include template-h1.html %}

## Bulk Merge
Execute a MERGE/UPSERT operation. UPDATE existing rows matching the key, and INSERT new rows.

### Example - Bulk Merge
{% highlight csharp %}
var dt = new DataTable();
// ...seed...

var bulk = new BulkOperation(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkMerge(dt);
{% endhighlight %}

### Example - Bulk Merge Generic
{% highlight csharp %}
var list = new List<Customer>();
// ...seed...

var bulk = new BulkOperation<Customer>(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkMerge(customers);
{% endhighlight %}

### Performance Benchmarks

| Operations      | 1,000 Rows     | 10,000 Rows    | 100,000 Rows   | 1,000,000 Rows |
| :-------------- | -------------: | -------------: | -------------: | -------------: |
| BulkMerge       | 65 ms          | 160 ms         | 1200 ms        | 12,000 ms      |
