using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class PassportContext : IDB<Passport, int>
    {
        private MVRSystemDBContext _context;

        public PassportContext(MVRSystemDBContext context)
        {
            _context = context;
        }

        public void Create(Passport item)
        {
            try
            {
                _context.Passports.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Passport passportFromDB = Read(key);
                _context.Remove(passportFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Passport Read(int key)
        {
            try
            {
                return _context.Passports.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Passport> ReadAll()
        {
            try
            {
                return _context.Passports.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Passport item)
        {
            try
            {
                Passport passportFromDB = Read(item.Id);

                _context.Entry(passportFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
