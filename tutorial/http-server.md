---
layout: page
title: HttpServer Tool
menu_title: HttpServer Tool
type: tutorial
weight: 15
---

QuickFIX/n provides a simple HttpServer that can be used to observe
and manage certain aspects of the Sessions as defined in your settings file.

**Warning:** *Use at your own risk.  This might be better considered as a
demo or educational tool.  We don't recommend using it as a management
tool for a production system.*

It is simple to create and run:

```
# This should be in the same block that
#   instantiates & starts your initiator or acceptor

HttpServer srv = new HttpServer(
    "http://127.0.0.1:5080", sessionSettings);
srv.Start();
```

By pointing a browser to the site that it publishes,
you can observe your sessions, examine current
sequence numbers and logon status,
and review/toggle/adjust many session settings.

For an example of an app that uses it, see the "Executor" project in the Examples folder.

