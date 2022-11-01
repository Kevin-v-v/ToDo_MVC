Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ToDo_MVC

Namespace Controllers
    Public Class TasksController
        Inherits System.Web.Mvc.Controller

        Private db As New TaskDBContext

        ' GET: Tasks
        Function Index() As ActionResult
            Return View(db.Tasks.ToList())
        End Function

        ' GET: Tasks/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim task As Task = db.Tasks.Find(id)
            If IsNothing(task) Then
                Return HttpNotFound()
            End If
            Return View(task)
        End Function

        ' GET: Tasks/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tasks/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Title,Description,DueDate,Done")> ByVal task As Task) As ActionResult
            If ModelState.IsValid Then
                db.Tasks.Add(task)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(task)
        End Function

        ' GET: Tasks/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim task As Task = db.Tasks.Find(id)
            If IsNothing(task) Then
                Return HttpNotFound()
            End If
            Return View(task)
        End Function

        ' POST: Tasks/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Title,Description,DueDate,Done")> ByVal task As Task) As ActionResult
            If ModelState.IsValid Then
                db.Entry(task).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(task)
        End Function

        ' GET: Tasks/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim task As Task = db.Tasks.Find(id)
            If IsNothing(task) Then
                Return HttpNotFound()
            End If
            Return View(task)
        End Function

        ' POST: Tasks/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim task As Task = db.Tasks.Find(id)
            db.Tasks.Remove(task)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
