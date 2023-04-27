Imports System.Data.SqlClient

Public Class DatabaseConnection

    Public Shared ReadOnly Property ConnectionString As String
        Get
            'Data Source=DESKTOP-8S284IC;Initial Catalog=aviationprojectDB;Integrated Security=True
            'Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True

            Return "Data Source=DESKTOP-8S284IC;Initial Catalog=aviationprojectDB;Integrated Security=True"
        End Get
    End Property

End Class
