*Files to look at:*
* [DiagramClickBehavior.cs](./CS/dxSample/DiagramClickBehavior.cs) (VB: [DiagramClickBehavior.vb](./VB/dxSample/DiagramClickBehavior.vb))
* [MainWindow.xaml](./CS/dxSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/dxSample/MainWindow.xaml))
# How to execute an arbitrary action when a WPF diagram item is clicked
This example demonstrates how to catch the moment when one of diagram's child items is clicked and execute custom code there. The main idea of the implementation is to handle the standard [PreviewMouseDown](https://docs.microsoft.com/en-us/dotnet/api/system.windows.uielement.previewmousedown?view=netcore-3.1) event for DiagramControl (or DiagramDesignerControl) and call the [CalcHitItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.CalcHitItem.overloads) method to obtain a clicked element.
