using System.Windows.Forms;

namespace GameBoardGrid
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.labelInputRow = new System.Windows.Forms.Label();
            this.labelInputColumn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCurrentRow = new System.Windows.Forms.Label();
            this.labelCurrentColumn = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Wheat;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCanvas.Location = new System.Drawing.Point(92, 58);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(400, 400);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // labelInputRow
            // 
            this.labelInputRow.AutoSize = true;
            this.labelInputRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputRow.Location = new System.Drawing.Point(554, 65);
            this.labelInputRow.Name = "labelInputRow";
            this.labelInputRow.Size = new System.Drawing.Size(179, 20);
            this.labelInputRow.TabIndex = 1;
            this.labelInputRow.Text = "Enter Number of Rows";
            // 
            // labelInputColumn
            // 
            this.labelInputColumn.AutoSize = true;
            this.labelInputColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputColumn.Location = new System.Drawing.Point(554, 105);
            this.labelInputColumn.Name = "labelInputColumn";
            this.labelInputColumn.Size = new System.Drawing.Size(203, 20);
            this.labelInputColumn.TabIndex = 2;
            this.labelInputColumn.Text = "Enter Number of Columns";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(791, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(665, 168);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 51);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(791, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labelCurrentRow
            // 
            this.labelCurrentRow.AutoSize = true;
            this.labelCurrentRow.Location = new System.Drawing.Point(89, 526);
            this.labelCurrentRow.Name = "labelCurrentRow";
            this.labelCurrentRow.Size = new System.Drawing.Size(167, 17);
            this.labelCurrentRow.TabIndex = 7;
            this.labelCurrentRow.Text = "Current Number of Rows:";
            // 
            // labelCurrentColumn
            // 
            this.labelCurrentColumn.AutoSize = true;
            this.labelCurrentColumn.Location = new System.Drawing.Point(89, 563);
            this.labelCurrentColumn.Name = "labelCurrentColumn";
            this.labelCurrentColumn.Size = new System.Drawing.Size(187, 17);
            this.labelCurrentColumn.TabIndex = 8;
            this.labelCurrentColumn.Text = "Current Number of Columns:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(665, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 51);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDrawLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawLine.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDrawLine.Location = new System.Drawing.Point(665, 405);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(98, 78);
            this.btnDrawLine.TabIndex = 10;
            this.btnDrawLine.Text = "Draw a Line";
            this.btnDrawLine.UseVisualStyleBackColor = false;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 674);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelCurrentColumn);
            this.Controls.Add(this.labelCurrentRow);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInputColumn);
            this.Controls.Add(this.labelInputRow);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInputRow;
        private System.Windows.Forms.Label labelInputColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCurrentRow;
        private System.Windows.Forms.Label labelCurrentColumn;
        private System.Windows.Forms.Button btnClear;
        private Button btnDrawLine;
        public PictureBox pbCanvas;
    }
}
