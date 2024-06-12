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
            label1.Location = new Point(339, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(791, 58);
            label1.TabIndex = 0;
            label1.Text = "Seleccione transaccion a Eliminar";
            // 
            // dataGridViewMateriales
            // 
            dataGridViewMateriales.ReadOnly = true;
            dataGridViewMateriales.AllowUserToAddRows = false;
            dataGridViewMateriales.AllowUserToResizeColumns = false;
            dataGridViewMateriales.AllowUserToResizeRows = false;
            dataGridViewMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMateriales.Columns.AddRange(new DataGridViewColumn[] { ID, Centro, Fecha, Material, Cantidad, Precio, Total });
            dataGridViewMateriales.Location = new Point(50, 114);
            dataGridViewMateriales.Margin = new Padding(4);
            dataGridViewMateriales.Name = "dataGridViewMateriales";
            dataGridViewMateriales.RowHeadersVisible = false;
            dataGridViewMateriales.RowHeadersWidth = 51;
            dataGridViewMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMateriales.Size = new Size(1266, 534);
            dataGridViewMateriales.TabIndex = 1;
            dataGridViewMateriales.CellContentClick += dataGridViewMateriales_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 66;
            // 
            // Centro
            // 
            Centro.HeaderText = "Centro";
            Centro.MinimumWidth = 6;
            Centro.Name = "Centro";
            Centro.Width = 101;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha de Registro";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 172;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 111;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 119;
            // 
            // Precio
            // 
            Precio.HeaderText = "Tec-colones";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 140;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 85;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = SystemColors.MenuHighlight;
            btnAnular.ForeColor = SystemColors.ControlLightLight;
            btnAnular.Location = new Point(389, 688);
            btnAnular.Margin = new Padding(4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(188, 74);
            btnAnular.TabIndex = 13;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = false;
            btnAnular.Click += btnAnular_Click;
            // 
            // btnAnularRegresar
            // 
            btnAnularRegresar.BackColor = SystemColors.MenuHighlight;
            btnAnularRegresar.ForeColor = SystemColors.ButtonFace;
            btnAnularRegresar.Location = new Point(661, 688);
            btnAnularRegresar.Margin = new Padding(4);
            btnAnularRegresar.Name = "btnAnularRegresar";
            btnAnularRegresar.Size = new Size(185, 74);
            btnAnularRegresar.TabIndex = 14;
            btnAnularRegresar.Text = "Regresar";
            btnAnularRegresar.UseVisualStyleBackColor = false;
            btnAnularRegresar.Click += btnAnularRegresar_Click;
            // 
            // Anular
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 816);
            Controls.Add(btnAnularRegresar);
            Controls.Add(btnAnular);
            Controls.Add(dataGridViewMateriales);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Anular";
            Text = "Anular";
            Load += Anular_Load;
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