namespace Jardines.Windows
{
	partial class frmCategoriasAE
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriasAE));
			label1 = new Label();
			txtCategoria = new TextBox();
			label2 = new Label();
			txtDescripcion = new TextBox();
			btnCancelar = new Button();
			btnOK = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(54, 38);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 0;
			label1.Text = "Categoría";
			// 
			// txtCategoria
			// 
			txtCategoria.Location = new Point(129, 35);
			txtCategoria.MaxLength = 100;
			txtCategoria.Name = "txtCategoria";
			txtCategoria.Size = new Size(530, 23);
			txtCategoria.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(54, 85);
			label2.Name = "label2";
			label2.Size = new Size(69, 15);
			label2.TabIndex = 0;
			label2.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			txtDescripcion.Location = new Point(129, 82);
			txtDescripcion.MaxLength = 100;
			txtDescripcion.Multiline = true;
			txtDescripcion.Name = "txtDescripcion";
			txtDescripcion.Size = new Size(530, 156);
			txtDescripcion.TabIndex = 1;
			// 
			// btnCancelar
			// 
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(397, 277);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(111, 81);
			btnCancelar.TabIndex = 3;
			btnCancelar.Text = "Cancelar";
			btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnOK
			// 
			btnOK.Image = Properties.Resources.ok;
			btnOK.Location = new Point(258, 277);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(111, 81);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmCategoriasAE
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 382);
			ControlBox = false;
			Controls.Add(btnCancelar);
			Controls.Add(btnOK);
			Controls.Add(txtDescripcion);
			Controls.Add(label2);
			Controls.Add(txtCategoria);
			Controls.Add(label1);
			MaximumSize = new Size(816, 421);
			MinimumSize = new Size(816, 421);
			Name = "frmCategoriasAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCategoriasAE";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtCategoria;
		private Label label2;
		private TextBox txtDescripcion;
		private Button btnCancelar;
		private Button btnOK;
		private ErrorProvider errorProvider1;
	}
}