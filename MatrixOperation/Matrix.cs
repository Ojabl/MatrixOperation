using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperation
{
    class Matrix
    {
        private double[,] data;
        public int Rsize { get {  return data.GetLength(0); } }
        public int Csize { get { return data.GetLength(1); } }

        public Matrix(int Rsize, int Csize)
        {
            data = new double[Rsize, Csize];
        }

        public double this[int r, int c]
        {
            get { return data[r, c]; }
            set { data[r, c] = value; }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            int Rsize = a.Rsize;
            int Csize = a.Csize;

            if(a.Rsize != b.Rsize || a.Csize != b.Csize) throw new ArgumentException("Incompatible sizes");

            Matrix m = new Matrix(Rsize, Csize);

            for (int r = 0; r < Rsize; r++)
            {
                for (int c = 0; c < Csize; c++)
                {
                    m[r, c] = a[r, c] + b[r, c];
                }
            }

            return m;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            int Rsize = a.Rsize;
            int Csize = a.Csize;

            if(a.Rsize != b.Rsize || a.Csize != b.Csize) throw new ArgumentException("Incompatible sizes");

            Matrix m = new Matrix(Rsize, Csize);

            for(int r = 0; r < Rsize; r++)
            {
                for(int c = 0; c < Csize; c++)
                {
                    m[r, c] = a[r, c] - b[r, c];
                }
            }

            return m;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            int Rsize = a.Rsize;
            int Csize = b.Csize;
            int Dsize = a.Csize;

            if(Dsize != b.Rsize) throw new ArgumentException("Incompatible sizes");

            Matrix m = new Matrix(Rsize, Csize);

            for(int r = 0; r <Rsize; r++)
            {
                for(int c = 0; c < Csize; c++)
                {
                    double sum = 0;
                    for(int d = 0; d < Dsize; d++)
                    {
                        sum += a[r,d] * b[d,c];
                    }
                    m[r, c] = sum;
                }
                
            }

            return m;
        }

        public static bool TryParse(string text, out Matrix m)
        {
            m = null;

            string[] rows = text.Split("\r\n\v\f".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int Rsize = rows.Length;
            int Csize = 0;

            for (int r = 0; r < Rsize; r++)
            {
                string[] cols = rows[r].Split(" \t;".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r <= 0)
                {
                    Csize = cols.Length;
                    m = new Matrix(Rsize, Csize);
                }
                else if (Csize != cols.Length) return false;
                for (int c = 0; c < Csize; c++)
                {
                    double value;
                    if (!double.TryParse(cols[c], out value)) return false;
                    m[r,c] = value;
                }
            }
            return (m != null);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int Rsize = this.Rsize;
            int Csize = this.Csize;

            for (int r = 0; r < Rsize; r++)
            {
                for (int c = 0; c < Csize; c++)
                {
                    if(c > 0) sb.Append("\t");
                    sb.Append(data[r, c]);
                }
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
