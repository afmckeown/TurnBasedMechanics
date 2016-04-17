//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//public class GameManager : ScriptableObject
//{
//    public const string GroundLayer = "Ground";
//    public const string GameBoardUILayer = "GameBoardUI";

//    [SerializeField] private Player _enemy;
//    [SerializeField] private Player _neutral;
//    [SerializeField] private Player _player;

//    [SerializeField] private Board _grid;

//    [SerializeField] private MouseInputData _mouseInputData;
    
//    // Singleton Pattern
//    // Holds only allowed instance of this class type
//    public static GameManager Instance { get; private set; }


//    public Player Player
//    {
//        get { return _player; }
//    }

//    public Player Enemy
//    {
//        get { return _enemy; }
//    }

//    public Player Neutral
//    {
//        get { return _neutral; }
//    }

//    public Board PointExtensions
//    {
//        get { return _grid; }
//    }

//    public MouseInputData MouseInputData
//    {
//        get { return _mouseInputData; }
//    }

//    public HashSet<PointPosition> NonPathablePoints { get; private set; }

//    private void InitAwake()
//    {
//        if (Instance != null)
//        {
//            Debug.LogError("There should only be one GameManager.");
//        }

//        Instance = this;
//        NonPathablePoints = new HashSet<PointPosition>();
//        //Player = new Player();
//    }

//    private void OnBoardChanged()
//    {
//        UpdateNonPathablePoints();
//    }

//    private void UpdateNonPathablePoints()
//    {
//        NonPathablePoints.Clear();

//        foreach(PointPosition point in Player.GetOccupiedPoints())
//            NonPathablePoints.Add(point);
//        foreach (PointPosition point in Enemy.GetOccupiedPoints())
//            NonPathablePoints.Add(point);
//        foreach (PointPosition point in Neutral.GetOccupiedPoints())
//            NonPathablePoints.Add(point);
//    }

//    private void InitStart()
//    {
//        PointSelectedEvent.BoardChanged += OnBoardChanged;

//        UpdateNonPathablePoints();
//    }

//    // Use this for initialization
//    private void Awake()
//    {
//        InitAwake();
//    }

//    private void Start()
//    {
//        InitStart();
//    }

//    private void Update() {}
//}