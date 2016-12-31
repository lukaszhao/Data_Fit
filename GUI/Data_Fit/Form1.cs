using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   //for Debug.WriteLine()
using System.IO;

namespace Csharp_001
{
    public partial class Form1 : Form
    {
        private List<double> data_x = new List<double>();    // note: in C#, a List is like a vector in C++; C#'s LinkedList is like list in C++
        private List<double> data_y = new List<double>();
        private List<double> fit_x = new List<double>();
        private List<double> fit_y = new List<double>();

        public Form1()
        {
            InitializeComponent();
            assignDummyData();
        }

        private void assignDummyData()
        {
            for(int i=1; i<101; ++i)
            {
                double x = Convert.ToDouble(i) / 10.0;
                double y = Math.Exp(-Math.Pow((x - 5), 2) / 2);
                chart1.Series["Data"].Points.AddXY(x, y);
                chart1.Series["Fit"].Points.AddXY(x, y);
            }
        }

        private void buttonPlotData_Click(object sender, EventArgs e)
        {

        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                    data_x.Clear();
                    data_y.Clear();
                    fit_x.Clear();
                    fit_y.Clear();
                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();
                        if (line == "") { continue; }
                        string[] parsedWords = stringParser(line);
                        if (parsedWords[0] != "failed")
                        {
                            data_x.Add(Convert.ToDouble(parsedWords[0]));
                            data_y.Add(Convert.ToDouble(parsedWords[1]));
                        }
                    }
                    plotData();
                    sr.Dispose();
                }
                catch {
                    MessageBox.Show("Reading data file failed.");
                }
            }
        }

        public string[] stringParser(string line)
        {
            char[] delimiterChars = { ' ', ',', ':', '\t' };
            string[] words = line.Split(delimiterChars);
            string[] result = new string[2];
            int j = 0;
            for(int i = 0; i < words.Length; ++i)
            {
                if (words[i] != "")
                {
                    result[j] = words[i];
                    ++j;  
                }
                if (j == 2) { break; }
            }
            if (j != 2) { result[0] = "failed"; result[1] = "failed"; }
            return result;
        }

        private void plotData()
        {
            chart1.Series["Data"].Points.Clear();
            chart1.Series["Fit"].Points.Clear();
            for(int i=0; i < data_x.Count; ++i)
            {
                chart1.Series["Data"].Points.AddXY(data_x[i], data_y[i]);
            }
        }
    }
}
