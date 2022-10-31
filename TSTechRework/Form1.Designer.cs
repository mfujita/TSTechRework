
namespace TSTechRework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sqoReworkImageGrid1 = new TSTechRework.SqoReworkImageGrid();
            this.sqoUCListPaginatedVertical2 = new sqoTraceabilityStation.SqoUCListPaginatedVertical();
            this.sqoUCListPaginatedVertical1 = new sqoTraceabilityStation.SqoUCListPaginatedVertical();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.sqoReworkImageGrid1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sqoUCListPaginatedVertical2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sqoUCListPaginatedVertical1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sqoReworkImageGrid1
            // 
            this.sqoReworkImageGrid1.Backgroud = null;
            this.sqoReworkImageGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sqoReworkImageGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqoReworkImageGrid1.GridBorderColor = System.Drawing.Color.Red;
            this.sqoReworkImageGrid1.Location = new System.Drawing.Point(165, 1);
            this.sqoReworkImageGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.sqoReworkImageGrid1.Name = "sqoReworkImageGrid1";
            this.sqoReworkImageGrid1.SelectedSquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sqoReworkImageGrid1.Size = new System.Drawing.Size(327, 435);
            this.sqoReworkImageGrid1.TabIndex = 0;
            // 
            // sqoUCListPaginatedVertical2
            // 
            this.sqoUCListPaginatedVertical2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqoUCListPaginatedVertical2.Location = new System.Drawing.Point(496, 4);
            this.sqoUCListPaginatedVertical2.Name = "sqoUCListPaginatedVertical2";
            this.sqoUCListPaginatedVertical2.Size = new System.Drawing.Size(159, 429);
            this.sqoUCListPaginatedVertical2.TabIndex = 2;
            // 
            // sqoUCListPaginatedVertical1
            // 
            this.sqoUCListPaginatedVertical1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqoUCListPaginatedVertical1.Location = new System.Drawing.Point(4, 4);
            this.sqoUCListPaginatedVertical1.Name = "sqoUCListPaginatedVertical1";
            this.sqoUCListPaginatedVertical1.Size = new System.Drawing.Size(157, 429);
            this.sqoUCListPaginatedVertical1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SqoReworkImageGrid sqoReworkImageGrid1;
        private sqoTraceabilityStation.SqoUCListPaginatedVertical sqoUCListPaginatedVertical2;
        private sqoTraceabilityStation.SqoUCListPaginatedVertical sqoUCListPaginatedVertical1;
    }
}

