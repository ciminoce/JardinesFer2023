using Jardines.DatosSql;
using Jardines.Entidades.Entidades;

namespace Jardines.Servicios.Servicios
{
    public class ServiciosCategorias
    {
        public readonly RepositorioCategorias _repositorioCategorias;

        public ServiciosCategorias()
        {
            _repositorioCategorias = new RepositorioCategorias();
        }

		public void Borrar(int categoriaId)
		{
            try
            {
                _repositorioCategorias.Borrar(categoriaId);
            }
            catch (Exception)
            {

                throw;
            }
		}

		public bool EstaRelacionado(Categoria categoria)
		{
            try
            {
                return _repositorioCategorias.EstaRelacionado(categoria);
            }
            catch (Exception)
            {

                throw;
            }
		}

		public bool Existe(Categoria categoria)
		{
            try
            {
                return _repositorioCategorias.Existe(categoria);
            }
            catch (Exception)
            {

                throw;
            }
		}

		public List<Categoria> GetAll()
        {
            try
            {
                return _repositorioCategorias.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

		public void Guardar(Categoria categoria)
		{
            try
            {
                if (categoria.CategoriaId==0)
                {
                    _repositorioCategorias.Agregar(categoria);
                }
                else
                {
                    _repositorioCategorias.Editar(categoria);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
		}
	}
}
