namespace OpenClosedPrincipleRefactor {

    class CAlimentInventory : CBaseInventory
    {
        public CAlimentInventory(CProduct product) : base(product){
        }

        public override double GetPrice(){
            product.Price *= 1.2;
            return product.Price;
        }
    }
}
