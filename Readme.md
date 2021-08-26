<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/381394919/21.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1010572)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
*Files to look at:*
* [DiagramClickBehavior.cs](./CS/dxSample/DiagramClickBehavior.cs) (VB: [DiagramClickBehavior.vb](./VB/dxSample/DiagramClickBehavior.vb))
* [MainWindow.xaml](./CS/dxSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/dxSample/MainWindow.xaml))
# How to execute an arbitrary action when a WPF diagram item is clicked
This example demonstrates how to catch the moment when one of diagram's child items is clicked and execute custom code there. The main idea of the implementation is to handle the standard [PreviewMouseDown](https://docs.microsoft.com/en-us/dotnet/api/system.windows.uielement.previewmousedown?view=netcore-3.1) event for DiagramControl (or DiagramDesignerControl) and call the [CalcHitItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.CalcHitItem.overloads) method to obtain a clicked element.
