Imports DevExpress.Pdf
Imports DevExpress.Xpf.PdfViewer
Imports System.Windows
Imports System.Windows.Input

Namespace DetermineContentType

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            viewer.OpenDocument("..\..\demo.pdf")
        End Sub

        Private Sub viewer_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

            Dim result As PdfHitTestResult = viewer.HitTest(e.GetPosition(viewer))
            Dim contentTypeText As String = If(result.IsSelected, "Selected ", "Unselected ")

            Select Case result.ContentType
                Case PdfDocumentContentType.Text
                contentTypeText = contentTypeText & "Text"
                Case PdfDocumentContentType.Image
                contentTypeText = contentTypeText & " Image"
                Case PdfDocumentContentType.Annotation
                contentTypeText = contentTypeText & "Annotation"
                Case Else
                contentTypeText = "The content is empty"
            End Select
            barButtonItem.Content = contentTypeText
        End Sub
    End Class
End Namespace




