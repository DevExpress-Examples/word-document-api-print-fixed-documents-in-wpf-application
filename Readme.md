<!-- default badges list -->
<<<<<<< HEAD
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608357/13.2.12%2B)
=======
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608357/14.1.8%2B)
>>>>>>> 14.1.8+
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3862)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml.cs](./CS/RichEditDocumentServer_Print/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/RichEditDocumentServer_Print/MainWindow.xaml.vb))
<!-- default file list end -->
# How to print from RichEditDocumentServer in WPF application


<p>This example utilizes the <a href="https://documentation.devexpress.com/WPF/DevExpress.XtraRichEdit.Printing.XpfRichEditPrinter.class">DevExpress.XtraRichEdit.Printing.XpfRichEditPrinter</a> descendant to print the document loaded into the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditRichEditDocumentServertopic"><u>RichEditDocumentServer</u></a> instance. A custom method iterates all available printers and chooses the one that contains a word "Canon" in its name.</p>
<p>Starting from v2014 vol.1.8 (and also v2013 starting from vol.2.12) the <a href="https://documentation.devexpress.com/WPF/DevExpress.XtraRichEdit.Printing.XpfRichEditPrinter.class">DevExpress.XtraRichEdit.Printing.XpfRichEditPrinter</a> class is not capable of creating fixed documents from the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditRichEditDocumentServertopic"><u>RichEditDocumentServer</u></a> instance. A new class <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.RichEdit.RichEditDocumentXpfPrinter.class">RichEditDocumentXpfPrinter</a> should be used instead. The updated example utilizes the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.RichEdit.RichEditDocumentXpfPrinter.CreateFixedDocument.method">RichEditDocumentXpfPrinter.CreateFixedDocument</a> method to create a fixed document.</p>

<br/>


