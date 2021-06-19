using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Software_2.Models
{
     [Table("t_nino")]
    public class ProductoN
    {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }

    [Column("nombre")]
    public string Nombre { get; set; }

    [Column("codigo")]

    public string Codigo{ get; set; }

    [Column("color")]

    public string Color { get; set; }

    [Column("sexo")]

    public string Sexo { get; set; }

    [Column("tipo")]

    public string Tipo { get; set; }

    [Column("descri")]

    public string Descripcion { get; set; }

    [Column("talla25")]

    public int Talla25 { get; set; }

    [Column("talla26")]

    public int Talla26 { get; set; }

    [Column("talla27")]

    public int Talla27 { get; set; }

    [Column("talla28")]

    public int Talla28 { get; set; }
    
    [Column("talla29")]

    public int Talla29 { get; set; }

    [Column("talla30")]

    public int Talla30 { get; set; }

    [NotMapped]
    public String Respuesta { get; set; }

    }
}
