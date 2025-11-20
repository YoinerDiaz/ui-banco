namespace UI.Data.Usuario
{
    public class Movimiento
    {
        public int id_movimiento { get; set; }
        public int fk_cuenta_movimiento { get; set; }
        public int fk_sucursal_movimiento { get; set; }
        public int fk_tipo_movimiento { get; set; }
        public decimal valor { get; set; }
        public string? descripcion { get; set; }
    }
}
