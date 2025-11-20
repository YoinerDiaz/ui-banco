namespace UI.Data.Usuario

{
    
    public class Prestamo {
        public int? id_prestamo { get; set; }
        public int? fk_cuenta_prestamo { get; set; }
        public string? numero { get; set; }
        public double? valor { get; set; }
        public double? interes { get; set; }
        public int? plazo {get; set;}
        public double? saldo {get; set;}
        public double? seguro {get; set;}
        public double? cuota {get; set;}
        
    }

}

