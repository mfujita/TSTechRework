using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSTechRework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //sqoReworkImageGrid1.Backgroud = Image.FromFile(@"C:\Windows\Microsoft.NET\Framework\v2.0.50727\ASP.NETWebAdminFiles\Images\ASPdotNET_logo.jpg");
            sqoReworkImageGrid1.Backgroud = Image.FromFile(@"C:\Users\fujitamur\Pictures\selecionadas\20211204_101721.jpg");
            sqoReworkImageGrid1.SetGridSize(4, 2);
            sqoReworkImageGrid1.GridBorderColor = Color.Blue;
            sqoReworkImageGrid1.SelectedSquareColor = Color.FromArgb(150, 255, 0, 0);
            sqoReworkImageGrid1.Click += SqoReworkImageGrid1_Click;
        }

        private void SqoReworkImageGrid1_Click(int row, int column)
        {
            sqoReworkImageGrid1.FillSquare(row, column, "2");
        }
    }
}
