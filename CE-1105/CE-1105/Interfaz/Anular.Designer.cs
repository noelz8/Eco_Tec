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
            ((System.ComponentModel.ISupportInitialize)dataGridViewMateriales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(524, 38);
            label1.TabIndex = 0;
            label1.Text = "Seleccione transaccion a Eliminar";
            // 
            // dataGridViewMateriales
            // 
            dataGridViewMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMateriales.Columns.AddRange(new DataGridViewColumn[] { ID, Centro, Fecha, Material, Cantidad, Precio, Total });
            dataGridViewMateriales.Location = new Point(35, 68);
            dataGridViewMateriales.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMateriales.Name = "dataGridViewMateriales";
            dataGridViewMateriales.RowHeadersWidth = 51;
            dataGridViewMateriales.Size = new Size(886, 320);
            dataGridViewMateriales.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Centro
            // 
            Centro.HeaderText = "Centro";
            Centro.MinimumWidth = 6;
            Centro.Name = "Centro";
            Centro.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha de Registro";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Material
            // 
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Tec-colones";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btnAnular
            // 
            btnAnular.BackColor = SystemColors.MenuHighlight;
            btnAnular.ForeColor = SystemColors.ControlLightLight;
            btnAnular.Location = new Point(361, 412);
            btnAnular.Margin = new Padding(3, 2, 3, 2);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(131, 44);
            btnAnular.TabIndex = 13;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = false;
            btnAnular.Click += new EventHandler(btnAnular_Click);
            // 
            // Anular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 490);
            Controls.Add(btnAnular);
            Controls.Add(dataGridViewMateriales);
            Controls.Add(label1);
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
    }
}