namespace sqoTraceabilityStation
{
    partial class SqoUCListPaginatedVertical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqoUCListPaginatedVertical));
            this.tableLayoutOrganizer = new System.Windows.Forms.TableLayoutPanel();
            this.btnPagePrevious = new System.Windows.Forms.Button();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.tableLayoutOrganizer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutOrganizer
            // 
            this.tableLayoutOrganizer.ColumnCount = 1;
            this.tableLayoutOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOrganizer.Controls.Add(this.btnPagePrevious, 0, 0);
            this.tableLayoutOrganizer.Controls.Add(this.btnPageNext, 0, 2);
            this.tableLayoutOrganizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOrganizer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutOrganizer.Name = "tableLayoutOrganizer";
            this.tableLayoutOrganizer.RowCount = 3;
            this.tableLayoutOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutOrganizer.Size = new System.Drawing.Size(972, 610);
            this.tableLayoutOrganizer.TabIndex = 0;
            // 
            // btnPagePrevious
            // 
            this.btnPagePrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(68)))), ((int)(((byte)(62)))));
            this.btnPagePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagePrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagePrevious.FlatAppearance.BorderSize = 0;
            this.btnPagePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagePrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPagePrevious.Image")));
            this.btnPagePrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPagePrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPagePrevious.Name = "btnPagePrevious";
            this.btnPagePrevious.Size = new System.Drawing.Size(972, 70);
            this.btnPagePrevious.TabIndex = 12;
            this.btnPagePrevious.TabStop = false;
            this.btnPagePrevious.UseVisualStyleBackColor = false;
            this.btnPagePrevious.Click += new System.EventHandler(this.btnPagePrevious_Click);
            this.btnPagePrevious.EnabledChanged += new System.EventHandler(btnPage_EnabledChanged);
            // 
            // btnPageNext
            // 
            this.btnPageNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(68)))), ((int)(((byte)(62)))));
            this.btnPageNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPageNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPageNext.FlatAppearance.BorderSize = 0;
            this.btnPageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageNext.Image = ((System.Drawing.Image)(resources.GetObject("btnPageNext.Image")));
            this.btnPageNext.Location = new System.Drawing.Point(0, 540);
            this.btnPageNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(972, 70);
            this.btnPageNext.TabIndex = 13;
            this.btnPageNext.TabStop = false;
            this.btnPageNext.UseVisualStyleBackColor = false;
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            this.btnPageNext.EnabledChanged += new System.EventHandler(btnPage_EnabledChanged);
            // 
            // SqoUCListPaginatedVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutOrganizer);
            this.Name = "SqoUCListPaginatedVertical";
            this.Size = new System.Drawing.Size(972, 610);
            this.tableLayoutOrganizer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutOrganizer;
        private System.Windows.Forms.Button btnPagePrevious;
        private System.Windows.Forms.Button btnPageNext;
    }
}
