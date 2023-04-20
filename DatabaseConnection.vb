Imports System.Data.SqlClient

Public Class DatabaseConnection

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
        End Get
    End Property

End Class
