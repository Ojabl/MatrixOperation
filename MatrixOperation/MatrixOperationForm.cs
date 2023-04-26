using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixOperation
{
    public partial class MatrixOperationForm : Form
    {
        public MatrixOperationForm()
        {
            InitializeComponent();
            ScLeft.SplitterWidth = 8;
            ScRight.SplitterWidth = 8;
        }

        private void ScLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScRight.SplitterDistance = ScLeft.SplitterDistance;
        }

        private void ScRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScLeft.SplitterDistance = ScRight.SplitterDistance;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Matrix MatrixA;
            if (Matrix.TryParse(TbMatrixA.Text.Trim(), out MatrixA)) TbMatrixM.Text = MatrixA.ToString();
            else TbMatrixM.Text = "Parse error";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Matrix MatrixA;
            if(Matrix.TryParse(TbMatrixA.Text.Trim(), out MatrixA))
            {
                Matrix MatrixB;
                if (Matrix.TryParse(TbMatrixB.Text.Trim(), out MatrixB))
                {
                    try
                    {
                        Matrix MatrixM = MatrixA + MatrixB;
                        TbMatrixM.Text = MatrixM.ToString();
                    }
                    catch (ArgumentException ex)
                    {
                        TbMatrixM.Text = ex.Message;
                    }
                }
                else TbMatrixM.Text = "Parse error";
            }
            else TbMatrixM.Text = "Parse error";
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            Matrix MatrixA;
            if(Matrix.TryParse(TbMatrixA.Text.Trim(), out MatrixA))
            {
                Matrix MatrixB;
                if (Matrix.TryParse(TbMatrixB.Text.Trim(), out MatrixB))
                {
                    try
                    {
                        Matrix MatrixM = MatrixA - MatrixB;
                        TbMatrixM.Text = MatrixM.ToString();
                    }
                    catch (ArgumentException ex)
                    {
                        TbMatrixM.Text = ex.Message;
                    }
                }
                else TbMatrixM.Text = "Parse error";
            }
            else TbMatrixM.Text = "Parse error";
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            Matrix MatrixA;
            if(Matrix.TryParse(TbMatrixA.Text.Trim(), out MatrixA))
            {
                Matrix MatrixB;
                if(Matrix.TryParse(TbMatrixB.Text.Trim(), out MatrixB))
                {
                    try
                    {
                        Matrix MatrixM = MatrixA * MatrixB;
                        TbMatrixM.Text = MatrixM.ToString();
                    }
                    catch (ArgumentException ex)
                    {
                        TbMatrixM.Text = ex.Message;
                    }
                }
                else TbMatrixM.Text = "Parse error";
            }
            else TbMatrixM.Text = "Parse error";
        }

        
    }
}
