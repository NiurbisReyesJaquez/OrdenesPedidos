﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TareaOrdenesDetalle.DAL;
using TareaOrdenesDetalle.Models;

namespace TareaOrdenesDetalle.BLL
{
    public class SuplidoresBLL
    {
        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> criterio)
        {
            List<Suplidores> lista = new List<Suplidores>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Suplidores.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
