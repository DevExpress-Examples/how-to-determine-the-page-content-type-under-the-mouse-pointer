#  How to determine the page content type under the mouse pointer 


<p>This example illustrates how to use the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.HitTest.method">PdfViewerControl.HitTest</a>  method to determine the type of the page content under the mouse pointer.</p>

<p>This method returns a <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.class">PdfHitTestResult</a> instance with information about the page content type (text, an image or annotation). You can get the page content type using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.ContentType.property">ContentType</a>  property and the page content selection status using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.IsSelected.property">IsSelected</a> property. </p>

<p>In this example, the retrieved information is shown on the <strong>Content Type</strong> ribbon page group. </p>

<p>Call the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.HitTest.method">PdfViewerControl.HitTest</a>  method in the <strong>PdfViewerControl.MouseMove</strong> event handler to perform hit testing. </p>
<br/>
