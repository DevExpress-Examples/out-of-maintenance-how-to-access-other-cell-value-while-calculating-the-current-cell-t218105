<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577133/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T218105)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/WebAppCustomCellValue/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/WebAppCustomCellValue/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/WebAppCustomCellValue/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/WebAppCustomCellValue/WebForm1.aspx.vb))
<!-- default file list end -->
# How to access other cell value while calculating the current cell
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t218105/)**
<!-- run online end -->


<p>This example shows how to calculate a percent of a current cell related to the first row value, regardless of the current sorting.</p>
<p>To accomplish this task, handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_CustomCellValuetopic">ASPxPivotGrid.CustomCellValue</a> event. To obtain a cell value, address it. Create arrays of row and column values corresponding to the desired cell, and call the GetCellValue method, passing them in arguments.</p>

<br/>


