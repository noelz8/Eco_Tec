namespace CE_1105
{
    partial class SedeCentro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo = new Label();
            BCentro = new Button();
            BSede = new Button();
            BtnRegresar1 = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Tai Le", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.Location = new Point(92, 26);
            titulo.Name = "titulo";
            titulo.Size = new Size(386, 45);
            titulo.TabIndex = 0;
            titulo.Text = "Seleccione una opcion";
            titulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BCentro
            // 
            BCentro.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCentro.Location = new Point(103, 92);
            BCentro.Name = "BCentro";
            BCentro.Size = new Size(130, 58);
            BCentro.TabIndex = 1;
            BCentro.Text = "Centro de acopio";
            BCentro.UseVisualStyleBackColor = true;
            BCentro.Click += BCentro_Click;
            // 
            // BSede
            // 
            BSede.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSede.Location = new Point(336, 92);
            BSede.Name = "BSede";
            BSede.Size = new Size(132, 58);
            BSede.TabIndex = 2;
            BSede.Text = "Sede";
            BSede.UseVisualStyleBackColor = true;
            BSede.Click += BSede_Click;
            // 
            // BtnRegresar
            // 
            BtnRegresar1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar1.Location = new Point(12, 174);
            BtnRegresar1.Name = "BtnRegresar";
            BtnRegresar1.Size = new Size(91, 37);
            BtnRegresar1.TabIndex = 3;
            BtnRegresar1.Text = "Regresar";
            BtnRegresar1.UseVisualStyleBackColor = true;
            BtnRegresar1.Click += BtnRegresar1_Click;
            // 
            // SedeCentro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 223);
            Controls.Add(BtnRegresar1);
            Controls.Add(BSede);
            Controls.Add(BCentro);
            Controls.Add(titulo);
            Name = "SedeCentro";
            Text = "Sede-Centro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button BCentro;
        private Button BSede;
        private Button BtnRegresar1;
    }
}
