---
layout: default
title: Bulk Generic Methods
permalink: tutorial-bulk-generic-methods
---

{% include template-h1.html %}

## Introduction
Bulk Generic Methods allow you to work with strongly type expression.

| Name      | Description |
| :-------------- | :------------- |
| BulkInsert      | Execute an INSERT operation. |
| BulkUpdate      | Execute an UPDATE operation. |
| BulkDelete      | Execute a DELETE operation. |
| BulkMerge       | Execute a MERGE/UPSERT operation. UPDATE existing rows matching the key, and INSERT new rows. |
| BulkSynchronize | Execute a SYNCHRONIZE operation. UPDATE existing rows matching the key, INSERT new rows and DELETE records from the destination not existing in the source. |

### Example

{% highlight csharp %}
var list = new List<Customer>();
// ...seed...

var bulk = new BulkOperation<Customer>(connection);

// Easy to customize
bulk.BatchSize = 1000;
bulk.ColumnInputExpression = c => new { c.Name,  c.FirstName };
bulk.ColumnOutputExpression = c => c.CustomerID;
bulk.ColumnPrimaryKeyExpression = c => c.Code;

// Easy to use
bulk.BulkInsert(customers);
bulk.BulkUpdate(customers);
bulk.BulkDelete(customers);
bulk.BulkMerge(customers);

{% endhighlight %}

### Performance Benchmark

| Operations      | 1,000 Rows     | 10,000 Rows    | 100,000 Rows   | 1,000,000 Rows |
| :-------------- | -------------: | -------------: | -------------: | -------------: |
| BulkInsert      | 6 ms           | 25 ms          | 200 ms         | 2,000 ms       |
| BulkUpdate      | 50 ms          | 80 ms          | 575 ms         | 6,500 ms       |
| BulkDelete      | 45 ms          | 70 ms          | 625 ms         | 6,800 ms       |
| BulkMerge       | 65 ms          | 160 ms         | 1200 ms        | 12,000 ms      |

