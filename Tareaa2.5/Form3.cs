/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC01
 * Fecha: 04/11/2026
 * Hora: 09:04 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tareaa2._
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double x1, x2, y1, y2, d;
			x1=Convert.ToDouble(textBox1.Text);
			y1=Convert.ToDouble(textBox2.Text);
			x2=Convert.ToDouble(textBox3.Text);
			y2=Convert.ToDouble(textBox4.Text);
			d=Math.Sqrt(Math.Pow(x2-x2, 2)+Math.Pow(y2-y1,2));
			MessageBox.Show("la distancia entre el punto a y b es: "+d.ToString("0,##"));
		}
	}

}
