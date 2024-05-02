/*
 * Criado por SharpDevelop.
 * Usuário: Admin
 * Data: 21/03/2024
 * Hora: 16:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace fahrenheit_1_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			float f, c;
			f = float.Parse(textBox1.Text);
			c = 5 * (f - 32) / 9;
			label2.Text = (f.ToString()) + "ºF equivale a " + (c.ToString()) + "ºC";
		}
	}
}
