//using UnityEngine;

//public class MouseInputData : MonoBehaviour
//{
//    //enum SelectionType
//    //{
//    //    Friendly,
//    //    Enemy,
//    //    Neutral,
//    //    None
//    //}
//    public Point MouseoverPoint { get; private set; }

//    public bool IsMouseOverPoint { get; private set; }
//    public bool IsSelectionPressed { get; private set; }
//    public bool IsActionPressed { get; private set; }

//    private void Update()
//    {
//        Board grid = GameManager.Instance.PointExtensions;

//        Reset();

//        Vector3 mousePositionWorldPoint =
//            Camera.main.ScreenToWorldPoint(Input.mousePosition);

//        MouseoverPoint = grid.WorldPointToPoint(mousePositionWorldPoint);

//        if (Input.GetMouseButtonUp(0))
//        {
//            IsSelectionPressed = true;
//        }

//        if (Input.GetMouseButtonUp(1))
//        {
//            IsActionPressed = true;
//        }
//    }

//    private void Reset()
//    {
//        IsMouseOverPoint = false;
//        IsSelectionPressed = false;
//        IsActionPressed = false;
//    }
//}