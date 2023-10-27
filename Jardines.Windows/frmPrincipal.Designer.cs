namespace Jardines.Windows
{
    partial class frmPrincipal
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
            btnPaises = new Button();
            btnCategorias = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnPaises
            // 
            btnPaises.Image = Properties.Resources.paises;
            btnPaises.Location = new Point(52, 46);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(116, 81);
            btnPaises.TabIndex = 0;
            btnPaises.Text = "Paises";
            btnPaises.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Image = Properties.Resources.categorias;
            btnCategorias.Location = new Point(52, 175);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(116, 81);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.salir;
            btnSalir.Location = new Point(403, 337);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 81);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCategorias);
            Controls.Add(btnPaises);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPaises;
        private Button btnCategorias;
        private Button btnSalir;
    }
}