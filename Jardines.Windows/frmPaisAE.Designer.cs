namespace Jardines.Windows
{
	partial class frmPaisAE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaisAE));
			label1 = new Label();
			txtPais = new TextBox();
			btnOK = new Button();
			btnCancelar = new Button();
			errorProvider1 = new ErrorProvider(components);
			chkActivo = new CheckBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 58);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 0;
			label1.Text = "País:";
			// 
			// txtPais
			// 
			txtPais.Location = new Point(86, 50);
			txtPais.MaxLength = 100;
			txtPais.Name = "txtPais";
			txtPais.Size = new Size(522, 23);
			txtPais.TabIndex = 1;
			// 
			// btnOK
			// 
			btnOK.Image = Properties.Resources.ok;
			btnOK.Location = new Point(194, 123);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(111, 81);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(333, 123);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(111, 81);
			btnCancelar.TabIndex = 3;
			btnCancelar.Text = "Cancelar";
			btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// chkActivo
			// 
			chkActivo.AutoSize = true;
			chkActivo.CheckAlign = ContentAlignment.MiddleRight;
			chkActivo.Location = new Point(40, 89);
			chkActivo.Name = "chkActivo";
			chkActivo.Size = new Size(60, 19);
			chkActivo.TabIndex = 4;
			chkActivo.Text = "Activo";
			chkActivo.UseVisualStyleBackColor = true;
			// 
			// frmPaisAE
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancelar;
			ClientSize = new Size(638, 230);
			Controls.Add(chkActivo);
			Controls.Add(btnCancelar);
			Controls.Add(btnOK);
			Controls.Add(txtPais);
			Controls.Add(label1);
			MaximumSize = new Size(654, 269);
			MinimumSize = new Size(654, 269);
			Name = "frmPaisAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmPaisAE";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtPais;
		private Button btnOK;
		private Button btnCancelar;
		private ErrorProvider errorProvider1;
		private CheckBox chkActivo;
	}
}