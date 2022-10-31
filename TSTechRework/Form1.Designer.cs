
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
            this.sqoReworkImageGrid2 = new TSTechRework.SqoReworkImageGrid();
            this.sqoReworkImageGrid1 = new TSTechRework.SqoReworkImageGrid();
            this.SuspendLayout();
            // 
            // sqoReworkImageGrid2
            // 
            this.sqoReworkImageGrid2.Backgroud = null;
            this.sqoReworkImageGrid2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sqoReworkImageGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqoReworkImageGrid2.GridBorderColor = System.Drawing.Color.Red;
            this.sqoReworkImageGrid2.Location = new System.Drawing.Point(9, 9);
            this.sqoReworkImageGrid2.Margin = new System.Windows.Forms.Padding(0);
            this.sqoReworkImageGrid2.Name = "sqoReworkImageGrid2";
            this.sqoReworkImageGrid2.SelectedSquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sqoReworkImageGrid2.Size = new System.Drawing.Size(641, 419);
            this.sqoReworkImageGrid2.TabIndex = 1;
            this.sqoReworkImageGrid2.Visible = false;
            // 
            // sqoReworkImageGrid1
            // 
            this.sqoReworkImageGrid1.Backgroud = null;
            this.sqoReworkImageGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sqoReworkImageGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqoReworkImageGrid1.GridBorderColor = System.Drawing.Color.Red;
            this.sqoReworkImageGrid1.Location = new System.Drawing.Point(0, 0);
            this.sqoReworkImageGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.sqoReworkImageGrid1.Name = "sqoReworkImageGrid1";
            this.sqoReworkImageGrid1.SelectedSquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sqoReworkImageGrid1.Size = new System.Drawing.Size(659, 437);
            this.sqoReworkImageGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(this.sqoReworkImageGrid2);
            this.Controls.Add(this.sqoReworkImageGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private SqoReworkImageGrid sqoReworkImageGrid1;
        private SqoReworkImageGrid sqoReworkImageGrid2;
    }
}

