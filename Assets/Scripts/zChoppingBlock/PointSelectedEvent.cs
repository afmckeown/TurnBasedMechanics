public class PointSelectedEvent
{
    public delegate void BoardChangedHandler();

    public delegate void PointSelectedHandler(Point point);

    public static event PointSelectedHandler PointInspected;
    public static event PointSelectedHandler PointSelected;

    public delegate void PawnSelectedHandler(Pawn pawn);

    public static event PawnSelectedHandler PawnSelected;
    public static event PawnSelectedHandler SelectedPawnMoved;
    public static event PawnSelectedHandler PawnDeselected;

    public static event BoardChangedHandler BoardChanged;


    public static void OnPointSelected(Point point)
    {
        if (PointSelected != null)
            PointSelected(point);
    }

    public static void OnPointInspected(Point point)
    {
        if (PointInspected != null)
            PointInspected(point);
    }

    public static void OnBoardChanged()
    {
        BoardChangedHandler handler = BoardChanged;
        if (handler != null) handler();
    }

    public static void OnPawnSelected(Pawn pawn)
    {
        PawnSelectedHandler handler = PawnSelected;
        if (handler != null) handler(pawn);
    }

    public static void OnSelectedPawnMoved(Pawn pawn)
    {
        PawnSelectedHandler handler = SelectedPawnMoved;
        if (handler != null) handler(pawn);
    }

    public static void OnPawnDeselected(Pawn pawn)
    {
        PawnSelectedHandler handler = PawnDeselected;
        if (handler != null) handler(pawn);
    }
}