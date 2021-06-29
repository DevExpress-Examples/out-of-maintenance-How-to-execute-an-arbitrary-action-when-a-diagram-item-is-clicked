Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Diagram
Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Input

Namespace dxSample
	Public Class DiagramClickBehavior
		Inherits Behavior(Of DiagramControl)

		Private Sub AssociatedObject_PreviewMouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			Dim clickedItem = AssociatedObject.CalcHitItem(e.GetPosition(AssociatedObject))
			Dim tempVar As Boolean = TypeOf clickedItem Is DiagramItem
			Dim item As DiagramItem = If(tempVar, CType(clickedItem, DiagramItem), Nothing)
			If tempVar Then
				ThemedMessageBox.Show(owner:= Window.GetWindow(AssociatedObject), title:= "An item was clicked", text:= $"Item: {item.Name}{Environment.NewLine}Position: {item.Position}", messageBoxButtons:= MessageBoxButton.OK, icon:= MessageBoxImage.Information)
			End If
		End Sub

		Protected Overrides Sub OnAttached()
			MyBase.OnAttached()
			AddHandler AssociatedObject.PreviewMouseDown, AddressOf AssociatedObject_PreviewMouseDown
		End Sub
		Protected Overrides Sub OnDetaching()
			MyBase.OnDetaching()
			RemoveHandler AssociatedObject.PreviewMouseDown, AddressOf AssociatedObject_PreviewMouseDown
		End Sub
	End Class
End Namespace
