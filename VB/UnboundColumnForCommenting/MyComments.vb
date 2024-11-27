Imports System.Web
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections

Namespace UnboundColumnForCommenting

    Public Module MyComments

        Const StorageName As String = "MyComments"

        Private Property Storage As Hashtable
            Get
                Return CType(HttpContext.Current.Session(StorageName), Hashtable)
            End Get

            Set(ByVal value As Hashtable)
                HttpContext.Current.Session(StorageName) = value
            End Set
        End Property

        Public Function GetComment(ByVal rowKey As Object) As String
            Dim hash As Hashtable = Storage
            If hash IsNot Nothing Then Return CStr(hash(rowKey))
            Return Nothing
        End Function

        Public Sub SetComment(ByVal rowKey As Object, ByVal comment As String)
            Dim hash As Hashtable = Storage
            If hash Is Nothing Then hash = New Hashtable()
            hash(rowKey) = comment
            Storage = hash
        End Sub
    End Module
End Namespace
