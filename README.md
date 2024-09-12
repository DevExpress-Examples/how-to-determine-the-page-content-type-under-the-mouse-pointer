<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/138298370/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830567)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
#  How to determine the page content type under the mouse pointer 

This example uses the [PdfViewerControl.HitTest](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.HitTest(System.Windows.Point)) method to determine the type of the page content under the mouse pointer.

This method returns a [PdfHitTestResult](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult) instance with information about the page content type (text, an image or annotation). You can get the page content type using the [ContentType](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.ContentType) property and the page content selection status using the [IsSelected](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfHitTestResult.IsSelected) property.

In this example, the retrieved information is shown on the **Content Type** ribbon page group.

Call the [PdfViewerControl.HitTest](https://docs.devexpress.com/WPF/DevExpress.Xpf.PdfViewer.PdfViewerControl.HitTest(System.Windows.Point)) method in the `PdfViewerControl.MouseMove` event handler to perform hit testing.

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-determine-the-page-content-type-under-the-mouse-pointer&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-determine-the-page-content-type-under-the-mouse-pointer&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
