namespace FacebookApp.GameOfLifeFiles.IBuilder
{
    interface IGameComposer : IGameCreator
    {
        IGameBuilder Builder { get; set; }
        GameOfLifeForm Compose();
    }
}
