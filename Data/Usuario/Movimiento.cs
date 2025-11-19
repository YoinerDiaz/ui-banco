namespace UI.Data.Usuario

{

    public class Movimiento
    {
        public int? fk_cuenta_movimiento { get; set; }
        public int? fk_sucursal_movimiento { get; set; }
        public double? valor { get; set; }
        public int? fk_tipo_movimiento { get; set; }
        public string? descripcion { get; set; }
    }

}





