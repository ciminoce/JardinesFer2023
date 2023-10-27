using Jardines.Entidades.Entidades;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Jardines.DatosSql
{
    public class RepositorioCategorias
    {
        private readonly string _connectionString;

        public RepositorioCategorias()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

		public void Agregar(Categoria categoria)
		{
            using (var conn=new SqlConnection(_connectionString))
            {
                conn.Open();
                string addQuery = @"INSERT INTO Categorias(NombreCategoria, Descripcion)
                    VALUES(@NombreCategoria, @Descripcion); SELECT SCOPE_IDENTITY()";
                using (var cmd = new SqlCommand(addQuery, conn)) { 

                    cmd.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
                    cmd.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

					cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
					cmd.Parameters["@Descripcion"].Value = categoria.Descripcion;

                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    categoria.CategoriaId = id;
				}
			}
		}

		public void Borrar(int categoriaId)
		{
            using (var conn=new SqlConnection(_connectionString))
            {
                conn.Open();
                string deleteQuery = @"DELETE FROM Categorias WHERE CategoriaId=@CategoriaId";
                using (var cmd=new SqlCommand(deleteQuery,conn))
                {
                    cmd.Parameters.Add("@CategoriaId", SqlDbType.Int);
                    cmd.Parameters["@CategoriaId"].Value=categoriaId;

                    cmd.ExecuteNonQuery();
                }
            }
		}

		public void Editar(Categoria categoria)
		{
			using(var conn=new SqlConnection(_connectionString))
            {
                conn.Open();
                string updateQuery = @"UPDATE Categorias SET NombreCategoria=@NombreCategoria, 
                    Descripcion=@Descripcion WHERE CategoriaId=@CategoriaId";
                using (var cmd=new SqlCommand(updateQuery,conn))
                {
					cmd.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
					cmd.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

					cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
					cmd.Parameters["@Descripcion"].Value = categoria.Descripcion;

					cmd.Parameters.Add("@CategoriaId", SqlDbType.Int);
					cmd.Parameters["@CategoriaId"].Value = categoria.CategoriaId;

                    cmd.ExecuteNonQuery();

				}
			}
		}

		public bool EstaRelacionado(Categoria categoria)
		{
			using (var conn = new SqlConnection(_connectionString))
			{
				conn.Open();
				string selectQuery;
				selectQuery = @"SELECT COUNT(*) AS Cantidad FROM Productos
                    WHERE CategoriaId=@CategoriaId";
				using (var cmd = new SqlCommand(selectQuery, conn))
				{

					cmd.Parameters.Add("@CategoriaId", SqlDbType.Int);
					cmd.Parameters["@CategoriaId"].Value = categoria.CategoriaId;

					return (int)cmd.ExecuteScalar() > 0;
				}

			}

		}

		public bool Existe(Categoria categoria)
		{
			using (var conn = new SqlConnection(_connectionString))
			{
				conn.Open();
                string selectQuery;
                if (categoria.CategoriaId==0)
                {
				    selectQuery = @"SELECT COUNT(*) AS Cantidad FROM Categorias
                        WHERE NombreCategoria=@NombreCategoria";
					using (var cmd = new SqlCommand(selectQuery, conn))
					{
						cmd.Parameters.Add("@NombreCategoria",SqlDbType.NVarChar);
                        cmd.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

                        return (int)cmd.ExecuteScalar() > 0;
					}

                }
                else
                {
					selectQuery = @"SELECT COUNT(*) AS Cantidad FROM Categorias
                        WHERE NombreCategoria=@NombreCategoria AND 
                        CategoriaId<>@CategoriaId";
					using (var cmd = new SqlCommand(selectQuery, conn))
					{
						cmd.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
						cmd.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

						cmd.Parameters.Add("@CategoriaId", SqlDbType.Int);
						cmd.Parameters["@CategoriaId"].Value = categoria.CategoriaId;

						return (int)cmd.ExecuteScalar() > 0;
					}

				}
			}
			
		}

		public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open ();
                string selectQuery = @"SELECT CategoriaId , 
                                    NombreCategoria , 
                                    Descripcion FROM Categorias";
                using (var cmd = new SqlCommand(selectQuery , conn)) 
                { 
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = ConstruirCategoria(reader);
                            categorias.Add(categoria);
                        }
                    }                    
                }
            }
            return categorias;
        }

        private Categoria ConstruirCategoria(SqlDataReader reader)
        {
            return new Categoria
            {
                CategoriaId = reader.GetInt32(0),
                NombreCategoria = reader.GetString(1),
                Descripcion = reader.GetString(2)
            };
            
        }
    }
}
