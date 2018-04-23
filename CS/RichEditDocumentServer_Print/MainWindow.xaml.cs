using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace RichEditDocumentServer_Print
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            #region #xpfprinter
            RichEditDocumentServer srv = new RichEditDocumentServer();
            srv.LoadDocument("test.docx");

            FixedDocument document = RichEditDocumentXpfPrinter.CreateFixedDocument(srv);

            PrintDialog pDialog = new PrintDialog();
            PrintQueueCollection queues = new PrintServer().GetPrintQueues(new[] { EnumeratedPrintQueueTypes.Local,
                EnumeratedPrintQueueTypes.Connections});
            System.Collections.IEnumerator localPrinterEnumerator = queues.GetEnumerator();
            PrintQueue printQueue = null;

            do
            {
                if (!localPrinterEnumerator.MoveNext())
                    break;
                printQueue = (PrintQueue)localPrinterEnumerator.Current;
            }
            while (!printQueue.FullName.Contains("Canon"));
            if (printQueue != null)
            {
                pDialog.PrintQueue = printQueue;
                pDialog.PrintDocument(document.DocumentPaginator, string.Empty);
            }
            #endregion #xpfprinter
        }
    }
}

