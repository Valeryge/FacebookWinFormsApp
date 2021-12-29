namespace FacebookApp.GameOfLifeFiles.IBuilder
{
    internal interface IGameBuilder : IGameCreator
    {
      
        void BuildBoard(); //this should get a photo
        void BuildEngine();
        void BuildForm();
        GameOfLifeForm GetComplexObject();
    }
}
