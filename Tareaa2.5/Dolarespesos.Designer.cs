/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 04/11/2026
 * Hora: 07:39 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Tareaa2._
{
	partial class Dolares_a_pesos
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
			this.txtDolares = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPesos = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(174, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dolares a pesos";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dolares ";
			// 
			// txtDolares
			// 
			this.txtDolares.Location = new System.Drawing.Point(105, 75);
			this.txtDolares.Name = "txtDolares";
			this.txtDolares.Size = new System.Drawing.Size(100, 26);
			this.txtDolares.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(269, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Pesos";
			// 
			// txtPesos
			// 
			this.txtPesos.Location = new System.Drawing.Point(355, 72);
			this.txtPesos.Name = "txtPesos";
			this.txtPesos.Size = new System.Drawing.Size(100, 26);
			this.txtPesos.TabIndex = 4;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(211, 121);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(90, 32);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// Dolares_a_pesos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 165);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtPesos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDolares);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Dolares_a_pesos";
			this.Text = "Dolares_a_pesos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtPesos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDolares;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
