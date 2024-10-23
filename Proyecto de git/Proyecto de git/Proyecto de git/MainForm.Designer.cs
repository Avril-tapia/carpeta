/*
 * Created by SharpDevelop.
 * User: CC2_PC41
 * Date: 22/10/2024
 * Time: 03:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_de_git
{
	partial class MainForm
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
			this.txtno = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txta1 = new System.Windows.Forms.TextBox();
			this.txta2 = new System.Windows.Forms.TextBox();
			this.txtte = new System.Windows.Forms.TextBox();
			this.txtdi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbse = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtfe = new System.Windows.Forms.DateTimePicker();
			this.btnca = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtno
			// 
			this.txtno.Location = new System.Drawing.Point(211, 99);
			this.txtno.Name = "txtno";
			this.txtno.Size = new System.Drawing.Size(116, 21);
			this.txtno.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(52, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(52, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(52, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "apelido2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(52, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "telefono:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(52, 274);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "Direccion:";
			// 
			// txta1
			// 
			this.txta1.Location = new System.Drawing.Point(211, 143);
			this.txta1.Name = "txta1";
			this.txta1.Size = new System.Drawing.Size(116, 21);
			this.txta1.TabIndex = 6;
			// 
			// txta2
			// 
			this.txta2.Location = new System.Drawing.Point(211, 188);
			this.txta2.Name = "txta2";
			this.txta2.Size = new System.Drawing.Size(116, 21);
			this.txta2.TabIndex = 7;
			// 
			// txtte
			// 
			this.txtte.Location = new System.Drawing.Point(211, 232);
			this.txtte.Name = "txtte";
			this.txtte.Size = new System.Drawing.Size(116, 21);
			this.txtte.TabIndex = 8;
			// 
			// txtdi
			// 
			this.txtdi.Location = new System.Drawing.Point(211, 277);
			this.txtdi.Name = "txtdi";
			this.txtdi.Size = new System.Drawing.Size(116, 21);
			this.txtdi.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(52, 321);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 25);
			this.label6.TabIndex = 10;
			this.label6.Text = "semestre:";
			// 
			// cbse
			// 
			this.cbse.FormattingEnabled = true;
			this.cbse.Location = new System.Drawing.Point(211, 323);
			this.cbse.Name = "cbse";
			this.cbse.Size = new System.Drawing.Size(140, 22);
			this.cbse.TabIndex = 11;
			this.cbse.SelectedIndexChanged += new System.EventHandler(this.CbseSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(52, 366);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 25);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fecha  nacimiento:";
			// 
			// dtfe
			// 
			this.dtfe.Location = new System.Drawing.Point(211, 369);
			this.dtfe.Name = "dtfe";
			this.dtfe.Size = new System.Drawing.Size(233, 21);
			this.dtfe.TabIndex = 13;
			// 
			// btnca
			// 
			this.btnca.Location = new System.Drawing.Point(178, 439);
			this.btnca.Name = "btnca";
			this.btnca.Size = new System.Drawing.Size(87, 25);
			this.btnca.TabIndex = 14;
			this.btnca.Text = "CALCULAR";
			this.btnca.UseVisualStyleBackColor = true;
			this.btnca.Click += new System.EventHandler(this.BtncaClick);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(149, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(164, 25);
			this.label8.TabIndex = 15;
			this.label8.Text = "CALCULA TU RFC";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 493);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnca);
			this.Controls.Add(this.dtfe);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbse);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtdi);
			this.Controls.Add(this.txtte);
			this.Controls.Add(this.txta2);
			this.Controls.Add(this.txta1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtno);
			this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "Proyecto de git";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnca;
		private System.Windows.Forms.DateTimePicker dtfe;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbse;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtdi;
		private System.Windows.Forms.TextBox txtte;
		private System.Windows.Forms.TextBox txta2;
		private System.Windows.Forms.TextBox txta1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtno;
	}
}
