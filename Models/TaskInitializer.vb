
Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports Microsoft.VisualBasic.Devices

Namespace ToDo_MVC.Models
    Public Class TaskInitializer
        Inherits DropCreateDatabaseIfModelChanges(Of TaskDBContext)
        Protected Overrides Sub Seed(ByVal context As TaskDBContext)
            Dim tasks = New List(Of Task) From {
             New Task With {.Title = "Comprar comida", .Description = "Manzanas, peras, tunas", .DueDate = Date.Parse("2022-11-02"), .Done = False},
             New Task With {.Title = "Aprender ASP.NET", .Description = "En Visual Basic.NET con MVC", .DueDate = Date.Parse("2022-11-01"), .Done = False},
             New Task With {.Title = "Tarea de Criptografía", .Description = "Resumen de un documento de BCPs", .DueDate = Date.Parse("2022-11-01"), .Done = False},
             New Task With {.Title = "Tarea de Criptografía", .Description = "Investigacion de Kali Linux", .DueDate = Date.Parse("2022-11-08"), .Done = False}
             }
            tasks.ForEach(Function(d) context.Tasks.Add(d))
        End Sub
    End Class
End Namespace
