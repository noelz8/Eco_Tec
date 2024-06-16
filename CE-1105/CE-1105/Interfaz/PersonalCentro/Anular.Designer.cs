namespace CE_1105.Interfaz
{
    partial class Anular
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
            label1 = new Label();
            dataGridViewMateriales = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Centro = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnAnular = new Button();
            btnAnularRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 12);
            label1.Name = "label1";
            label1.Size = new Size(661, 48);
            label1.TabIndex = 0;
            label1.Text = "Seleccione transaccion a Eliminar";
            // 
            // dataGridViewMateriales
            // 
            dataGridViewMateriales.AllowUserToAddRows = false;
            dataGridViewMateriales.AllowUserToResizeColumns = false;
            dataGridViewMateriales.AllowUserToResizeRows = false;
            dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMateriales.Columns.AddRange(new DataGridViewColumn[] { ID, Centro, Fecha, Material, Cantidad, Precio, Total });
            dataGridViewMateriales.Location = new Point(40, 91);
            dataGridViewMateriales.Name = "dataGridViewMateriales";
            dataGridViewMateriales.ReadOnly = true;
            dataGridViewMateriales.RowHeadersVisible = false;
            dataGridViewMateriales.RowHeadersWidth = 51;
            dataGridViewMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMateriales.Size = new Size(1013, 427);
            dataGridViewMateriales.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 53;
            // 
            // Centro
            // 
            Centro.HeaderText = "Centro";
            Centro.MinimumWidth = 6;
            Centro.Name = "Centro";
            Centro.ReadOnly = true;
            Centro.Width = 82;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha de Registro";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 143;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.ReadOnly = true;
            Material.Width = 93;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 98;
            // 
            // Precio
            // 
            Precio.HeaderText = "Tec-colones";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 117;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 71;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = SystemColors.MenuHighlight;
            btnAnular.ForeColor = SystemColors.ControlLightLight;
            btnAnular.Location = new Point(311, 550);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(150, 59);
            btnAnular.TabIndex = 13;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = false;
            btnAnular.Click += btnAnular_Click;
            // 
            // btnAnularRegresar
            // 
            btnAnularRegresar.BackColor = SystemColors.MenuHighlight;
            btnAnularRegresar.ForeColor = SystemColors.ButtonFace;
            btnAnularRegresar.Location = new Point(529, 550);
            btnAnularRegresar.Name = "btnAnularRegresar";
            btnAnularRegresar.Size = new Size(148, 59);
            btnAnularRegresar.TabIndex = 14;
            btnAnularRegresar.Text = "Regresar";
            btnAnularRegresar.UseVisualStyleBackColor = false;
            btnAnularRegresar.Click += btnAnularRegresar_Click;
            // 
            // Anular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 653);
            Controls.Add(btnAnularRegresar);
            Controls.Add(btnAnular);
            Controls.Add(dataGridViewMateriales);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Anular";
            Text = "Anular";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewMateriales;
        private Button btnAnular;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Centro;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Button btnAnularRegresar;
    }
}