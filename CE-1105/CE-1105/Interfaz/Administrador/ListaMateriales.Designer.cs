﻿namespace CE_1105.Interfaz
{
    partial class ListaMateriales
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
            dataGridViewMateriales = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriales).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMateriales
            // 
            dataGridViewMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMateriales.Columns.AddRange(new DataGridViewColumn[] { ID, Material, Unidad, Precio, Estado, Fecha, Descripcion });
            dataGridViewMateriales.Location = new Point(14, 15);
            dataGridViewMateriales.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMateriales.Name = "dataGridViewMateriales";
            dataGridViewMateriales.RowHeadersWidth = 51;
            dataGridViewMateriales.Size = new Size(1397, 533);
            dataGridViewMateriales.TabIndex = 0;
            dataGridViewMateriales.CellContentClick += dataGridViewMateriales_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.MinimumWidth = 6;
            Unidad.Name = "Unidad";
            Unidad.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Tec-colones";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha de creación";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // ListaMateriales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 688);
            Controls.Add(dataGridViewMateriales);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListaMateriales";
            Text = "ListaMateriales";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMateriales;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
    }
}