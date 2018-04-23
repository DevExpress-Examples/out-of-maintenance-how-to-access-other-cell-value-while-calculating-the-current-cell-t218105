# How to access other cell value while calculating the current cell


<p>This example shows how to calculate a percent of a current cell related to the first row value, regardless of the current sorting.</p>
<p>To accomplish this task, handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_CustomCellValuetopic">ASPxPivotGrid.CustomCellValue</a> event. To obtain a cell value, address it. Create arrays of row and column values corresponding to the desired cell, and call the GetCellValue method, passing them in arguments.</p>

<br/>


