﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodenationFinalProject.Repository;

namespace CodenationFinalProject.Models
{
    public class ErrorDTO
    {

        public int Id { get; set; }

        public string ErrorName { get; set; }


    }
}
