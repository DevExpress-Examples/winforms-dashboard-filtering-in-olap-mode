<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580707/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5148)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# BI Dashboard for WinForms - How to Apply Filter to Dashboard Item Data in OLAP Mode

This example demonstrates how to [apply filtering](http://docs.devexpress.com/Dashboard/15695) to a dashboard item's data in [OLAP mode](http://docs.devexpress.com/Dashboard/15707).

![](/images/screenshot.png)

The OLAP data connection uses the DevExpress demo HTTP data pump available online at demos.devexpress.com/Services/OLAP/msmdpump.dll.

The [DashboardOlapDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardOlapDataSource) instance is created at runtime. 

The filter string uses [criteria language syntax](https://docs.devexpress.com/CoreLibraries/4928) specific to Dashboards and includes a [dashboard parameter](https://docs.devexpress.com/Dashboard/116918).

> OLAP mode supports a limited number of criteria operators.

## Files to Review

* [Form1.cs](./CS/Dashboard_OlapFiltering/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_OlapFiltering/Form1.vb))

## Documentation
- [OLAP Data Source](https://docs.devexpress.com/Dashboard/114427)
- [Expression Constants, Operators, and Functions](https://docs.devexpress.com/Dashboard/400122)
- [Dashboard Parameters](https://docs.devexpress.com/Dashboard/16135)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-filtering-in-olap-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-filtering-in-olap-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
