using LentaNewsParser.Core;
using LentaNewsParser.Core.LentaNews;
using System;
using System.Windows.Forms;

namespace LentaNewsParser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new Core.LentaNews.LentaParser()
                );
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listBox1.Items.AddRange(arg2);
        }

      

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            parser.Settings = new LentaSettings(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            parser.Start();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
