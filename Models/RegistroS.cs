using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Software_2.Models
{
     [Table("t_ventas")]
    public class RegistroS
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

    [Column("cantidad")]

    public int Cantidad { get; set; }

    [NotMapped]
    public String Respuesta { get; set; }

    }
}
