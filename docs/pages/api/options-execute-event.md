---
layout: default
title: Execute Event
permalink: execute-event
---

{% include template-h1.html %}
## Excecute Event Options
- [BulkOperationExecuting](#bulkoperationexecuting)
- [BulkOperationExecuted](#bulkoperationexecuted)

## BulkOperationExecuting
Allow you to change configuration before the bulk operation is executed.

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.BulkOperationExecuting = bulkOperation => { /* configuration */ };

bulk.BulkMerge(dt);
{% endhighlight %}

## BulkOperationExecuted
Allow you to change configuration after the bulk operation is executed.

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.BulkOperationExecuted = bulkOperation => { /* configuration */ };

bulk.BulkMerge(dt);
{% endhighlight %}
