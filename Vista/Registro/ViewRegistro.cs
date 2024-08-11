﻿using PTC.Controller.Login;
using PTC.Controller.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PTC.Vista.Registro
{
    public partial class ViewRegistro : Form
    {
        public ViewRegistro()
        {
            InitializeComponent();
            ControllerRegistro control = new ControllerRegistro(this);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timevcode_Tick(object sender, EventArgs e)
        {
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string text = txtTelefono.Text;
            string validChars = "0123456789-";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtTelefono.Text = filteredText;
                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombre.Text;
            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);


            if (!regex.IsMatch(text))
            {
                txtNombre.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            string text = txtConfirm.Text;
            string validChars = "0123456789";

            string filteredText = new string(text.Where(c => validChars.Contains(c)).ToArray());

            if (text != filteredText)
            {
                txtConfirm.Text = filteredText;
                txtConfirm.SelectionStart = txtConfirm.Text.Length;
            }
        }
    }
}
