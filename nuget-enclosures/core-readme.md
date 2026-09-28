This is the QuickFIX/n Core. This package contains the core QF/n engine, but none of the message definitions.

You most likely also need one or more message definition packages:
* If you are using a FIX4 release, you need the corresponding QuickFIXn.FIX4* package.
* If you are using a FIX5 release, you need the QuickFIXn.FIXT11 package **and**
  the corresponding QuickFIXn.FIX50* package

**This is an official NuGet package from QuickFIXEngine.org.**

# Attention!  The QuickFIXn.FIX4 and FIX5 message packages were renamed beginning with v1.14!

**Starting with v1.14, we removed the weird extra period from the package names so that they read easier.  
The packages have been renamed as follows:**
* ~~QuickFIXn.FIX4.0.{ver}~~ becomes **QuickFIXn.FIX40.{ver}**
* ~~QuickFIXn.FIX4.1.{ver}~~ becomes **QuickFIXn.FIX41.{ver}**
* ~~QuickFIXn.FIX4.2.{ver}~~ becomes **QuickFIXn.FIX42.{ver}**
* ~~QuickFIXn.FIX4.3.{ver}~~ becomes **QuickFIXn.FIX43.{ver}**
* ~~QuickFIXn.FIX4.4.{ver}~~ becomes **QuickFIXn.FIX44.{ver}**
* ~~QuickFIXn.FIX5.0.{ver}~~ becomes **QuickFIXn.FIX50.{ver}**
* ~~QuickFIXn.FIX5.0SP1.{ver}~~ becomes **QuickFIXn.FIX50SP1.{ver}**
* ~~QuickFIXn.FIX5.0SP2.{ver}~~ becomes **QuickFIXn.FIX50SP2.{ver}**
* ~~QuickFIXn.FIXT1.1.{ver}~~ becomes **QuickFIXn.FIXT11.{ver}**

When you update your QuickFIXn.Core nuget package, please change to the new message packages to keep the version numbers in sync!

---

**Free, Fast, Native.**  
**The best FIX Engine for .NET**  
**QuickFIX/n implements the [FIX protocol](https://www.fixtrading.org/what-is-fix/) on .NET.**

QuickFIX/n is 100% free and open source with a liberal license.

Visit [QuickFIXEngine.org](http://quickfixengine.org) for more information.  
Checkout the [tutorial](https://quickfixengine.org/n/documentation/).
or [examine some example applications](https://quickfixengine.org/n/documentation/#section-example-applications).

Commercial support provided by [Connamara](https://www.connamara.com/).
