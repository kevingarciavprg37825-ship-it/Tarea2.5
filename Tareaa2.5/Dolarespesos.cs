/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 04/11/2026
 * Hora: 07:39 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tareaa2._
{
	/// <summary>
	/// Description of Dolares_a_pesos.
	/// </summary>
	public partial class Dolares_a_pesos : Form
	{
		
		public Dolares_a_pesos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double dolares = Convert.ToDouble(txtDolares.Text);
            double pesos = dolares * 18;

            txtPesos.Text = pesos.ToString();
		}
	}
}
