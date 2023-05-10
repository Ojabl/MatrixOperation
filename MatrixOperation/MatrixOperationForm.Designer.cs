namespace MatrixOperation
{
    partial class MatrixOperationForm
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
            this.ScVertical = new System.Windows.Forms.SplitContainer();
            this.ScLeft = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInv = new System.Windows.Forms.Button();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnMultiple = new System.Windows.Forms.Button();
            this.BtnSubstract = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.TbMatrixA = new System.Windows.Forms.TextBox();
            this.ScRight = new System.Windows.Forms.SplitContainer();
            this.TbMatrixB = new System.Windows.Forms.TextBox();
            this.TbMatrixM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScLeft)).BeginInit();
            this.ScLeft.Panel1.SuspendLayout();
            this.ScLeft.Panel2.SuspendLayout();
            this.ScLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).BeginInit();
            this.ScRight.Panel1.SuspendLayout();
            this.ScRight.Panel2.SuspendLayout();
            this.ScRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScVertical
            // 
            this.ScVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScVertical.Location = new System.Drawing.Point(0, 0);
            this.ScVertical.Name = "ScVertical";
            // 
            // ScVertical.Panel1
            // 
            this.ScVertical.Panel1.Controls.Add(this.ScLeft);
            this.ScVertical.Panel1MinSize = 300;
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScRight);
            this.ScVertical.Panel2MinSize = 300;
            this.ScVertical.Size = new System.Drawing.Size(929, 449);
            this.ScVertical.SplitterDistance = 450;
            this.ScVertical.SplitterWidth = 8;
            this.ScVertical.TabIndex = 0;
            // 
            // ScLeft
            // 
            this.ScLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScLeft.Location = new System.Drawing.Point(0, 0);
            this.ScLeft.Name = "ScLeft";
            this.ScLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScLeft.Panel1
            // 
            this.ScLeft.Panel1.Controls.Add(this.panel1);
            this.ScLeft.Panel1MinSize = 200;
            // 
            // ScLeft.Panel2
            // 
            this.ScLeft.Panel2.Controls.Add(this.TbMatrixA);
            this.ScLeft.Panel2MinSize = 200;
            this.ScLeft.Size = new System.Drawing.Size(450, 449);
            this.ScLeft.SplitterDistance = 223;
            this.ScLeft.SplitterWidth = 8;
            this.ScLeft.TabIndex = 0;
            this.ScLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScLeft_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnInv);
            this.panel1.Controls.Add(this.BtnSolve);
            this.panel1.Controls.Add(this.BtnMultiple);
            this.panel1.Controls.Add(this.BtnSubstract);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.BtnTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 223);
            this.panel1.TabIndex = 0;
            // 
            // BtnInv
            // 
            this.BtnInv.Location = new System.Drawing.Point(93, 70);
            this.BtnInv.Name = "BtnInv";
            this.BtnInv.Size = new System.Drawing.Size(75, 23);
            this.BtnInv.TabIndex = 5;
            this.BtnInv.Text = "Inv";
            this.BtnInv.UseVisualStyleBackColor = true;
            this.BtnInv.Click += new System.EventHandler(this.BtnInv_Click);
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(12, 70);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(75, 23);
            this.BtnSolve.TabIndex = 4;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // BtnMultiple
            // 
            this.BtnMultiple.Location = new System.Drawing.Point(174, 41);
            this.BtnMultiple.Name = "BtnMultiple";
            this.BtnMultiple.Size = new System.Drawing.Size(75, 23);
            this.BtnMultiple.TabIndex = 3;
            this.BtnMultiple.Text = "*";
            this.BtnMultiple.UseVisualStyleBackColor = true;
            this.BtnMultiple.Click += new System.EventHandler(this.BtnMultiple_Click);
            // 
            // BtnSubstract
            // 
            this.BtnSubstract.Location = new System.Drawing.Point(93, 41);
            this.BtnSubstract.Name = "BtnSubstract";
            this.BtnSubstract.Size = new System.Drawing.Size(75, 23);
            this.BtnSubstract.TabIndex = 2;
            this.BtnSubstract.Text = "-";
            this.BtnSubstract.UseVisualStyleBackColor = true;
            this.BtnSubstract.Click += new System.EventHandler(this.BtnSubstract_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 41);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(12, 12);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // TbMatrixA
            // 
            this.TbMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixA.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbMatrixA.Location = new System.Drawing.Point(0, 0);
            this.TbMatrixA.Multiline = true;
            this.TbMatrixA.Name = "TbMatrixA";
            this.TbMatrixA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixA.Size = new System.Drawing.Size(450, 218);
            this.TbMatrixA.TabIndex = 0;
            this.TbMatrixA.Text = "0,2    7,5    5,0    7,7\r\n3,2    9,4    6,2    0,3\r\n7,7    0,2    5,6    4,7\r\n1,1" +
    "    3,5    7,9    4,8";
            this.TbMatrixA.WordWrap = false;
            // 
            // ScRight
            // 
            this.ScRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScRight.Location = new System.Drawing.Point(0, 0);
            this.ScRight.Name = "ScRight";
            this.ScRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScRight.Panel1
            // 
            this.ScRight.Panel1.Controls.Add(this.TbMatrixB);
            this.ScRight.Panel1MinSize = 200;
            // 
            // ScRight.Panel2
            // 
            this.ScRight.Panel2.Controls.Add(this.TbMatrixM);
            this.ScRight.Panel2MinSize = 200;
            this.ScRight.Size = new System.Drawing.Size(471, 449);
            this.ScRight.SplitterDistance = 223;
            this.ScRight.SplitterWidth = 8;
            this.ScRight.TabIndex = 1;
            this.ScRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScRight_SplitterMoved);
            // 
            // TbMatrixB
            // 
            this.TbMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixB.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbMatrixB.Location = new System.Drawing.Point(0, 0);
            this.TbMatrixB.Multiline = true;
            this.TbMatrixB.Name = "TbMatrixB";
            this.TbMatrixB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixB.Size = new System.Drawing.Size(471, 223);
            this.TbMatrixB.TabIndex = 1;
            this.TbMatrixB.Text = "1,0    0,0    0,0    0,0    5,7\r\n0,0    1,0    0,0    0,0    1,0\r\n0,0    0,0    1" +
    ",0    0,0    3,5\r\n0,0    0,0    0,0    1,0    10,0";
            this.TbMatrixB.WordWrap = false;
            // 
            // TbMatrixM
            // 
            this.TbMatrixM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixM.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbMatrixM.Location = new System.Drawing.Point(0, 0);
            this.TbMatrixM.Multiline = true;
            this.TbMatrixM.Name = "TbMatrixM";
            this.TbMatrixM.ReadOnly = true;
            this.TbMatrixM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixM.Size = new System.Drawing.Size(471, 218);
            this.TbMatrixM.TabIndex = 2;
            this.TbMatrixM.WordWrap = false;
            // 
            // MatrixOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 449);
            this.Controls.Add(this.ScVertical);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "MatrixOperationForm";
            this.Text = "Form1";
            this.ScVertical.Panel1.ResumeLayout(false);
            this.ScVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).EndInit();
            this.ScVertical.ResumeLayout(false);
            this.ScLeft.Panel1.ResumeLayout(false);
            this.ScLeft.Panel2.ResumeLayout(false);
            this.ScLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScLeft)).EndInit();
            this.ScLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ScRight.Panel1.ResumeLayout(false);
            this.ScRight.Panel1.PerformLayout();
            this.ScRight.Panel2.ResumeLayout(false);
            this.ScRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).EndInit();
            this.ScRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.SplitContainer ScLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbMatrixA;
        private System.Windows.Forms.SplitContainer ScRight;
        private System.Windows.Forms.TextBox TbMatrixB;
        private System.Windows.Forms.TextBox TbMatrixM;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnMultiple;
        private System.Windows.Forms.Button BtnSubstract;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnInv;
    }
}

