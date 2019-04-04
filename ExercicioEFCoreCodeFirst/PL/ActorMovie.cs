using ExercicioEFCoreCodeFirst.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PLk
{
    public class ActorMovie
    {
        [Key]
        public int ActorMovieId { get; set; }
        public String Character { get; set; }

        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        
    }
}
