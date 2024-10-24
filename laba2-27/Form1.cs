using System;
using System.Windows.Forms;

namespace laba2_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        // Клас для опису вектора в тривимірному просторі
        public class Vector3D
        {
            // Закриті поля для координат вектора
            private double x, y, z;

            // Властивості для доступу до координат
            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }

            public double Z
            {
                get { return z; }
                set { z = value; }
            }

            // Конструктор без параметрів
            public Vector3D()
            {
                x = y = z = 0.0;
            }

            // Конструктор з параметрами
            public Vector3D(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            // Метод для обчислення довжини вектора
            public double Length()
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }

            // Метод для обчислення скалярного добутку двох векторів
            public static double DotProduct(Vector3D v1, Vector3D v2)
            {
                return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
            }

            // Метод для знаходження координат колінеарного вектора
            public Vector3D Collinear(double k)
            {
                return new Vector3D(k * x, k * y, k * z);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox1.Text);
            double y1 = double.Parse(textBox2.Text);
            double z1 = double.Parse(textBox3.Text);

            double x2 = double.Parse(textBox4.Text);
            double y2 = double.Parse(textBox5.Text);
            double z2 = double.Parse(textBox6.Text);

            double k = double.Parse(textBox10.Text);

            // Створення об'єктів векторів
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);

            // Обчислення довжини вектора
            double length1 = vector1.Length();
            textBox7.Text = length1.ToString();

            // Обчислення скалярного добутку
            double dotProduct = Vector3D.DotProduct(vector1, vector2);
            textBox8.Text = dotProduct.ToString();

            // Обчислення колінеарного вектора
            Vector3D collinearVector = vector1.Collinear(k);
            textBox9.Text = $"({collinearVector.X}, {collinearVector.Y}, {collinearVector.Z})";
        }
    }
}
