<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" 
    Inherits="WebAppCustomCellValue.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.15.0, Culture=neutral, 
    PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientIDMode="AutoID" 
            DataSourceID="AccessDataSource1" Theme="Metropolis" 
            OnCustomCellValue="ASPxPivotGrid1_CustomCellValue">
            <Fields>
                <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category" 
                    FieldName="CategoryName" ID="fieldCategoryName">
                </dx:PivotGridField>
                <dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="Country" ID="fieldCountry">
                </dx:PivotGridField>
                <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Price" 
                    FieldName="Extended Price" ID="fieldExtendedPrice">
                </dx:PivotGridField>
            </Fields>
            <OptionsView ShowRowGrandTotals="False" />
        </dx:ASPxPivotGrid>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/nwind.mdb" 
            SelectCommand="SELECT [CategoryName], [Country], [Extended Price] FROM [SalesPerson]">
        </asp:AccessDataSource>
    </div>
    </form>
</body>
</html>