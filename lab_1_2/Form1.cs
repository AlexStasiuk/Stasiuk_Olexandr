using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_2
{
	public partial class Form1 : Form
	{
		private AbstractShape abstractShape;
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedState = comboBox1.SelectedItem.ToString();
			if (selectedState == comboBox1.Items[0].ToString())
			{
				label1.Text = "Радіус";
				label1.Left = 150;
				label2.Visible = false;
				textBox2.Visible = false;
				abstractShape = new Circle();
				abstractShape.ShapeName = "Коло";
			}
			else if (selectedState == comboBox1.Items[1].ToString())
			{
				label1.Text = "Сторона квадрата";
				label2.Visible = false;
				textBox2.Visible = false;
				label1.Left = 100;
				abstractShape = new Square();
				abstractShape.ShapeName = "Квадрат";
			}
			else if (selectedState == comboBox1.Items[2].ToString())
			{
				label1.Text = "Сторона прямокутника 1";
				label2.Text = "Сторона прямокутника 2";
				label2.Visible = true;
				textBox2.Visible = true;
				label1.Left = 50;
				label2.Left = 50;
				abstractShape = new Rectangle();
				abstractShape.ShapeName = "Прямокутник";
			}

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			abstractShape.Parameter[0] = Convert.ToDouble(textBox1.Text);
			try { 
				abstractShape.Parameter[1] = Convert.ToDouble(textBox2.Text); 
			} catch(Exception exception) { 
				
			}
			MessageBox.Show(abstractShape.getMessage());
				
			
		}
	}
}
