using DevExpress.Pdf;
using DevExpress.Xpf.PdfViewer;
using System.Windows;
using System.Windows.Input;

namespace DetermineContentType {

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            viewer.OpenDocument("..\\..\\demo.pdf");
        }

        private void viewer_MouseMove(object sender, MouseEventArgs e) {

            PdfHitTestResult result = viewer.HitTest(e.GetPosition(viewer));
            string contentTypeText = result.IsSelected ? "Selected " : "Unselected ";

            switch (result.ContentType) {
                case PdfDocumentContentType.Text:
                contentTypeText = contentTypeText + "Text";
                break;
                case PdfDocumentContentType.Image:
                contentTypeText = contentTypeText + " Image";
                break;
                case PdfDocumentContentType.Annotation:
                contentTypeText = contentTypeText + "Annotation";
                break;
                default:
                contentTypeText = "The content is empty";
                break;
            }
            barButtonItem.Content = contentTypeText;
        }
    }
}




