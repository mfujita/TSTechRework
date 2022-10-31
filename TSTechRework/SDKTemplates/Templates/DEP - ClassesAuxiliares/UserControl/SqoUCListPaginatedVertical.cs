using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sqoTraceabilityStation
{
    public partial class SqoUCListPaginatedVertical : UserControl
    {
        private TableLayoutPanel tableLayoutList;

        private List<UserControl> userControls;
        private int sizePage = 6;
        private int page;
        private int lastPage;

        public SqoUCListPaginatedVertical()
        {
            InitializeComponent();

            CreateTableLayoutList();
        }

        public SqoUCListPaginatedVertical(int SizePage)
        {
            InitializeComponent();

            this.sizePage = SizePage;

            CreateTableLayoutList();
        }

        private void CreateTableLayoutList()
        {
            tableLayoutList = new TableLayoutPanel();

            tableLayoutList.ColumnCount = 1;
            tableLayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutList.Margin = new System.Windows.Forms.Padding(0);            
            tableLayoutList.RowCount = sizePage;

            for(int i = 0; i < sizePage; i++)
                tableLayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            tableLayoutOrganizer.Controls.Add(this.tableLayoutList, 1, 0);
        }

        public void SetList(List<UserControl> userControls)
        {
            this.userControls = userControls;

            lastPage = 0;

            if (this.userControls != null)
            {
                lastPage = (int)Math.Floor((decimal)((this.userControls.Count - 1) / sizePage));

                SetPage(0);
            }
        }

        private void SetPage(int page)
        {
            this.page = page;

            btnPagePrevious.Enabled = false;
            btnPageNext.Enabled = false;

            if (userControls != null && userControls.Count != 0 && page != 0)
                btnPagePrevious.Enabled = true;                

            if (page != lastPage)
                btnPageNext.Enabled = true;

            tableLayoutList.Controls.Clear();

            for (int i = 0; i < sizePage; i++)
            {
                int listItem = (page * sizePage) + i;

                if (userControls.Count <= listItem)
                    break;

                userControls[listItem].BackColor = (i % 2 == 0 ? Color.FromArgb(255, 241, 241, 241) : Color.White);

                tableLayoutList.Controls.Add(userControls[listItem], 0, i);
            }
        }

        private void btnPage_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled)
                btn.BackColor = Color.FromArgb(255, btn.BackColor.R, btn.BackColor.G, btn.BackColor.B);
            else
                btn.BackColor = Color.FromArgb(127, btn.BackColor.R, btn.BackColor.G, btn.BackColor.B);            
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            SetPage(++page);
        }

        private void btnPagePrevious_Click(object sender, EventArgs e)
        {
            SetPage(--page);
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
    }
}
