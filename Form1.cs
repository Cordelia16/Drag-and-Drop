/*CIT237518
 *Somaly Ngov
 *Date: 23/05/2020
 *Software: Microsoft Visual Studio 2019 Community Edition 
 *Platform: Microsoft Windows 10 Professional 64­bit
 *Purpose: this program will show you how create the pdf file in c#
 *         
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HelpFileFor_Drag_Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("D:/Help.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("You can drag and drop Images from anywhere on your computer into the picture box then it will show you an image.");
            doc.Add(p1);
            Paragraph p2 = new Paragraph("");
            doc.Close();
            MessageBox.Show("Pdf file created sucessfully");
            
        }
    }
}
