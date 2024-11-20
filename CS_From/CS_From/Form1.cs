using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_From
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TestTextBox _testTextBox;

        public Form1()
        {
            InitializeComponent();



            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this,i, (i % 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }

            _testLabel = new TestLabel("らべるです。", 10, 250, 500, 100);

            Controls.Add(_testLabel);

            _testTextBox = new TestTextBox("テキストボックスです", 10, 400, 500, 100);

            Controls.Add(_testTextBox);
            
            /*
            Label label = new Label();
            label.Location = new Point(30,400);
            label.Text = "らべるです。";
            Controls.Add(label);
            */

        }

        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        public string  ButtonLabelReplacement(string str)
        {
            string s = _textBox.TextReplacement(str);

            return s;
        }
    }
}
