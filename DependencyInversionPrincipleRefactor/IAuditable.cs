namespace DependencyInversionPrincipleRefactor {   
    interface IAuditable{
        IEnumerable<Product> GetProducts(int pTipo);
    }
}
