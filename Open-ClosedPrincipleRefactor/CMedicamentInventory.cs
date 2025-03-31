namespace OpenClosedPrincipleRefactor {
    class CMedicamentInventory : CBaseInventory
    {
        public CMedicamentInventory(CProduct product) : base(product)
        {
        }

        public override double GetPrice()
        {          
            product.Price *= 0.8;
            return product.Price;
        }
    }
}