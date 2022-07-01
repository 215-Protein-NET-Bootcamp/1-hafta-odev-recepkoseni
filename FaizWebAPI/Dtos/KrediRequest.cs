using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaizWebAPI.Dtos
{
    public class KrediRequest
    {

        [Range(1,double.MaxValue,ErrorMessage ="Value must be between 1 and max value of double")]

        public double Tutar { get; set; }


        [Range(1, double.MaxValue)]
        public int Vade { get; set; }
    }
}
