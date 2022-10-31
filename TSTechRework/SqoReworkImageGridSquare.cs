using System;
using System.Drawing;
using System.Windows.Forms;

namespace TSTechRework
{
    public partial class SqoReworkImageGridSquare : UserControl
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel02;
        private System.Windows.Forms.Panel panel01;
        private System.Windows.Forms.Panel panel00;

        private System.Windows.Forms.Label label1;

        private Color borderColor = Color.Red;
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;

                RefreshColorBorders(borderColor);

                this.Invalidate();
            }
        }

        private int sizeBorder = 5;
        public int SizeBorder
        {
            get
            {
                return sizeBorder;
            }
            set
            {
                sizeBorder = value;

                this.tableLayoutPanel1.RowStyles[0].Height = sizeBorder;
                this.tableLayoutPanel1.RowStyles[2].Height = sizeBorder;
                this.tableLayoutPanel1.ColumnStyles[0].Width = sizeBorder;
                this.tableLayoutPanel1.ColumnStyles[2].Width = sizeBorder;

                this.Invalidate();
            }
        }

        private bool showBorderUp = true;
        public bool ShowBorderUp
        {
            get
            {
                return showBorderUp;
            }
            set
            {
                showBorderUp = value;

                RefreshVisibleBorders();

                this.Invalidate();
            }
        }

        private bool showBorderLeft = true;
        public bool ShowBorderLeft
        {
            get
            {
                return showBorderLeft;
            }
            set
            {
                showBorderLeft = value;

                RefreshVisibleBorders();

                this.Invalidate();
            }
        }

        private bool showBorderRight = true;
        public bool ShowBorderRight
        {
            get
            {
                return showBorderRight;
            }
            set
            {
                showBorderRight = value;

                RefreshVisibleBorders();

                this.Invalidate();
            }
        }

        private bool showBorderDown = true;
        public bool ShowBorderDown
        {
            get
            {
                return showBorderDown;
            }
            set
            {
                showBorderDown = value;

                RefreshVisibleBorders();

                this.Invalidate();
            }
        }

        public string Label
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;

                this.Invalidate();
            }
        }

        private event EventHandler click;
        new public event EventHandler Click
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

        public SqoReworkImageGridSquare()
        {
            InitializeComponent();

            this.panel00 = CreatePanelBorder();
            this.panel01 = CreatePanelBorder();
            this.panel02 = CreatePanelBorder();
            this.panel10 = CreatePanelBorder();
            this.panel12 = CreatePanelBorder();
            this.panel20 = CreatePanelBorder();
            this.panel21 = CreatePanelBorder();
            this.panel22 = CreatePanelBorder();

            this.label1 = new System.Windows.Forms.Label();
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Text = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = true;
            this.label1.Click += UserClick;
            this.label1.Padding = new Padding(0);
            this.label1.Margin = new Padding(0);

            CreateTableLayout();
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

        private Panel CreatePanelBorder()
        {
            Panel pnl = new Panel();

            pnl.BackColor = borderColor;
            pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl.Margin = new System.Windows.Forms.Padding(0);
            //pnl.Click += UserClick;

            return pnl;
        }

        private void CreateTableLayout()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)sizeBorder));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)sizeBorder));
            this.tableLayoutPanel1.Controls.Add(this.panel22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)sizeBorder));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)sizeBorder));
            this.tableLayoutPanel1.Click += UserClick;
            // 
            // SqoReworkImageGridSquare
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void UserClick(object sender, System.EventArgs e)
        {
            click(this, e);
        }

        private void RefreshVisibleBorders()
        {
            panel00.Visible = showBorderUp || showBorderLeft;
            panel01.Visible = showBorderUp;
            panel02.Visible = showBorderUp || showBorderRight;

            panel10.Visible = showBorderLeft;
            panel12.Visible = showBorderRight;

            panel20.Visible = showBorderDown || showBorderLeft;
            panel21.Visible = showBorderDown;
            panel22.Visible = showBorderDown || showBorderRight;
        }

        private void RefreshColorBorders(Color color)
        {
            panel00.BackColor = color;
            panel01.BackColor = color;
            panel02.BackColor = color;
            panel10.BackColor = color;
            panel12.BackColor = color;
            panel20.BackColor = color;
            panel21.BackColor = color;
            panel22.BackColor = color;
        }
    }
}
