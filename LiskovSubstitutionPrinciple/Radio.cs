namespace LiskovSubstitutionPrinciple {

    class Radio : News
    {
        public Radio(string name) : base(name){
        }
        public override void Show(){
            Console.WriteLine($"Radio: {name}");
        }
    }
}