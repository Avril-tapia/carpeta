﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC41
 * Date: 22/10/2024
 * Time: 03:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_git
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CbseSelectedIndexChanged(object sender, EventArgs e)
		{
			InitializeComponent();
    		cbse.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6"});
		}
		
		void BtncaClick(object sender, EventArgs e)
		{
			string nombre = txtno.Text;
            string apellido1 = txta1.Text;
            string apellido2 = txta2.Text;
            DateTime fechaNacimiento = dtfe.Value;

            string rfc = CalcularRFC(nombre, apellido1, apellido2, fechaNacimiento);
            MessageBox.Show("RFC: " + rfc, "Resultado");
        }
            
            private string CalcularRFC(string nombre, string apellido1, string apellido2, DateTime fechaNacimiento)
        {
            // Tomar las primeras letras de los apellidos y el nombre
            string rfc = apellido1.Substring(0, 2) + apellido2.Substring(0, 1) + nombre.Substring(0, 1);
            
            rfc += fechaNacimiento.ToString("yyMMdd");
            return rfc.ToUpper();
		}
	}
}
