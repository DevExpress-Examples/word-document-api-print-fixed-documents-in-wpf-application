Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit
Imports System.Printing
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents

Namespace RichEditDocumentServer_Print

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'#Region "#xpfprinter"
            Dim srv As RichEditDocumentServer = New RichEditDocumentServer()
            srv.LoadDocument("test.docx")
            Dim document As FixedDocument = RichEditDocumentXpfPrinter.CreateFixedDocument(srv)
            Dim pDialog As PrintDialog = New PrintDialog()
            Dim queues As PrintQueueCollection = New PrintServer().GetPrintQueues({EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections})
            Dim localPrinterEnumerator As System.Collections.IEnumerator = queues.GetEnumerator()
            Dim printQueue As PrintQueue = Nothing
            Do
                If Not localPrinterEnumerator.MoveNext() Then Exit Do
                printQueue = CType(localPrinterEnumerator.Current, PrintQueue)
            Loop While Not printQueue.FullName.Contains("Canon")

            If printQueue IsNot Nothing Then
                pDialog.PrintQueue = printQueue
                pDialog.PrintDocument(document.DocumentPaginator, String.Empty)
            End If
'#End Region  ' #xpfprinter
        End Sub
    End Class
End Namespace
