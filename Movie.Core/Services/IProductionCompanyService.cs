using System.Collections.Generic;

namespace Movie.Core.Services
{
    public interface IProductionCompanyService
    {
        ProductionCompany Add(ProductionCompany productionCompany);
        void Remove(ProductionCompany productionCompany);
        ProductionCompany GetById(int id);
        IList<ProductionCompany> GetList();
    }
}
