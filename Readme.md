<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3862)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Word Processing Document API - Print Fixed Documents in WPF Application

This example demonstrates how to use the [RichEditDocumentXpfPrinter.CreateFixedDocument](https://docs.devexpress.com/WPF/DevExpress.Xpf.RichEdit.RichEditDocumentXpfPrinter.CreateFixedDocument(DevExpress.XtraRichEdit.IRichEditDocumentServer)) method to create a [fixed document](https://docs.microsoft.com/en-us/dotnet/api/system.windows.documents.fixeddocument) from a document loaded to the Word Processing Document API. A custom method iterates all available printers, chooses the one that contains a word "Canon" in its name, and invokes the [PrintDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.printdialog) to print the fixed document.

<!-- default file list -->
## Files to Look At

[MainWindow.xaml.cs](./CS/RichEditDocumentServer_Print/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/RichEditDocumentServer_Print/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation

[Printing](https://docs.devexpress.com/OfficeFileAPI/17580/word-processing-document-api/printing#richeditdocumentxpfprinter-wpf)
