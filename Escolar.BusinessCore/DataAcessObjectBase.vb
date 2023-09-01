Imports System.Data.SqlClient
Public Class DataAcessObjectBase
    Protected conexion As SqlConnection
    Protected comando As SqlCommand

    Sub New()
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source = LAPTOP-MD1PVDHP\SQLEXPRESS; Integrated Security =true; Initial Catalog=Escuela;"
        conexion.Open()

        comando = New SqlCommand()
    End Sub

    Sub addParameter(ByVal nombre As String, ByVal valor As Object, ByVal tipo As SqlDbType)
        Dim parametro = New SqlParameter

        parametro = New SqlParameter()
        parametro.ParameterName = nombre
        parametro.Value = valor
        parametro.SqlDbType = tipo
        comando.Parameters.Add(parametro)
    End Sub

    Sub addOutParameter(ByVal nombre As String, ByVal valor As Object, ByVal tipo As SqlDbType, ByVal tamaño As Integer)
        Dim parametro = New SqlParameter

        parametro = New SqlParameter()
        parametro.ParameterName = nombre
        parametro.SqlDbType = tipo
        parametro.Size = tamaño
        parametro.Direction = ParameterDirection.Output
        Debug.Print(parametro.ToString)
        comando.Parameters.Add(parametro)
    End Sub

    Function OutputParameter(ByVal nombre As String) As Object
        Return comando.Parameters(nombre).Value
    End Function


    Sub Execute(ByVal nombre As String)
        comando.CommandText = nombre
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexion
        comando.ExecuteNonQuery()
    End Sub

    Function ExecuteResultSet(ByVal nombre As String) As DataSet
        comando.CommandText = nombre
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexion
        comando.ExecuteNonQuery()

        Dim resultados As DataSet = New DataSet()

        Dim adaptador As SqlDataAdapter = New SqlDataAdapter()
        adaptador.SelectCommand = comando

        adaptador.Fill(resultados)
        Return resultados

    End Function

End Class
