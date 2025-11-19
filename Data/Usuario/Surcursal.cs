namespace UI.Data.Usuario

{
    
    public class Sucursal {
        public int? id_sucursal {get; set;}
        public string? nombre { get; set; }
        public string? telefono { get; set; }
        public string? horario { get; set; }
        public int? fk_tbl_tipo_sucursal { get; set; }
        public int? fk_tbl_ciudad { get; set; }
        public string? direccion {get; set;}
        
    }

}
