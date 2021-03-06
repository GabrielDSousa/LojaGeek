﻿using LojaGeek.Model.DB.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGeek.Model.DB.Repository
{
    public class CupomRepository : RepositoryBase<Cupom>
    {
        public CupomRepository(ISession session) : base(session)
        {
        }

        public Cupom GetByName(String nome)
        {
            try
            {
                return this.Session.Query<Cupom>()
                           .Where(w => w.Nome.ToLower() == nome.Trim().ToLower()).First();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
