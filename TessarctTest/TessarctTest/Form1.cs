using System;
using System.Windows.Forms;
using Tesseract;
using System.IO;

namespace TessarctTest
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void ocr_btn_Click(object sender, EventArgs e)
        {
            fileName = path_txtBox.Text;
            var engine = new TesseractEngine("C:\\Program Files\\Tesseract-OCR\\tessdata", "eng");
            using (var pix = Pix.LoadFromFile(fileName))
            {
                var page = engine.Process(pix);
                string result = page.GetText().ToString().Replace("\n", " ").Trim();
                textBox1.Text = result;
            }
        }
        private void path_txtBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] sFileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (sFileName.Length <= 0) { return; }
            TextBox path_txtBox = sender as TextBox;
            if (path_txtBox == null) { return; }
            path_txtBox.Text = "";
            path_txtBox.Text = sFileName[0];
        }

        private void path_txtBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] sFileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (string sTemp in sFileName)
                {
                    if (File.Exists(sTemp) == false) { return; }
                    else { break; }
                }
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
