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


