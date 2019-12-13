using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetDisplayMode(DisplayMode mode)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "DisplaySwitch.exe";
            switch (mode)
            {
                case DisplayMode.External:
                    proc.StartInfo.Arguments = " /external";
                    break;
                case DisplayMode.Internal:
                    proc.StartInfo.Arguments = " /internal";
                    break;
                case DisplayMode.Extend:
                    proc.StartInfo.Arguments = " /extend";
                    break;
                case DisplayMode.Duplicate:
                    proc.StartInfo.Arguments = " /clone";
                    break;
            }
            proc.Start();
        }
        enum DisplayMode
        {
            Internal,
            External,
            Extend,
            Duplicate
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Extend);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Duplicate);
        }
    }
}
