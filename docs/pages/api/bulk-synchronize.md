---
layout: default
title: Bulk Synchronize
permalink: bulk-synchronize
---

{% include template-h1.html %}

## Bulk Synchronize
Execute a SYNCHRONIZE operation. UPDATE existing rows matching the key, INSERT new rows and DELETE records from the destination not existing in the source.

### Example - Bulk Synchronize
{% highlight csharp %}
var dt = new DataTable();
// ...seed...

var bulk = new BulkOperation(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkSynchronize(dt);
{% endhighlight %}

### Example - Bulk Synchronize Generic
{% highlight csharp %}
var list = new List<Customer>();
// ...seed...

var bulk = new BulkOperation<Customer>(connection);

// Easy to customize
bulk.BatchSize = 1000;

// Easy to use
bulk.BulkSynchronize(customers);
{% endhighlight %}

### Performance Benchmarks

| Operations      | 1,000 Rows     | 10,000 Rows    | 100,000 Rows   | 1,000,000 Rows |
| :-------------- | -------------: | -------------: | -------------: | -------------: |
| BulkSynchronize | 65 ms          | 160 ms         | 1200 ms        | 12,000 ms      |
