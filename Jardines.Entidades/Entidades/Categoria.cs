namespace Jardines.Entidades.Entidades
{
    public class Categoria:ICloneable
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public override string ToString()
		{
			return $"{NombreCategoria}";
		}
	}
}
