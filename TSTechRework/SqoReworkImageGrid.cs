using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TSTechRework
{
    public partial class SqoReworkImageGrid : UserControl
    {
        public delegate void SqoReworkImageGridSquareClick(int row, int column);

        private int originalWidthImage;
        private int originalHeightImage;

        private event SqoReworkImageGridSquareClick click;
        new public event SqoReworkImageGridSquareClick Click
        {
            add
            {
                click += value;
            }
            remove
            {
                click -= value;
            }
        }

        private Color gridBorderColor = Color.Red;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

        public Color GridBorderColor
        {
            get
            {
                return gridBorderColor;
            }
            set
            {
                gridBorderColor = value;

                RefreshColorBorders(gridBorderColor);

                this.Invalidate();
            }
        }

        private Color selectedSquareColor = Color.FromArgb(50, 255, 0, 0);
        public Color SelectedSquareColor
        {
            get
            {
                return selectedSquareColor;
            }
            set
            {
                selectedSquareColor = value;

                this.Invalidate();
            }
        }

        public void FillSquare(int row, int column, string labelText = "")
        {
            Control c = this.tableLayoutPanel2.GetControlFromPosition(column, row);

            if(c != null && c.GetType() == typeof(SqoReworkImageGridSquare))
            {
                SqoReworkImageGridSquare square = (SqoReworkImageGridSquare)c;

                square.BackColor = selectedSquareColor;
                square.Label = labelText;
            }
        }

        //public void WriteNumberOfDefects(int row, int column, int amountDefects)
        //{
        //    Control c = tableLayoutPanel2.GetControlFromPosition(column, row);

        //    Label lblQtdeDefeitos = new Label();
        //    lblQtdeDefeitos.Text = amountDefects.ToString();
        //    lblQtdeDefeitos.
        //    tableLayoutPanel2.Controls.Add(lblQtdeDefeitos);
        //}

        private void RefreshColorBorders(Color color)
        {
            for (int i = 0; i < tableLayoutPanel2.Controls.Count; i++)
            {
                Control c = tableLayoutPanel2.Controls[i];

                if(c.GetType() == typeof(SqoReworkImageGridSquare))
                {
                    SqoReworkImageGridSquare square = (SqoReworkImageGridSquare)c;

                    square.BorderColor = color;
                }
            }
        }

        public Image Backgroud
        {
            set
            {
                if (value != null)
                {
                    originalWidthImage = value.Width;
                    originalHeightImage = value.Height;

                    this.tableLayoutPanel2.BackgroundImage = value;
                    RefreshTableLayout();
                }   
            }
            get
            {
                return this.tableLayoutPanel2.BackgroundImage;
            }
        }

        public void SetGridSize(int rows, int columns)
        {
            this.tableLayoutPanel2.Controls.Clear();

            if (rows < 1)
                rows = 1;

            this.tableLayoutPanel2.RowStyles.Clear();
            this.tableLayoutPanel2.RowCount = rows;

            float restRows = 100F;
            float divRows = restRows / this.tableLayoutPanel2.RowCount;

            for (int i = 0; i < this.tableLayoutPanel2.RowCount; i++)
            {
                if (i == (this.tableLayoutPanel2.RowCount - 1))
                {
                    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, restRows));
                    restRows = restRows - restRows;
                }                    
                else
                {
                    this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, divRows));
                    restRows = restRows - divRows;
                }
            }

            if (columns < 1)
                columns = 1;
                                    
            this.tableLayoutPanel2.ColumnStyles.Clear();
            this.tableLayoutPanel2.ColumnCount = columns;

            float restColumns = 100F;
            float divColumns = restColumns / this.tableLayoutPanel2.ColumnCount;

            for (int i = 0; i < this.tableLayoutPanel2.ColumnCount; i++)
            {
                if(i == (this.tableLayoutPanel2.ColumnCount - 1))
                {
                    this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, restColumns));
                    restColumns = restColumns - restColumns;
                }   
                else
                {
                    this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, divColumns));
                    restColumns = restColumns - divColumns;
                }
            }

            CreateSquare(rows, columns);            
        }

        private void CreateSquare(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    SqoReworkImageGridSquare square = new SqoReworkImageGridSquare();

                    square.Dock = System.Windows.Forms.DockStyle.Fill;
                    square.SizeBorder = 5;                    
                    square.Click += new System.EventHandler(this.SquareClick);
                    square.Margin = new System.Windows.Forms.Padding(0);
                    square.Padding = new System.Windows.Forms.Padding(0);
                    square.ShowBorderUp = true;
                    square.ShowBorderLeft = true;
                    square.ShowBorderDown = (i == rows - 1);
                    square.ShowBorderRight = (j == columns - 1);
                    square.Label = "";

                    this.tableLayoutPanel2.Controls.Add(square, j, i);
                }
            }
        }

        public SqoReworkImageGrid()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void SqoReworkImageGrid_SizeChanged(object sender, EventArgs e)
        {
            RefreshTableLayout();
        }

        private void RefreshTableLayout()
        {
            tableLayoutPanel1.Size = new Size(Width, Height * 95 / 100);

            if (this.originalHeightImage > 0)
            {
                double imageRatio = (double)this.originalWidthImage / (double)this.originalHeightImage;
                double formRatio = (double)this.Width / (double)this.Height;

                if (imageRatio == formRatio)
                {
                    //Não precisa de colunas e nem de linhas

                    tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[0].Height = 0;

                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.RowStyles[1].Height = 100;

                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = 0;

                    tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[0].Width = 0;

                    tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.ColumnStyles[1].Width = 100;

                    tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[2].Width = 0;
                }
                else if (imageRatio < formRatio)
                {
                    //Precisa de colunas

                    tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[0].Height = 0;

                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.RowStyles[1].Height = 100;

                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = 0;

                    double imageWidthActual = this.Height * imageRatio;
                    int widthDiff = Math.Abs(this.Width - (int)imageWidthActual);
                    int halfWidth2 = (int)(widthDiff / 2);
                    int halfWidth1 = (widthDiff - halfWidth2);

                    tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[0].Width = halfWidth1;

                    tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.ColumnStyles[1].Width = 100;

                    tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[2].Width = halfWidth2;
                }
                else
                {
                    //Precisa de linhas

                    tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[0].Width = 0;

                    tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.ColumnStyles[1].Width = 100;

                    tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[2].Width = 0;

                    double imageHeightActual = this.Width / imageRatio;
                    int heightDiff = Math.Abs((int)imageHeightActual - this.Height);
                    int halfHeight2 = (int)(heightDiff / 2);
                    int halfHeight1 = (heightDiff - halfHeight2);

                    tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[0].Height = halfHeight1;

                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel1.RowStyles[1].Height = 100;

                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = halfHeight2;
                }
            }
        }

        private void SquareClick(object sender, EventArgs e)
        {
            int row = 0;
            int column = 0;

            if (GetPositionControl((Control)sender, out row, out column))
            {
                if (click != null)
                    click(row, column);
            }
        }

        private bool GetPositionControl(Control c, out int row, out int column)
        {
            row = tableLayoutPanel2.GetRow(c);
            column = tableLayoutPanel2.GetColumn(c);

            return (row >= 0 && column >= 0);
        }
    }
}
