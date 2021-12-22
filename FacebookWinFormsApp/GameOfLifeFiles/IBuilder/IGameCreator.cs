namespace FacebookApp.GameOfLifeFiles.IBuilder
{
    internal interface IGameCreator : IPrivateCtor
    {
        int Rows { get; set; }
        int Columns { get; set; }
        System.Drawing.Image BackGroundImage { get; set; }
        bool InformMissing();


    }
    public enum InformationMissing { eMissingRows, eMissingCols, eMissingDrawing}
}
