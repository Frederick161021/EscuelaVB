Imports Escolar.Contracts.DataTransferObjects
Imports Escolar.Contracts.DisplayObjects

Namespace Services
    Public Interface IAlumno
        Sub Agregar(ByVal dto As AlumnoDTO)
        Sub Actualizar(ByVal dto As AlumnoDTO)
        Sub Eliminar(ByVal matricula As Integer)
        Function Consultar() As DataTable
        Function Buscar(ByVal matricula As Integer) As AlumnoDTO
        'Function GetByFilter(ByVal dto As AlumnoDTO) As DataTable
        Function AlumnoGetConCarrera() As List(Of ALumnoDisplayObject)
    End Interface
End Namespace
