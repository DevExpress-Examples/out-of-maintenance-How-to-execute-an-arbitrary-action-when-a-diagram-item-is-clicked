using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Diagram;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace dxSample {
    public class DiagramClickBehavior : Behavior<DiagramControl> {
        private void AssociatedObject_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            var clickedItem = AssociatedObject.CalcHitItem(e.GetPosition(AssociatedObject));
            if (clickedItem is DiagramItem item) {
                ThemedMessageBox.Show(owner: Window.GetWindow(AssociatedObject),
                                      title: "An item was clicked",
                                      text: $"Item: {item.Name}{Environment.NewLine}Position: {item.Position}",
                                      messageBoxButtons: MessageBoxButton.OK,
                                      icon: MessageBoxImage.Information);
            }
        }

        protected override void OnAttached() {
            base.OnAttached();
            this.AssociatedObject.PreviewMouseDown += AssociatedObject_PreviewMouseDown;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            this.AssociatedObject.PreviewMouseDown -= AssociatedObject_PreviewMouseDown;
        }
    }
}
