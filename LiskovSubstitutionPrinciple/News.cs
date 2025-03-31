namespace LiskovSubstitutionPrinciple {
    class News {
        protected string name;

        public News(string name) {
            this.name = name;
        }

        public virtual void Show() {
            //This method can be overridden in derived classes
            // to provide specific functionality.
            // For example, in the Radio class, we can override this method to show radio-specific information.
            // In this base class, we can just print the name of the news.
            Console.WriteLine($"News: {name}");
        }
    }
}