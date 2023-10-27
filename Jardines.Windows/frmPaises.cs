using Jardines.Entidades.Entidades;
using Jardines.Servicios.Servicios;

namespace Jardines.Windows
{
	public partial class frmPaises : Form
	{

		private readonly ServiciosPaises _serviciosPaises;
		List<Pais> listaPaises;

		public frmPaises()
		{
			InitializeComponent();
			_serviciosPaises = new ServiciosPaises();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPaises_Load(object sender, EventArgs e)
		{
			try
			{
				listaPaises = _serviciosPaises.GetAll();
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

			foreach (var item in listaPaises)
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

		private void SetearFila(DataGridViewRow r, Pais item)
		{
			r.Cells[colPais.Index].Value = item.NombrePais;
			r.Cells[colActivo.Index].Value = item.Activo;
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
			frmPaisAE frm = new frmPaisAE() { Text = "Agregar País" };
			DialogResult dr = frm.ShowDialog(this);

			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				Pais pais = frm.GetPais();
				_serviciosPaises.Guardar(pais);
				var r = ConstruirFila();
				SetearFila(r, pais);
				AgregarFila(r);
				MessageBox.Show("Registro agregado satisfactoriamente",
					"Mensaje",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				Exception exc = ex;
				if (ex.Message != null && ex.Message.Contains("IX"))
				{
					exc = new Exception("Registro duplicado");
				}
				MessageBox.Show(exc.Message,
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
			var r = dgvDatos.SelectedRows[0];
			Pais pais = (Pais)r.Tag;
			DialogResult dr = MessageBox.Show($"Desea dar de baja a {pais.NombrePais}?",
				"Confirmar operación",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.No)
			{
				return;
			}
			try
			{
				_serviciosPaises.Borrar(pais.PaisId);
				QuitarFila(r);
				MessageBox.Show($"Registro borrado satisfactoriamente!!!",
				"Mensaje",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{

				Exception exc = ex;
				if (ex.Message != null && ex.Message.Contains("REFERENCE"))
				{
					exc = new Exception("Registo relacionado...baja denegada!");
				}
				MessageBox.Show(exc.Message,
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
			Pais pais = (Pais)r.Tag;

			frmPaisAE frm = new frmPaisAE() { Text = "Editar País" };
			frm.SetPais(pais);
			DialogResult dr = frm.ShowDialog(this);

			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				pais = frm.GetPais();
				_serviciosPaises.Guardar(pais);
				SetearFila(r, pais);
				MessageBox.Show("Registro editado satisfactoriamente",
									"Mensaje",
									MessageBoxButtons.OK,
									MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				Exception exc = ex;
				if (ex.Message != null && ex.Message.Contains("IX"))
				{
					exc = new Exception("Registro duplicado");
				}
				MessageBox.Show(exc.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

		}
	}
}