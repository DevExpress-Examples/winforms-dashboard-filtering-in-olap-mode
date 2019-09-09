<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_OlapFiltering/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_OlapFiltering/Form1.vb))
<!-- default file list end -->
# How to Apply Filter to Dashboard Item Data in OLAP Mode


This example demonstrates how to [apply filtering](http://docs.devexpress.com/Dashboard/15695) to a dashboard item's data in [OLAP mode](http://docs.devexpress.com/Dashboard/15707).

![](/images/screenshot.png)

The OLAP data connection uses the DevExpress demo HTTP data pump available online at demos.devexpress.com/Services/OLAP/msmdpump.dll.

The [DashboardOlapDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardOlapDataSource) instance is created at runtime. 

The filter string uses [criteria language syntax](https://docs.devexpress.com/CoreLibraries/4928) specific to Dashboards and includes a [dashboard parameter](https://docs.devexpress.com/Dashboard/116918).

> OLAP mode supports a limited number of criteria operators.