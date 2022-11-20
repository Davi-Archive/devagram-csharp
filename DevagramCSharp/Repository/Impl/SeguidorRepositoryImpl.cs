using DevagramCSharp.Models;

namespace DevagramCSharp.Repository.Impl
{
    public class SeguidorRepositoryImpl : ISeguidorRepository
    {

        private readonly DevagramContext _context;

        public SeguidorRepositoryImpl(DevagramContext context)
        {
            _context = context;
        }
        public bool Seguir(Seguidor seguidor)
        {
            try
            {
                _context.Add(seguidor);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Desseguir(Seguidor seguidor)
        {
            try
            {
                _context.Remove(seguidor);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
