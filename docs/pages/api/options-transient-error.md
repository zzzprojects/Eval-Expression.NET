---
layout: default
title: Transient Error
permalink: transient-error
---

{% include template-h1.html %}
## Transient Error Options
- [RetryCount](#retrycount)
- [RetryInterval](#retryinterval)

## RetryCount
Allow you to set how many time the bulk operation should retry the operation when a transient error occurs.

### Example

{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.RetryCount = 3;

bulk.BulkMerge(dt);
{% endhighlight %}

## RetryInterval
Allow you to set how many time to wait before trying an operation again when a transient error occurs.

### Example

{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.RetryCount = 3;
bulk.RetryInterval = new TimeSpan(100);

bulk.BulkMerge(dt);
{% endhighlight %}
