Imports System
Imports System.Data.Entity
Imports System.Linq
Imports System.ComponentModel.DataAnnotations
Public Class TaskDBContext
    Inherits DbContext
    Public Property Tasks() As DbSet(Of Task)

End Class

Public Class Task
    Public Property ID() As Integer

    <StringLength(60)>
    <Required(ErrorMessage:="Title is required")>
    Public Property Title() As String

    <StringLength(1000)>
    <Required(ErrorMessage:="Description is required")>
    Public Property Description() As String

    <DisplayFormat(DataFormatString:="{0:d}")>
    <Required(ErrorMessage:="Due date is required")>
    Public Property DueDate() As Date

    Public Property Done() As Boolean = False
End Class
