using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBoardGrid
{
    public partial class Form1 : Form
    {
        public static int rowSize;
        public static int columnSize;
        public static string activeRowSize;
        public static string activeColumnSize;
        public static string currentRowNum;
        public static string currentColNum;
        public static string rowNumb;
        public static string colNumb;
        public static bool valueCheck;

        Graphics drawArea;



        public Form1()
        {
            InitializeComponent();
            drawArea = pbCanvas.CreateGraphics();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Invalidate();
            textBox1.Clear();
            textBox2.Invalidate();
            textBox2.Clear();
            labelCurrentRow.Text = "Current Number of Rows: ";
            labelCurrentColumn.Text = "Current Number of Columns: ";
            rowNumb = labelCurrentRow.Text;
            colNumb = labelCurrentColumn.Text;
            drawArea.Clear(Color.Wheat);
            valueCheck = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (valueCheck != true)
            {
                rowSize = Convert.ToInt32(rowNumb);
                columnSize = Convert.ToInt32(colNumb);
                labelCurrentRow.Text = labelCurrentRow.Text + rowNumb;
                rowNumb = "Current Number of Rows: ";
                labelCurrentColumn.Text = labelCurrentColumn.Text + colNumb;
                colNumb = "Current Number of Columns: ";
                valueCheck = true;

            }
            else
            {
                return;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            rowNumb = rowNumb + e.KeyChar.ToString();
        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            colNumb = colNumb + e.KeyChar.ToString();
        }



        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            //for rows
            int x1 = 0;
            int y1 = 0;
            int x2 = 400;
            int y2 = 400;
            int gridX = 400;
            int gridY = 400;
            int spacingX = gridX / rowSize;
            int spacingY = gridY / columnSize;
            int linesX = rowSize - 1;
            int linesY = columnSize - 1;

            Pen r = new Pen(Color.Blue, 1);
            Pen c = new Pen(Color.Red, 1);


            for (int i = 0; i < linesX; i++)
            {
                drawArea.DrawLine(r, x1, y1 + spacingX, x2, y1 + spacingX);
                y1 = y1 + spacingX;
            }
            y1 = 0;

            for (int y = 0; y < linesY; y++)
            {
                drawArea.DrawLine(c, x1 + spacingY, y1, x1 + spacingY, y2);
                x1 = x1 + spacingY;

            }
            x1 = 0;

        }


    }
}
