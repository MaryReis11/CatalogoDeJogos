﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos2.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength =  3, ErrorMessage = "O nome do jogo deve conter entre 6 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage  = "O nome do jogo deve conter entre 6 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no minimo 1 real e no maximo 1000 reais")]
        public double Preco { get; set; }
    }
}
