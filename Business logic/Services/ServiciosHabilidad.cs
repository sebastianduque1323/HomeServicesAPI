﻿using Business_logic.Interfaces;
using System;
using Data_access;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_access.Models;
using System.Data.Entity;

namespace Business_logic.Services
{

    /// <summary>Clase para gestionar los servicios CRUD para habilidad,es prestado a los controladores
    /// de la capa de presentación
    /// </summary>
    public class ServiciosHabilidad 
    {

        readonly HomeServicesContext BD = new HomeServicesContext();

        /// <summary>Permite obtener las habilidades generales</summary>
        /// <return>Retorna la lista de habilidades generales obtenidas desde la BD</return>
        public IList<Habilidad> Get()                 
        {
            return BD.Habilidades.ToList();   
        }

    }
}
