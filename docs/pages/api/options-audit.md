---
layout: default
title: Audit
permalink: audit
---

{% include template-h1.html %}

## Audit Options
- [UseAudit](#useaudit)

## UseAudit
Allow you to audit inserted/deleted rows from the database.

- Default Value: False

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.UseAudit = true;

bulk.BulkMerge(dt);

var auditEntries = bulk.AuditEntries;
{% endhighlight %}
