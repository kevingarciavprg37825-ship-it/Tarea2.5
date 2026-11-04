/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 04/11/2026
 * Hora: 03:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Tareaa2._
{
	partial class CoordenadasDeUnPunto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coordenadas de un punto";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Coordenada x:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(268, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Coordenada y: ";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(154, 58);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(100, 26);
			this.txtX.TabIndex = 3;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(389, 54);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(100, 26);
			this.txtY.TabIndex = 4;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(32, 104);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(83, 34);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(175, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Resultado: ";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(282, 104);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(127, 23);
			this.lblResultado.TabIndex = 7;
			// 
			// CoordenadasDeUnPunto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 176);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CoordenadasDeUnPunto";
			this.Text = "CoordenadasDeUnPunto";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
