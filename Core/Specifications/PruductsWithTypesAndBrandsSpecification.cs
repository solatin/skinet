using System;
using System.Linq.Expressions;
using Core.Entities;
using Core.Specification;

namespace Core.Specifications
{
    public class PruductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public PruductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public PruductsWithTypesAndBrandsSpecification(int id) 
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}