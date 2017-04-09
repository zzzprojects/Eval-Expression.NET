---
layout: default
title: SQL Server
permalink: sql-server
---

{% include template-h1.html %}
## SQL Server Options
- [SqlBulkCopyOptions](#sqlbulkcopyoptions)

## SqlBulkCopyOptions
Allow you to set the SqlBulkCopyOptions to use when a strategy with the SqlBulkCopy is selected.

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.SqlBulkCopyOptions = SqlBulkCopyOptions.Default | SqlBulkCopyOptions.TableLock;

bulk.BulkMerge(dt);
{% endhighlight %}
