using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopAspNetCore.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if(_pies == null)
            {
                InitialisePies();
            }
        }
        private void InitialisePies()
        {
            _pies = new List<Pie>
            {
                new Pie { Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous pies!", LongDescription = "Icing carrot cake jelly-o"},
                new Pie { Id = 2, Name = "Blueberry Cheese Cake", Price = 16.95M, ShortDescription = "You'll love it", LongDescription = "Icing carrot cake jelly-o" },
                new Pie { Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain ppleasure ", LongDescription = "Icing carrot cake jelly-o"},
                new Pie { Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot cake jelly-o"}
            };
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }
        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault( p => p.Id == pieId);
        }
    }
}
