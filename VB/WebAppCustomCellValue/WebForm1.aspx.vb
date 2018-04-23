Imports System
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils

Namespace WebAppCustomCellValue
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Private beveragesValue As Object = "Beverages"
        Private fieldPercentOfBeverages As DevExpress.Web.ASPxPivotGrid.PivotGridField

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If (Not IsPostBack) AndAlso (Not IsCallback) Then
                ' Creates and specifies a 'Percent' field.
                fieldPercentOfBeverages = ASPxPivotGrid1.Fields.Add("Extended Price", PivotArea.DataArea)
                fieldPercentOfBeverages.Caption = "Percent"
                fieldPercentOfBeverages.CellFormat.FormatType = FormatType.Numeric
                fieldPercentOfBeverages.CellFormat.FormatString = "P"
                fieldPercentOfBeverages.ID = "fieldPercent"
            End If
        End Sub

        Protected Sub ASPxPivotGrid1_CustomCellValue(ByVal sender As Object, 
		ByVal e As DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs)
            ' Calculates 'Percent' field values.
            If e.DataField.ID = "fieldPercent" Then
                Dim columnPath() As Object = GetValues(e, True, 
				ASPxPivotGrid1.Fields.GetFieldByName("fieldCategoryName"), "Beverages")
                Dim rowPath() As Object = GetValues(e, False, 
				ASPxPivotGrid1.Fields.GetFieldByName("fieldCategoryName"), "Beverages")
                Dim beveragesValue As Decimal = 
				Convert.ToDecimal(e.GetCellValue(columnPath, rowPath, e.DataField))
                If beveragesValue = 0 Then
                    e.Value = Nothing
                Else
                    e.Value = Convert.ToDecimal(e.Value) / beveragesValue
                End If
            Else
                Return
            End If
        End Sub
        Private Function GetValues(ByVal e As DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs, 
		ByVal isColumn As Boolean, ByVal targetField As PivotGridFieldBase, 
		ByVal targetValue As Object) As Object()
            Dim fields() As DevExpress.Web.ASPxPivotGrid.PivotGridField = 
			If(isColumn, e.GetColumnFields(), e.GetRowFields())
            Dim targetPath(fields.Length - 1) As Object
            For i As Integer = 0 To targetPath.Length - 1
                If Object.ReferenceEquals(fields(i), targetField) Then
                    targetPath(i) = targetValue
                Else
                    targetPath(i) = e.GetFieldValue(fields(i))
                End If
            Next i
            Return targetPath
        End Function
    End Class
End Namespace