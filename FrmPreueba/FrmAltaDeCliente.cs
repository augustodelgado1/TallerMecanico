﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico;

namespace FrmPreueba
{
    public partial class FrmAltaDePersona : Form
    {
        OpenFileDialog ofd;
        Persona unaPersona;
        Usuario.Roles unRol;
        public event Action<Persona> seIngesaronDatos;
        bool result;
        string path;

        public FrmAltaDePersona(Usuario.Roles unRol)
        {
            InitializeComponent();
            this.unRol = unRol;
            this.path = null;
        }

        private void OnSeIngesaronDatos(Persona unaPersona)
        {
            if (seIngesaronDatos is not null)
            {
                seIngesaronDatos(unaPersona);
            }
        }
        public FrmAltaDePersona(Usuario.Roles unRol, Persona unaPersona) : this(unRol)
        {
            this.unaPersona = unaPersona;
            SetPersona();
        }
        private void FrmAltaDeCliente_Load(object sender, EventArgs e)
        {
            this.lb_Fallas.Visible = false;
        }
        private void SetPersona()
        {
            if (this.unaPersona is not null)
            {
                this.txtEmail.Text = this.unaPersona.Email;
                this.txtNombre.Text = this.unaPersona.Nombre;
                this.txtDni.Text = this.unaPersona.Dni;
                this.path = this.unaPersona.Path;
                this.txtClave.Visible = false;
                this.txtClave.Text = this.unaPersona.Clave;
                this.DateFechaDeNacimiento.Value = this.unaPersona.FechaDeNacimiento;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            result = lb_Fallas.ActivarControlError<string>("el Nombre Debe Contener solo letras", Persona.ValidarNombre, this.txtNombre.Text);
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            result = lb_Fallas.ActivarControlError<string>("el dni debe tener como min 6 y max 8 numeros", Persona.ValidarDni, this.txtDni.Text);
        }

        private void DateFechaDeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            result = lb_Fallas.ActivarControlError<DateTime>("La fecha no es valida", Persona.ValidarFechaDeNacimiento, this.DateFechaDeNacimiento.Value);
        }
        private Usuario CrearUsuario()
        {
            Usuario unUsuario;

            if (this.unRol == Usuario.Roles.Cliente)
            {
                unUsuario = new Cliente(this.txtNombre.Text, this.txtDni.Text, this.DateFechaDeNacimiento.Value, this.txtEmail.Text, this.txtClave.Text, path);
            }
            else
            {
                unUsuario = new Mecanico(this.txtNombre.Text, this.txtDni.Text, this.DateFechaDeNacimiento.Value, this.txtEmail.Text, this.txtClave.Text);
            }

            return unUsuario;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            result = lb_Fallas.ActivarControlError( "No se aceptan valores vacios", ControlExtended.DetectarTextBoxVacio, this.Controls) == true &&
                lb_Fallas.ActivarControlError( "La fecha no es valida", Persona.ValidarFechaDeNacimiento, this.DateFechaDeNacimiento.Value) == true;
            
            if (result == true)
            {
                this.unaPersona = (Persona)this.CrearUsuario();
                OnSeIngesaronDatos(this.unaPersona);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            result = lb_Fallas.ActivarControlError<string>( "el Clave Debe tener como min 8 caracteres", Persona.ValidarContracenia, this.txtClave.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            result = lb_Fallas.ActivarControlError<string>("el Email Debe tener como min 8 caracteres", Persona.ValidarEmail, this.txtEmail.Text);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            ofd = FrmListar<Cliente>.AbrirArchivo("Imagen de perfil", "Archivos de imagen|*.jpg;*.jpeg;*.png|Todos los archivos|*.*", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            if (ofd is not null)
            {
                this.path = ofd.FileName;
            }
        }
    }
}