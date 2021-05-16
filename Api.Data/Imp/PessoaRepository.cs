using Api.Data.Interfaces;
using Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Data.Imp
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly MainContext _db;

        public PessoaRepository(MainContext db)
        {
            _db = db;
        }

        public void Add(Pessoa pessoa)
        {
            _db.Add(pessoa);
            _db.SaveChanges();
        }

        public Pessoa GetById(int id)
        {
            return _db.Pessoas.Find(id);
        }

        public List<Pessoa> Get()
        {
            return _db.Pessoas.ToList();
        }

        public void Atualizar(Pessoa pessoa)
        {
            _db.Update(pessoa);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var pessoa = GetById(id);
            _db.Remove(pessoa);
            _db.SaveChanges();
        }
    }
}
