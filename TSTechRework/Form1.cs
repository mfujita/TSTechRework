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
        List<string> pictureLista = null;

        public Form1()
        {
            InitializeComponent();

            List<string> picturesPath = ImageListForTest();

            sqoReworkImageGrid1.Backgroud = Image.FromFile(picturesPath[0]);
            sqoReworkImageGrid1.SetGridSize(4, 2);
            sqoReworkImageGrid1.GridBorderColor = Color.Blue;
            sqoReworkImageGrid1.SelectedSquareColor = Color.FromArgb(150, 255, 0, 0);
            sqoReworkImageGrid1.Click += SqoReworkImageGrid1_Click;

            sqoUCListPaginatedVertical1.SizePage = 3;

            
            CreationOfPictureboxList(picturesPath);
        }

        private void SqoReworkImageGrid1_Click(int row, int column)
        {
            sqoReworkImageGrid1.FillSquare(row, column, "2");
        }

        private List<string> ImageListForTest()
        {
            pictureLista = new List<string>();
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\DLL faltando.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\estação com problema no cadastro de modelos.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\FALHA AO CONECTAR OPC SERVER.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\L1-cabeçote-10A-ferramentas.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\linha1-bloco-10B-GED.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\Não foi possível carregar o evento de validação de login.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\Não possui o tamanho correto.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\PermitirEntradaCodigoAreaCarga.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\Referencia de objeto não  para instância de um objeto.jpg");
            pictureLista.Add(@"C:\Users\fujitamur\Pictures\erros\Valor não pode ser nulo.jpg");

            return pictureLista;
        }

        private void CreationOfPictureboxList(List<string> images)
        {
            List<UserControl> lista = new List<UserControl>();

            for (int i = 0; i < images.Count; i++)
            {
                PictureBox pic = new PictureBox();                
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Visible = true;
                pic.Dock = DockStyle.Fill;
                pic.Margin = new Padding(0);
                pic.Padding = new Padding(0);
                pic.Image = Image.FromFile(images[i]);
                pic.Tag = i.ToString();
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Click += Pic_Click;

                UserControl uc = new UserControl();

                uc.Visible = true;
                uc.Dock = DockStyle.Fill;
                uc.Margin = new Padding(0);
                uc.Padding = new Padding(0);
                uc.Controls.Add(pic);

                lista.Add(uc);
            }

            sqoUCListPaginatedVertical1.SetList(lista);
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            sqoReworkImageGrid1.Backgroud = pb.Image;
        }
    }
}
