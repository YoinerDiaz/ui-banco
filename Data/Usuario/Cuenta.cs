namespace UI.Data.Usuario

{
    
    public class Cuenta {
        public int? id_cuenta { get; set; }
        public string? numero { get; set; }
        public int? fk_tipo_cuenta { get; set; }
        public int? fk_sucursal { get; set; }
        public double? saldo { get; set; }
        public double? sobregiro { get; set; }
        public bool gran_movimiento {get; set;}
        public bool sobregiro_no_autorizado {get; set;}
    }

}