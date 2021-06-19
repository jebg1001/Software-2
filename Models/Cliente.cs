using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Software_2.Models
{
      [Table("t_cliente")]
    public class Cliente
    {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }

    [Column("nombre")]
    public string Nombre { get; set; }

    [Column("celular")]

    public string Celular{ get; set; }

    [Column("direccion")]

    public string Direccion { get; set; }


    [Column("cantidad")]

    public int Cantidad { get; set; }


    [NotMapped]
    public String Respuesta { get; set; }


    }
}