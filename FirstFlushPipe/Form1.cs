using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FirstFlushPipe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double volDiverted = 0.0;
        public double pi = 22 / 7;

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            textVolDiverted.Text = "0.00";
            double wid = 0;
            double len = 0;
            double.TryParse(textHouseLength.Text, out len);
            double.TryParse(textHouseWidth.Text, out wid);
            //Debug.WriteLine(len + ", " + wid);
            if (len != 0 && wid != 0)
            {
                double vd = (wid * len) * 0.0005;
                textVolDiverted.Text = vd.ToString();
                volDiverted = vd;
            }

        }

        private void textHouseLength_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textHouseWidth_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void linkDiameter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab1.TabPages[1].Show();
            tab1.SelectedIndex = 1;
        }

        private void linkLength_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab1.TabPages[2].Show();
            tab1.SelectedIndex = 2;
        }

        private void textPipeLength_TextChanged(object sender, EventArgs e)
        {
            double plen = 0;

            double.TryParse(textPipeLength.Text, out plen);
            double r = volDiverted / (pi * plen);
            r = Math.Sqrt(r);
            double d = (r * 2) / 0.001;
            labelPipeDiameter.Text = d.ToString();


        }

        private void textPipeDiameter_TextChanged(object sender, EventArgs e)
        {
            double pdia = 0;
            double.TryParse(textPipeDiameter.Text, out pdia);
            double sq = (pdia/2 * 0.001) * (pdia/2 * 0.001);
            double h = volDiverted / (pi * sq);
            //double r = h / 2;
            labelPipeLength.Text = h.ToString();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textPipeDiameter.Text = "";
            textPipeLength.Text = "";
            textHouseLength.Text = "";
            textHouseWidth.Text = "";
            textVolDiverted.Text = "0.00";
            labelPipeLength.Text = "0.00";
            labelPipeDiameter.Text = "0.00";
        }

    }
}
