using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Software_2.Models
{
     [Table("t_hombre")]
    public class ProductoH
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

    [Column("tipo")]

    public string Tipo { get; set; }

    [Column("descri")]

    public string Descripcion { get; set; }

    [Column("talla40")]

    public int Talla40 { get; set; }

    [Column("talla41")]

    public int Talla41 { get; set; }

    [Column("talla42")]

    public int Talla42 { get; set; }

    [Column("talla43")]

    public int Talla43 { get; set; }
    

    [NotMapped]
    public String Respuesta { get; set; }

    }
}
