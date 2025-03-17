This is the QuickFIX/n Core. This package contains the core QF/n engine, but none of the message definitions.

You most likely also need one or more message definition packages:
* If you are using a FIX4 release, you need the corresponding QuickFIXn.FIX4* package.
* If you are using a FIX5 release, you need the QuickFIXn.FIXT11 package **and**
  the corresponding QuickFIXn.FIX50* package

**This is an official NuGet package from QuickFIXEngine.org.**

# Attention!  The QuickFIXn.FIX4 and FIX5 message packages were renamed beginning with v1.14!

**Starting with v1.14, we removed the weird extra period from the package names so that they read easier.  
The packages have been renamed as follows:**
* ~~QuickFIX.FIX4.0.{ver}~~ becomes **QuickFIX.FIX40.{ver}**
* ~~QuickFIX.FIX4.1.{ver}~~ becomes **QuickFIX.FIX41.{ver}**
* ~~QuickFIX.FIX4.2.{ver}~~ becomes **QuickFIX.FIX42.{ver}**
* ~~QuickFIX.FIX4.3.{ver}~~ becomes **QuickFIX.FIX43.{ver}**
* ~~QuickFIX.FIX4.4.{ver}~~ becomes **QuickFIX.FIX44.{ver}**
* ~~QuickFIX.FIX5.0.{ver}~~ becomes **QuickFIX.FIX50.{ver}**
* ~~QuickFIX.FIX5.0SP1.{ver}~~ becomes **QuickFIX.FIX50SP1.{ver}**
* ~~QuickFIX.FIX5.0SP2.{ver}~~ becomes **QuickFIX.FIX50SP2.{ver}**
* ~~QuickFIX.FIXT1.1.{ver}~~ becomes **QuickFIX.FIXT11.{ver}**

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
