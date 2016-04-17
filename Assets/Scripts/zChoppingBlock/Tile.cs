//using System;
//using System.Collections;
//using UnityEngine;

//[Serializable]
//public class Tile
//{
//    private Vector2 _center;

//    [SerializeField]
//    private Point _point;

//    public bool IsWalkable { get; set; }

//    public Actor Actor { get; set; }
    
//    public Point Point
//    {
//        get { return _point; }
//        set { _point = value; }
//    }

//    public Vector2 Center
//    {
//        get { return _center; }
//        set { _center = value; }
//    }

//    public float X
//    {
//        get { return _center.x; }
//        private set { _center.x = value; }
//    }

//    public float Y
//    {
//        get { return _center.y; }
//        private set { _center.y = value; }
//    }

    


//    public Tile(Point point, float x, float y, bool isWalkable = true)
//    {
//        Point = point;
//        Center = new Vector2(x, y);
//        IsWalkable = isWalkable;
//    }

//}
