<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/138298370/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830567)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
#  How to determine the page content type under the mouse pointer 


<p>This example illustrates how to use the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.HitTest.method">PdfViewerControl.HitTest</a>  method to determine the type of the page content under the mouse pointer.</p>

<p>This method returns a <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.class">PdfHitTestResult</a> instance with information about the page content type (text, an image or annotation). You can get the page content type using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.ContentType.property">ContentType</a>  property and the page content selection status using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.IsSelected.property">IsSelected</a> property. </p>

<p>In this example, the retrieved information is shown on the <strong>Content Type</strong> ribbon page group. </p>

<p>Call the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.HitTest.method">PdfViewerControl.HitTest</a>  method in the <strong>PdfViewerControl.MouseMove</strong> event handler to perform hit testing. </p>
<br/>
