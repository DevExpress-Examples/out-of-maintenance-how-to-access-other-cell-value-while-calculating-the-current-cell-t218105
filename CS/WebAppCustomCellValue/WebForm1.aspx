<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" 
    Inherits="WebAppCustomCellValue.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v21.2, Version=21.2.14.0, Culture=neutral, 
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
            DataSourceID="SqlDataSource1" Theme="Metropolis" 
            OnCustomCellValue="ASPxPivotGrid1_CustomCellValue"
            OptionsData-DataProcessingEngine="Optimized" IsMaterialDesign="False">
            <Fields>
                <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category" ID="fieldCategoryName">
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="CategoryName" />
                    </DataBindingSerializable>
                </dx:PivotGridField>
                <dx:PivotGridField Area="ColumnArea" AreaIndex="0" ID="fieldCountry">
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="Country" />
                    </DataBindingSerializable>
                </dx:PivotGridField>
                <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Price" ID="fieldExtendedPrice">
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="Extended Price" />
                    </DataBindingSerializable>
                </dx:PivotGridField>
            </Fields>
            <OptionsView ShowRowGrandTotals="False" />

<OptionsData DataProcessingEngine="Optimized"></OptionsData>
        </dx:ASPxPivotGrid>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT [CategoryName], [Country], [Extended Price] FROM [SalesPerson]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
