/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 04/11/2026
 * Hora: 03:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tareaa2._
{
	/// <summary>
	/// Description of CoordenadasDeUnPunto.
	/// </summary>
	public partial class CoordenadasDeUnPunto : Form
	{
		public CoordenadasDeUnPunto()
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
			 double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);

            if (x > 0 && y > 0)
            {
                lblResultado.Text = "Cuadrante I";
            }
            else if (x < 0 && y > 0)
            {
                lblResultado.Text = "Cuadrante II";
            }
            else if (x < 0 && y < 0)
            {
                lblResultado.Text = "Cuadrante III";
            }
            else if (x > 0 && y < 0)
            {
                lblResultado.Text = "Cuadrante IV";
            }
            else if (x == 0 && y == 0)
            {
                lblResultado.Text = "El punto esta en el origen";
            }
            else if (x == 0)
            {
                lblResultado.Text = "Sobre el eje Y";
            }
            else
            {
                lblResultado.Text = "Sobre el eje X";
            }
		}
	}
}
