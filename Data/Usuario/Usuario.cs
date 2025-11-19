namespace UI.Data.Usuario
{
    public class Usuario
    {
        public int? id_cuenta_habiente {get; set;}
        public string? nombre { get; set; }
        public int? fk_tipo_documento { get; set; }
        public int? documento { get; set; }
        public string? direccion { get; set; }
        public string? telefono { get; set; }
        public int? fk_ciudad { get; set; }
        public int? clave { get; set; }
    }
}
