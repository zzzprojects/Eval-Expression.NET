---
layout: default
title: Temporary Table
permalink: temporary-table
---

{% include template-h1.html %}
## Temporary Table Options
- [TemporaryTableBatchByTable](#temporarytablebatchbytable)
- [TemporaryTableInsertBatchSize](#temporarytableinsertbatchsize)
- [TemporaryTableMinRecord](#temporarytableminrecord)
- [TemporaryTableUseTableLock](#temporarytableusetablelock)



Customize how and when to use a temporary table instead of inline SQL.

**Properties:**
## TemporaryTableBatchByTable
Allow you to set the maximum number of batches a temporary table can contain.

- Default Value: 0 (unlimited)
### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.TemporaryTableBatchByTable = 5;

bulk.BulkMerge(dt);
{% endhighlight %}

## TemporaryTableInsertBatchSize
Allow you to set the number of record by batch to insert in a temporary table.

- Default Value: 10,000
### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.TemporaryTableInsertBatchSize = 1000;

bulk.BulkMerge(dt);
{% endhighlight %}

## TemporaryTableMinRecord
Allow you to set the minimum number of records before a temporary table strategy is used.

- Default Value: 10
### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.TemporaryTableMinRecord = 15;

bulk.BulkMerge(dt);
{% endhighlight %}

## TemporaryTableUseTableLock
Allow you to lock the temporary table while being populated.

- Default Value: true

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.TemporaryTableUseTableLock = true;

bulk.BulkMerge(dt);
{% endhighlight %}
