using System;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;

namespace WebAppCustomCellValue
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        object beveragesValue = "Beverages";
        DevExpress.Web.ASPxPivotGrid.PivotGridField fieldPercentOfBeverages;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                // Creates and specifies a 'Percent' field.
                fieldPercentOfBeverages = ASPxPivotGrid1.Fields.Add("Extended Price",
                    PivotArea.DataArea);
                fieldPercentOfBeverages.Caption = "Percent";
                fieldPercentOfBeverages.CellFormat.FormatType = FormatType.Numeric;
                fieldPercentOfBeverages.CellFormat.FormatString = "P";
                fieldPercentOfBeverages.ID = "fieldPercent";
            }
        }

        protected void ASPxPivotGrid1_CustomCellValue(object sender,
            DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs e)
        {
            // Calculates 'Percent' field values.
            if (e.DataField.ID == "fieldPercent")
            {
                object[] columnPath = GetValues(e, true,
                    ASPxPivotGrid1.Fields.GetFieldByName("fieldCategoryName"), "Beverages");
                object[] rowPath = GetValues(e, false,
                    ASPxPivotGrid1.Fields.GetFieldByName("fieldCategoryName"), "Beverages");
                decimal beveragesValue =
                    Convert.ToDecimal(e.GetCellValue(columnPath, rowPath, e.DataField));
                if (beveragesValue == 0)
                    e.Value = null;
                else
                    e.Value = Convert.ToDecimal(e.Value) / beveragesValue;
            }
            else return;
        }
        object[] GetValues(DevExpress.Web.ASPxPivotGrid.PivotCellValueEventArgs e, bool isColumn,
            PivotGridFieldBase targetField, object targetValue)
        {
            DevExpress.Web.ASPxPivotGrid.PivotGridField[] fields = 
                isColumn ? e.GetColumnFields() : e.GetRowFields();
            object[] targetPath = new object[fields.Length];
            for (int i = 0; i < targetPath.Length; i++)
            {
                if (object.ReferenceEquals(fields[i], targetField))
                    targetPath[i] = targetValue;
                else
                    targetPath[i] = e.GetFieldValue(fields[i]);
            }
            return targetPath;
        }
    }
}