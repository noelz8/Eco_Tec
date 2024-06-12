namespace CE_1105.Interfaz
{
    partial class VistaGlobal
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
            dataGridViewGlobal = new DataGridView();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            buttonBuscar = new Button();
            buttonVolver = new Button();
            labelMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGlobal
            // 
            dataGridViewGlobal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGlobal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGlobal.Location = new Point(12, 66);
            dataGridViewGlobal.Name = "dataGridViewGlobal";
            dataGridViewGlobal.RowHeadersWidth = 51;
            dataGridViewGlobal.Size = new Size(1041, 314);
            dataGridViewGlobal.TabIndex = 0;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(26, 23);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(296, 27);
            dateTimePickerInicio.TabIndex = 1;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(351, 23);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(295, 27);
            dateTimePickerFin.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(693, 21);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(166, 29);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(845, 434);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(182, 43);
            buttonVolver.TabIndex = 4;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Location = new Point(26, 445);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(50, 20);
            labelMensaje.TabIndex = 5;
            labelMensaje.Text = "label1";
            // 
            // VistaGlobal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 489);
            Controls.Add(labelMensaje);
            Controls.Add(buttonVolver);
            Controls.Add(buttonBuscar);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(dataGridViewGlobal);
            Name = "VistaGlobal";
            Text = "VistaGlobal";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlobal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewGlobal;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private Button buttonBuscar;
        private Button buttonVolver;
        private Label labelMensaje;
    }
}