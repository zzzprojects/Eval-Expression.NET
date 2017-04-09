---
layout: default
title: Log
permalink: log
---

{% include template-h1.html %}
## Log Options
- [Log](#log)
- [UseLogDump](#uselogdump)
- [LogDump](#logdump)

## Log
Allow you to log some event happening in your database.

### Example
{% highlight csharp %}
StringBuilder logger = new StringBuilder();
var bulk = new BulkOperation(connection);

bulk.Log += s => logger.AppendLine(s);

bulk.BulkMerge(dt);
{% endhighlight %}

## UseLogDump
Allow you to log in a string (LogDump) event happening in your database.

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.UseLogDump = true;

bulk.BulkMerge(dt);

var logDump = bulk.LogDump;
{% endhighlight %}

## LogDump
Allow you to retrieve event happening in your database when UseLogDump is enabled.

### Example
{% highlight csharp %}
var bulk = new BulkOperation(connection);

bulk.UseLogDump = true;

bulk.BulkMerge(dt);

var logDump = bulk.LogDump;
{% endhighlight %}
