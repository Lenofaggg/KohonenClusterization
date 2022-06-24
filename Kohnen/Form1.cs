using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kohnen
{
    public partial class Form1 : Form
    {
        private Storager storager = new Storager();
        KohenNet myKohnenNet = new KohenNet(0.1, 2,8);

        
        int maxSet = System.IO.File.ReadAllLines(@"../../Storage/input.txt").Length;

        public Form1()
        {
            InitializeComponent();

            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;


            for (int epoh = 0; epoh < 100000; epoh++)
            {
                using (StreamReader sr = new StreamReader(@"../../Storage/input.txt"))
                {
                    
                        for (int i = 0; i < maxSet; i++)
                        {
                            myKohnenNet.SetFirstInput(storager.Read(sr));
                            myKohnenNet.Learn();
                        }

                        //сброс курсора
                        sr.DiscardBufferedData();
                        sr.BaseStream.Position=0;
                   
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            using (StreamReader sr = new StreamReader(@"../../Storage/input.txt"))
            {
                sr.DiscardBufferedData();
                sr.BaseStream.Position = 0;
                for (int i = 0; i < maxSet; i++)
                {
                    double[] inp = storager.Read(sr);
                    myKohnenNet.SetFirstInput(inp);
                    int indWin = myKohnenNet.FindWinner();
                    chart2.Series[indWin].Points.AddXY(inp[0], inp[1]);

                }
            }



        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
