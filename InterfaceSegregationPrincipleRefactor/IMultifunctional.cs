namespace InterfaceSegregationPrincipleRefactor {
    interface IMultifunctional: IFax, IMultifunctionalBasic {

    }   
    interface IFax {
        void Telephone();
        void Fax();
    }  

}