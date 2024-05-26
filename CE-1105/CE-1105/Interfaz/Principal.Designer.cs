
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
            button1 = new Button();
            SuspendLayout();
            // 
            // ListaSedeCentro
            // 
            ListaSedeCentro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListaSedeCentro.Location = new Point(17, 93);
            ListaSedeCentro.Margin = new Padding(4, 5, 4, 5);
            ListaSedeCentro.Name = "ListaSedeCentro";
            ListaSedeCentro.Size = new Size(1267, 471);
            ListaSedeCentro.TabIndex = 0;
            // 
            // LblSede
            // 
            LblSede.AutoSize = true;
            LblSede.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSede.Location = new Point(384, 15);
            LblSede.Margin = new Padding(4, 0, 4, 0);
            LblSede.Name = "LblSede";
            LblSede.Size = new Size(192, 65);
            LblSede.TabIndex = 1;
            LblSede.Text = "Sedes";
            // 
            // BtnCrear
            // 
            BtnCrear.BackColor = SystemColors.ControlDarkDark;
            BtnCrear.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrear.Location = new Point(17, 627);
            BtnCrear.Margin = new Padding(4, 5, 4, 5);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(149, 72);
            BtnCrear.TabIndex = 2;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = false;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(958, 627);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(280, 72);
            button1.TabIndex = 3;
            button1.Text = "Provisional";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1303, 750);
            Controls.Add(button1);
            Controls.Add(BtnCrear);
            Controls.Add(LblSede);
            Controls.Add(ListaSedeCentro);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Principal";
            Text = "Bienvenido";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TreeView ListaSedeCentro;
        private Label LblSede;
        private Button BtnCrear;
        private Button button1;
    }
}