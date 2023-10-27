using Jardines.Entidades.Entidades;

namespace Jardines.Windows
{
	public partial class frmPaisAE : Form
	{
		public frmPaisAE()
		{
			InitializeComponent();
		}
		private Pais pais;
		internal Pais GetPais()
		{
			return pais;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			chkActivo.Visible = false;
			chkActivo.Checked = true;
			if (pais != null)
			{
				txtPais.Text = pais.NombrePais;
				chkActivo.Checked = pais.Activo;
				chkActivo.Visible = true;
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				if (pais == null)
				{
					pais = new Pais();
					
				}
				pais.NombrePais = txtPais.Text;
				pais.Activo=chkActivo.Checked;
				DialogResult = DialogResult.OK;
			}
		}

		private bool ValidarDatos()
		{
			bool valid = true;
			errorProvider1.Clear();

			if (string.IsNullOrEmpty(txtPais.Text))
			{
				valid = false;
				errorProvider1.SetError(txtPais, "Nombre de País requerido!!!");
			}
			return valid;
		}

		public void SetPais(Pais pais)
		{
			this.pais = pais;
		}
	}
}
