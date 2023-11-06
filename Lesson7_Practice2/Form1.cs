using System.Windows.Forms;

namespace Lesson7_Practice2
{
    //������� ������ ���������.���������� �� � ����� ����� �����.
    //    �������� �� ������ ����� �������� ������� � ProgressBar.
    //    �� ������� �� ������ ����������� �� �����, ProgressBar
    //    ����������� �� 10 ������ � ��������� ���������.

    public partial class Form1 : Form
    {
        private int progressBarValue = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            progressBarValue = 0;
            progressBar.Value = progressBarValue;

            int total = progressBar.Maximum;
            int stepsSecond = total / 10;
            int step = stepsSecond * timer1.Interval / 1000;


            timer1.Tick += (s, args) =>
            {
                progressBarValue += step;
                progressBar.Value = progressBarValue;

                int remain = (progressBar.Maximum - progressBarValue) / step;
                timeLabel.Text = $"time remain: {remain} sec";
            };
        }
    }
}