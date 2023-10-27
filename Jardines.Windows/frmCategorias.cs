using Jardines.Entidades.Entidades;
using Jardines.Servicios.Servicios;

namespace Jardines.Windows
{
	public partial class frmCategorias : Form
	{
		private readonly ServiciosCategorias _serviciosCategorias;
		private List<Categoria> listaCategorias;
		public frmCategorias()
		{
			InitializeComponent();
			_serviciosCategorias = new ServiciosCategorias();
		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmCategorias_Load(object sender, EventArgs e)
		{
			try
			{
				listaCategorias = _serviciosCategorias.GetAll();
				MostrarDatosEnGrilla();
			}
			catch (Exception)
			{

				throw;
			}
		}
		private void MostrarDatosEnGrilla()
		{
			dgvDatos.Rows.Clear();

			foreach (var item in listaCategorias)
			{
				DataGridViewRow r = ConstruirFila();
				SetearFila(r, item);
				AgregarFila(r);
			}
		}

		private void AgregarFila(DataGridViewRow r)
		{
			dgvDatos.Rows.Add(r);
		}

		private void SetearFila(DataGridViewRow r, Categoria item)
		{
			r.Cells[colCategoria.Index].Value = item.NombreCategoria;
			r.Cells[colDescripcion.Index].Value = item.Descripcion;
			r.Tag = item;
		}

		private DataGridViewRow ConstruirFila()
		{
			DataGridViewRow r = new DataGridViewRow();
			r.CreateCells(dgvDatos);
			return r;
		}

		private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmCategoriasAE frm = new frmCategoriasAE() { Text = "Nueva Categoría" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				Categoria categoria = frm.GetCategoria();
				if (!_serviciosCategorias.Existe(categoria))
				{
					_serviciosCategorias.Guardar(categoria);
					DataGridViewRow r = ConstruirFila();
					SetearFila(r, categoria);
					AgregarFila(r);
					MessageBox.Show("Registro Agregado!!!",
						"Mensaje",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				}
				else
				{
					MessageBox.Show("Registro Duplicado!!!",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

			}
		}

		private void tsbBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			DataGridViewRow r = dgvDatos.SelectedRows[0];
			Categoria categoria = (Categoria)r.Tag;
			DialogResult dr = MessageBox.Show($"¿Desea borrar la categoría {categoria.ToString()}?",
				"Confirmar eliminación",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.No) { return; }
			try
			{

				if (!_serviciosCategorias.EstaRelacionado(categoria))
				{
					_serviciosCategorias.Borrar(categoria.CategoriaId);
					QuitarFila(r);

					MessageBox.Show("Registro Borrado!!!",
						"Mensaje",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				}
				else
				{
					MessageBox.Show("Registro Relacionado!!!",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);

				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

			}
		}


		private void QuitarFila(DataGridViewRow r)
		{
			dgvDatos.Rows.Remove(r);
		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			var categoria=(Categoria)r.Tag;
			var categoriaCopia = (Categoria)categoria.Clone();
			frmCategoriasAE frm = new frmCategoriasAE() { Text = "Editar Categoría" };
			frm.SetCategoria(categoria);
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			categoria = frm.GetCategoria();
			try
			{

				if (!_serviciosCategorias.Existe(categoria))
				{
					_serviciosCategorias.Guardar(categoria);
					SetearFila(r, categoria);


					MessageBox.Show("Registro Editado!!!",
						"Mensaje",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				}
				else
				{
					SetearFila(r, categoriaCopia);

					MessageBox.Show("Registro Duplicado!!!",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

			}
		}
	}
}
