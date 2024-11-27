Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace UnboundColumnForCommenting

    Public Partial Class _Default
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxGridView1.DataSource = GetData()
            If Not IsPostBack AndAlso Not IsCallback Then
                ' pre-define one comment
                SetComment(2, "It's me")
                ' call DataBind on the first page load 
                ' if the grid's DataSource is assigned in code behind
                ASPxGridView1.DataBind()
            End If
        End Sub

        Private Function GetData() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("Name")
            table.Rows.Add(1, "Max")
            table.Rows.Add(2, "Nick")
            table.Rows.Add(3, "Plato")
            Return table
        End Function

        ' Fetch unbound data here
        Protected Sub ASPxGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDataEventArgs)
            If e.IsGetData AndAlso Equals(e.Column.FieldName, "Comment") Then
                Dim key As Object = e.GetListSourceFieldValue(e.ListSourceRowIndex, ASPxGridView1.KeyFieldName)
                e.Value = GetComment(key)
            End If
        End Sub

        ' Persist unbound data here
        Protected Sub ASPxGridView1_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
            ' main data is read-only to keep this example simple
            e.Cancel = True
            ASPxGridView1.CancelEdit()
            ' only unbound data is editable
            Dim key As Object = e.Keys(0)
            Dim newComment As String = CStr(e.NewValues("Comment"))
            SetComment(key, newComment)
        End Sub
    End Class
End Namespace
