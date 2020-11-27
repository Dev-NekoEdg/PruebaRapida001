using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PruebaRapida.Domain
{
    [Table("VideoJuego")]
    public class Game
    {
        [Key]
        [Column("Id")]
        public int Id { get; private set; }

        [Column("Nombre")]
        public string Name { get; set; }

    }
}
