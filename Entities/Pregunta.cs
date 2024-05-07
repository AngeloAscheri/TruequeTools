﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
 
Esta clase establece la entidad "Comentario" y sus atributos
 
 */

namespace TruequeTools.Entities
{

    [Table("preguntas")]

    public class Pregunta
    {

        //ID UNIVOCO

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        //DATOS INGRESADOS POR EL USUARIO

        [Column("texto")]
        [MaxLength(255)]
        public string? Texto { get; set; }

        [Column("respuesta")]
        [MaxLength(255)]
        public string? Respuesta { get; set; }

        //CLAVE EXTERNA PUBLICACION

        [Column("publicacionId")]
        public int PublicacionId { get; set; }

        //ATRIBUTOS NO SQL

        public DateTime Fecha { get; set; }

        public Publicacion? Publicacion { get; set; }

        public int? IdPreguntaPadre { get; set; }



    }

}

