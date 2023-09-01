Imports Escolar.Contracts.DataTransferObjects

Namespace Services
    Public Interface IAlumnoMateria
        Sub Agregar(ByVal dto As AlumnoMateriaDTO)
        Function Consultar(ByVal matricula As Integer) As DataTable
    End Interface
End Namespace
