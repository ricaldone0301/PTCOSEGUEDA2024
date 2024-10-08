﻿using PTC.Controller.Cita;
using PTC.Controller.Procedimiento;
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

namespace PTC.Vista.AgregarProcedimiento
{
    public partial class ViewAgregarProcedimiento : Form
    {
        //Se obtienen las variables de creacion
        public ViewAgregarProcedimiento(int accion)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarProcedimientos ObjAgregarProcedimientos = new ControllerAgregarProcedimientos(this, accion);
        }

        //Se obtienen las variables de actualizacion en la vista
        public ViewAgregarProcedimiento(int accion, int procedimientoID, string nombreProcedimiento, decimal precioProcedimiento, string descProcedimiento)
        {
            InitializeComponent();
            TextBoxMenuEliminar();
            ControllerAgregarProcedimientos ObjAgregarProcedimiento = new ControllerAgregarProcedimientos(this, accion, procedimientoID, nombreProcedimiento, precioProcedimiento, descProcedimiento);
        }

        private void ContextMenuEliminar(TextBox textBox)
        {
            var menuContexto = new ContextMenuStrip();
            textBox.ContextMenuStrip = menuContexto;
        }

        public void TextBoxMenuEliminar()
        {
            ContextMenuEliminar(txtDescripcion);
            ContextMenuEliminar(txtNombreProcedimiento);
            ContextMenuEliminar(txtPrecio);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreProcedimiento_TextChanged(object sender, EventArgs e)
        {
            string text = txtNombreProcedimiento.Text;

            string pattern = @"^[a-zA-Z\s]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtNombreProcedimiento.Text = new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

                txtNombreProcedimiento.SelectionStart = txtNombreProcedimiento.Text.Length;
            }
            if (txtNombreProcedimiento.Text.Length > 255)
            {
                txtNombreProcedimiento.Text = txtNombreProcedimiento.Text.Substring(0, 255);

                txtNombreProcedimiento.SelectionStart = txtNombreProcedimiento.Text.Length;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            string text = txtDescripcion.Text;

            string pattern = @"^[a-zA-Z\s.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtDescripcion.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtDescripcion.SelectionStart = txtNombreProcedimiento.Text.Length;
            }

            if (txtDescripcion.Text.Length > 400)
            {
                txtDescripcion.Text = txtDescripcion.Text.Substring(0, 400);

                txtDescripcion.SelectionStart = txtDescripcion.Text.Length;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            string text = txtPrecio.Text;

            string pattern = @"^[0-9.,]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(text))
            {
                txtPrecio.Text = new string(text.Where(c => char.IsLetter(c) ||
                                                                          char.IsWhiteSpace(c) ||
                                                                          c == '.' ||
                                                                          c == ',').ToArray());

                txtPrecio.SelectionStart = txtNombreProcedimiento.Text.Length;
            }
        }
    }
    
}
