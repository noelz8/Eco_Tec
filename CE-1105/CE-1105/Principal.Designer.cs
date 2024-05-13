
namespace CE_1105
{
    partial class Principal
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListaSedeCentro = new TreeView();
            LblSede = new Label();
            BtnCrear = new Button();
            SuspendLayout();
            // 
            // ListaSedeCentro
            // 
            ListaSedeCentro.Font = new Font("Arial", 12,FontStyle.Bold, GraphicsUnit.Point, 0);
            ListaSedeCentro.Location = new Point(12, 56);
            ListaSedeCentro.Name = "ListaSedeCentro";
            ListaSedeCentro.Size = new Size(888, 284);
            ListaSedeCentro.TabIndex = 0;

            // 
            // LblSede
            // 
            LblSede.AutoSize = true;
            LblSede.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSede.Location = new Point(269, 9);
            LblSede.Name = "LblSede";
            LblSede.Size = new Size(130, 44);
            LblSede.TabIndex = 1;
            LblSede.Text = "Sedes";
            // 
            // BtnCrear
            // 
            BtnCrear.BackColor = SystemColors.ControlDarkDark;
            BtnCrear.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrear.Location = new Point(12, 376);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(104, 43);
            BtnCrear.TabIndex = 2;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = false;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(912, 450);
            Controls.Add(BtnCrear);
            Controls.Add(LblSede);
            Controls.Add(ListaSedeCentro);
            Name = "Principal";
            Text = "Bienvenido";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TreeView ListaSedeCentro;
        private Label LblSede;
        private Button BtnCrear;
    }
}