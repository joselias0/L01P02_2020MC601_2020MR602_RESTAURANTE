﻿using System.ComponentModel.DataAnnotations;
namespace L01P02_2020MC601_2020MR602.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string? nombreMotorista { get; set; }
    }
}
