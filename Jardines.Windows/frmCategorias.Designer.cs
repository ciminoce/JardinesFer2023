namespace Jardines.Windows
{
	partial class frmCategorias
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			panel3 = new Panel();
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			tsbBorrar = new ToolStripButton();
			tsbEditar = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			tsbBuscar = new ToolStripButton();
			tsbActualizar = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			tsbCerrar = new ToolStripButton();
			panel2 = new Panel();
			dgvDatos = new DataGridView();
			colCategoria = new DataGridViewTextBoxColumn();
			colDescripcion = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			panel3.SuspendLayout();
			toolStrip1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.Controls.Add(toolStrip1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(800, 74);
			panel3.TabIndex = 5;
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbBuscar, tsbActualizar, toolStripSeparator2, tsbCerrar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 70);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(52, 67);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbNuevo.Click += tsbNuevo_Click;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
			tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBorrar.ImageTransparentColor = Color.Magenta;
			tsbBorrar.Name = "tsbBorrar";
			tsbBorrar.Size = new Size(52, 67);
			tsbBorrar.Text = "Borrar";
			tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbBorrar.Click += tsbBorrar_Click;
			// 
			// tsbEditar
			// 
			tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
			tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
			tsbEditar.ImageTransparentColor = Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new Size(52, 67);
			tsbEditar.Text = "Editar";
			tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbEditar.Click += tsbEditar_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 70);
			// 
			// tsbBuscar
			// 
			tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
			tsbBuscar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBuscar.ImageTransparentColor = Color.Magenta;
			tsbBuscar.Name = "tsbBuscar";
			tsbBuscar.Size = new Size(46, 67);
			tsbBuscar.Text = "Buscar";
			tsbBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(63, 67);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 70);
			// 
			// tsbCerrar
			// 
			tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
			tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbCerrar.ImageTransparentColor = Color.Magenta;
			tsbCerrar.Name = "tsbCerrar";
			tsbCerrar.Size = new Size(44, 67);
			tsbCerrar.Text = "Cerrar";
			tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbCerrar.Click += tsbCerrar_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(dgvDatos);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 74);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 300);
			panel2.TabIndex = 4;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dgvDatos.AllowUserToResizeColumns = false;
			dgvDatos.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCategoria, colDescripcion });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowTemplate.Height = 25;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(800, 300);
			dgvDatos.TabIndex = 0;
			// 
			// colCategoria
			// 
			colCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colCategoria.HeaderText = "Categoria";
			colCategoria.Name = "colCategoria";
			colCategoria.ReadOnly = true;
			// 
			// colDescripcion
			// 
			colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colDescripcion.HeaderText = "Descripcion";
			colDescripcion.Name = "colDescripcion";
			colDescripcion.ReadOnly = true;
			// 
			// panel1
			// 
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 374);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 76);
			panel1.TabIndex = 3;
			// 
			// frmCategorias
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "frmCategorias";
			Text = "frmCategorias";
			Load += frmCategorias_Load;
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private ToolStrip toolStrip1;
		private ToolStripButton tsbNuevo;
		private ToolStripButton tsbBorrar;
		private ToolStripButton tsbEditar;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton tsbBuscar;
		private ToolStripButton tsbActualizar;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton tsbCerrar;
		private Panel panel2;
		private DataGridView dgvDatos;
		private Panel panel1;
		private DataGridViewTextBoxColumn colCategoria;
		private DataGridViewTextBoxColumn colDescripcion;
	}
}