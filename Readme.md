<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608357/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3862)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Word Processing Document API - Print Fixed Documents in WPF Application

This example demonstrates how to use the [RichEditDocumentXpfPrinter.CreateFixedDocument](https://docs.devexpress.com/WPF/DevExpress.Xpf.RichEdit.RichEditDocumentXpfPrinter.CreateFixedDocument(DevExpress.XtraRichEdit.IRichEditDocumentServer)) method to create a [fixed document](https://docs.microsoft.com/en-us/dotnet/api/system.windows.documents.fixeddocument) from a document loaded to the Word Processing Document API. A custom method iterates all available printers, chooses the printer that contains "Canon" in its name, and invokes the [PrintDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.printdialog) to print the document.

> [!Important]  
> The Universal Subscription or an additional Office File API Subscription is required to use this example in production code. For pricing information, please refer to the [DevExpress Subscription](https://www.devexpress.com/Subscriptions/) page. 

<!-- default file list -->
## Files to Look At

[MainWindow.xaml.cs](./CS/RichEditDocumentServer_Print/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/RichEditDocumentServer_Print/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation

[Printing](https://docs.devexpress.com/OfficeFileAPI/17580/word-processing-document-api/printing)
<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=word-document-api-print-fixed-documents-in-wpf-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=word-document-api-print-fixed-documents-in-wpf-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
