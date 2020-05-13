using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Integration
{
    public partial class Form1 : Form
    {
        private List<double> _X = new List<double>();
        private List<double> _Y = new List<double>();

        private double _numberOfPoints;
        private double _initial_X;
        private double _final_X;
        private double _step;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateValueTable_Button_Click(object sender, EventArgs e)
        {
            function_dataGridView.Rows.Clear();

            _X.Clear();
            _Y.Clear();

            string tempStrNumberOfPoints = step_textBox.Text;
            string tempStrInitialX = initialX_textBox.Text;
            string tempStrFinalX = finalX_textBox.Text;

            try
            {
                tempStrNumberOfPoints.Trim();
                tempStrInitialX.Trim();
                tempStrFinalX.Trim();

                _numberOfPoints = Convert.ToUInt32(tempStrNumberOfPoints);
                _initial_X = Convert.ToDouble(tempStrInitialX);
                _final_X = Convert.ToDouble(tempStrFinalX);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
                return;
            }

            _step = (_final_X - _initial_X) / _numberOfPoints;

            for (double i = _initial_X; i <= _final_X; i += _step)
            {
                _X.Add(i);
                _Y.Add(TestFunction(i));


                function_dataGridView.Rows.Add(i, TestFunction(i));
            }
        }

        private double TestFunction(double x)
        {
            return x / Math.Sqrt(x * x + 1);
        }

        private double calculateLeftRectangles(double leftBound, double rightBound, double numberOfPoints)
        {
            var step = (rightBound - leftBound) / numberOfPoints;

            double sum = 0;
            for (double x = leftBound; x <= rightBound; x += step)
            {
                sum += TestFunction(x);
            }

            return sum * step;
        }

        private double calculateRightRectangles(double leftBound, double rightBound, double numberOfPoints)
        {
            var step = (rightBound - leftBound) / numberOfPoints;

            double sum = 0;
            for (double x = rightBound; x >= leftBound; x -= step)
            {
                sum += TestFunction(x);
            }

            return sum * step;
        }

        private double calculateCentralRectangles(double leftBound, double rightBound, double numberOfPoints)
        {
            var step = (rightBound - leftBound) / numberOfPoints;

            double sum = 0;
            for (double x = leftBound; x <= rightBound; x += step)
            {
                sum += TestFunction(x - step / 2);
            }

            return sum * step;
        }

        private double calculateTrapezoidalRule(double leftBound, double rightBound)
        {
            var step = (rightBound - leftBound) / 2;

            return (TestFunction(leftBound) + TestFunction(rightBound)) * step;
        }

        private void buttonLeftRectangles_Click(object sender, EventArgs e)
        {
            var section =
                Interaction.InputBox("Input left and right borders for integration using the LEFT rectangles method: ", "Left rectangles method").Split(' ');

            var numberOfPoints = Convert.ToDouble(Interaction.InputBox("Input numbers of points: "));

            LeftSquares_textBox.Text = Convert.ToString(calculateLeftRectangles(Convert.ToDouble(section[0]), Convert.ToDouble(section[1]), numberOfPoints));
        }

        private void buttonRightRectangles_Click(object sender, EventArgs e)
        {
            var section =
                Interaction.InputBox("Input left and right borders for integration using the RIGHT rectangles method: ", "Right rectangles method").Split(' ');

            var numberOfPoints = Convert.ToDouble(Interaction.InputBox("Input numbers of points: "));

            RightSquares_textBox.Text = Convert.ToString(calculateRightRectangles(Convert.ToDouble(section[0]), Convert.ToDouble(section[1]), numberOfPoints));
        }

        private void buttonCentralRectangles_Click(object sender, EventArgs e)
        {
            var section =
                Interaction.InputBox("Input left and right borders for integration using the CENTRAL rectangles method: ", "Central rectangles method").Split(' ');

            var numberOfPoints = Convert.ToDouble(Interaction.InputBox("Input numbers of points: "));

            CentralSquares_textBox.Text = Convert.ToString(calculateCentralRectangles(Convert.ToDouble(section[0]), Convert.ToDouble(section[1]), numberOfPoints));
        }

        private void buttonTrapezoidalRule_Click(object sender, EventArgs e)
        {
            var section =
                Interaction.InputBox("Input left and right borders for integration using the TRAPEZOIDAL rule: ", "Trapezoidal rule").Split(' ');

            var numberOfPoints = Convert.ToDouble(Interaction.InputBox("Input numbers of points: "));

            TrapezeSquares_textBox.Text = Convert.ToString(calculateTrapezoidalRule(Convert.ToDouble(section[0]), Convert.ToDouble(section[1])));
        }

        private void button1stDerivation_Click(object sender, EventArgs e)
        {
            string tempStr = X_1stDerivation_textBox.Text;

            double point;
            try
            {
                tempStr.Trim();
                point = Convert.ToDouble(tempStr);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
                return;
            }

            var previousPoint = _Y[_X.IndexOf(point) - 1];
            var nextPoint = _Y[_X.IndexOf(point) + 1];

            FirstDerivation_textBox.Text = Convert.ToString(1 / (2 * _step) * (nextPoint - previousPoint));
        }

        private void button2ndDerivation_Click(object sender, EventArgs e)
        {
            string tempStr = X_2ndDerivation_textBox.Text;

            double point;
            try
            {
                tempStr.Trim();
                point = Convert.ToDouble(tempStr);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
                return;
            }

            var previousPoint = _Y[_X.IndexOf(point) - 1];
            var actualPoint = _Y[_X.IndexOf(point)];
            var nextPoint = _Y[_X.IndexOf(point) + 1];

            SecondDerivation_textBox.Text = Convert.ToString((1 / (_step * _step)) * (nextPoint - 2 * actualPoint + previousPoint)); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _X.Clear();
            _Y.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
            {
                var temp = reader.ReadLine().Split(new char[] { ' ' });
                for (int i = 0; i < temp.Length; i++)
                {
                    _X.Add(Convert.ToDouble(temp[i]));
                }

                temp = reader.ReadLine().Split(new char[] { ' ' });
                for (int i = 0; i < temp.Length; i++)
                {
                    _Y.Add(Convert.ToDouble(temp[i]));
                }

                reader.Close();
            }

            for (int i = 0; i < _X.Count; i++)
            {
                function_dataGridView.Rows.Add(_X[i], _Y[i]);
            }

            _initial_X = _X.First();
            _final_X = _X.Last();

            _numberOfPoints = _X.Count;

            _step = _X[1] - _X[0];
        }
    }
}
