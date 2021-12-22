namespace FacebookApp.GameOfLifeFiles.IBuilder
{
    internal interface IGameBuilder : IGameCreator
    {
        GameBoard BuildBoard(); //this should get a photo
        GameEngine BuildEngine(GameBoard i_Board);
        GameOfLifeForm BuildForm(GameEngine i_Engine);
        GameOfLifeForm BuildComplexObject();
    }
}
