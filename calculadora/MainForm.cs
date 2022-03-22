/*
 * Criado por SharpDevelop.
 * Usuário: anabl
 * Data: 20/05/2021
 * Hora: 21:03
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;



namespace calculadora
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			double n1, n2, r;
			n1 = Convert.ToDouble(textBox1.Text);
			n2 = Convert.ToDouble(textBox2.Text);
	     		
			r = n1 + n2;
			textBox3.Text = r.ToString();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			double n1, n2, r;
			n1 = Convert.ToDouble(textBox1.Text);
			n2 = Convert.ToDouble(textBox2.Text);
	     		
			r = n1 - n2;
			textBox3.Text = r.ToString();
	     	
		}
		void Button3Click(object sender, EventArgs e)
		{
			double n1, n2, r;
			n1 = Convert.ToDouble(textBox1.Text);
			n2 = Convert.ToDouble(textBox2.Text);
	     		
			r = n1 * n2;
			textBox3.Text = r.ToString();
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			double n1, n2, r;
			n1 = Convert.ToDouble(textBox1.Text);
			n2 = Convert.ToDouble(textBox2.Text);
	     		
			r = n1 / n2;
			textBox3.Text = r.ToString();
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
	}
}
