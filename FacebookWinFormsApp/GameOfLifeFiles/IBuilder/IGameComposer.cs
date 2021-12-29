namespace FacebookApp.GameOfLifeFiles.IBuilder
{
    interface IGameComposer : IGameCreator
    {
        GameOfLifeForm Compose();
    }
}
