//using UnityEngine;

//public class BoardPosition : MonoBehaviour
//{
//    private Point _position;

//    [SerializeField] private int _x;

//    [SerializeField] private int _y;

//    [SerializeField] private Tile _tile;

//    private Transform Transform { get; set; }

//    public Point PointPosition
//    {
//        get { return _position; }
//        set
//        {
//            _x = value.X;
//            _y = value.Y;
//            _position = value;
//        }
//    }

//    private void Start()
//    {
//        Transform = GetComponent<Transform>();
//        _position = new Point(_x, _y);
//        Transform.position =
//            GameManager.Instance.PointExtensions.PointToWorldPoint(_position);
//    }

//    //private void OnValidate()
//    //{
//    //    PointPosition tempPoint = _position;
//    //    if (GameManager.Instance != null)
//    //    {
//    //        _position = new PointPosition(_x, _y);

//    //        bool isInBounds = GameManager.Instance.PointExtensions.IsInBounds(_position);

//    //        if (!isInBounds)
//    //        {
//    //            Debug.LogWarning("Objects BoardPosition is not on the PointExtensions.");
//    //            _position = tempPoint;
//    //        }
//    //        else
//    //        {
//    //            Transform.position =
//    //                GameManager.Instance.PointExtensions.PointToWorldPoint(_position);
//    //        }
//    //    }
//    //    else
//    //    {
//    //        PointPosition = new PointPosition(_x, _y);
//    //    }
//    //}

//    private void Update() {}

//    //void OnValidate()
//    //{
//    //    if (Application.isEditor && !Application.isPlaying)
//    //    {
//    //        transform.position = GameManager.Instance.PointExtensions.PointToWorldPoint(PointPosition);

//    //    }

//    //}
//}