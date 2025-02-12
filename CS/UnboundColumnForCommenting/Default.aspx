<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UnboundColumnForCommenting._Default" %>

<%@ Register Assembly="DevExpress.Web.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" KeyFieldName="ID" OnCustomUnboundColumnData="ASPxGridView1_CustomUnboundColumnData" OnRowUpdating="ASPxGridView1_RowUpdating" Width="307px">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="Name" ReadOnly="True" />
                <dx:GridViewDataTextColumn FieldName="Comment" UnboundType="String" />
                <dx:GridViewCommandColumn ShowEditButton="True" ShowCancelButton="True" ShowUpdateButton="True" ShowClearFilterButton="True" />
            </Columns>
        </dx:ASPxGridView>
    </div>
    </form>
</body>
</html>
