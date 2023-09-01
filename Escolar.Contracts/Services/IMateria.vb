Imports Escolar.Contracts.DataTransferObjects

Namespace Services
    Public Interface IMateria
        Sub Agregar(ByVal dto As MateriaDTO)
        Sub Actualizar(ByVal dto As MateriaDTO)
        Sub Eliminar(ByVal Clave As Integer)
        Function Consultar() As DataTable
        Function Buscar(ByVal Clave As Integer) As MateriaDTO
    End Interface
End Namespace
