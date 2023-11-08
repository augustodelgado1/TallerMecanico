﻿namespace TallerMecanico
{
    abstract partial class FrmListarGeneric<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgtvList = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtvList).BeginInit();
            SuspendLayout();
            // 
            // dgtvList
            // 
            dgtvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgtvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgtvList.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dgtvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgtvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgtvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgtvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvList.ImeMode = ImeMode.NoControl;
            dgtvList.Location = new Point(207, 53);
            dgtvList.MultiSelect = false;
            dgtvList.Name = "dgtvList";
            dgtvList.ReadOnly = true;
            dgtvList.RowHeadersVisible = false;
            dgtvList.RowTemplate.Height = 25;
            dgtvList.ScrollBars = ScrollBars.None;
            dgtvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtvList.Size = new Size(683, 351);
            dgtvList.TabIndex = 18;
            dgtvList.CellContentClick += dgtvList_CellContentClick;
            // 
            // col
            // 
            // 
            // col_Email
            // 
            // 
            // col_CantVehiculo
            // 
            // 
            // colTelefono
            // 
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(13, 353);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 51);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoEllipsis = true;
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.FlatStyle = FlatStyle.System;
            btnModificar.Location = new Point(13, 296);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(188, 51);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(13, 239);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 51);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 416);
            Controls.Add(dgtvList);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            this.Load += FrmListarLoad;
            Name = "FrmListar";
            Text = "FrmListar";
            ((System.ComponentModel.ISupportInitialize)dgtvList).EndInit();
            ResumeLayout(false);
        }

       

        #endregion

        private DataGridView dgtvList;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}