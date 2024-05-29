namespace CE_1105.Interfaz
{
    partial class Historial
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
            comboBoxCentro = new ComboBox();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            buttonBuscar = new Button();
            labelMensaje = new Label();
            dataGridViewTransacciones = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransacciones).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCentro
            // 
            comboBoxCentro.FormattingEnabled = true;
            comboBoxCentro.Location = new Point(628, 10);
            comboBoxCentro.Name = "comboBoxCentro";
            comboBoxCentro.Size = new Size(194, 28);
            comboBoxCentro.TabIndex = 0;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(12, 12);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(280, 27);
            dateTimePickerInicio.TabIndex = 1;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(322, 12);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(290, 27);
            dateTimePickerFin.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(852, 8);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(116, 31);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Location = new Point(22, 397);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(50, 20);
            labelMensaje.TabIndex = 5;
            labelMensaje.Text = "label1";
            // 
            // dataGridViewTransacciones
            // 
            dataGridViewTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransacciones.Location = new Point(12, 61);
            dataGridViewTransacciones.Name = "dataGridViewTransacciones";
            dataGridViewTransacciones.RowHeadersWidth = 51;
            dataGridViewTransacciones.Size = new Size(956, 318);
            dataGridViewTransacciones.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(724, 397);
            button1.Name = "button1";
            button1.Size = new Size(214, 35);
            button1.TabIndex = 6;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(button1);
            Controls.Add(labelMensaje);
            Controls.Add(dataGridViewTransacciones);
            Controls.Add(buttonBuscar);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(comboBoxCentro);
            Name = "Historial";
            Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransacciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCentro;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private Button buttonBuscar;
        private Label labelMensaje;
        private DataGridView dataGridViewTransacciones;
        private Button button1;
    }
}