
namespace FactoryMethod.Pattern
{
    class PngApplication : Application
    {
        MainForm baseForm;
        int counter;
        Action action;

        public PngApplication(MainForm baseForm, int counter, Action action)
        {
            this.baseForm = baseForm;
            this.counter = counter;
            this.action = action;
        }

        public override Document CreateDocument()
        {
            return new PngDocument(baseForm, counter, action);
        }

        public override void OpenDocument()
        {
            CreateDocument().Open();
        }
    }
}
