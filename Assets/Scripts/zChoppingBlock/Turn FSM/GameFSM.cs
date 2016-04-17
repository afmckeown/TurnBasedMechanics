//using UnityEngine;

//public class GameFSM : MonoBehaviour
//{
//    public static PlayerBattleState PlayerBattle { get; private set; }
//    public static EnemyBattleState EnemyBattle { get; private set; }

//    public static BattleState Battle { get; set; }


//    private void InitStates()
//    {
//        PlayerBattle = gameObject.GetComponentInChildren<PlayerBattleState>();
//        EnemyBattle = gameObject.GetComponentInChildren<EnemyBattleState>();


//        if (PlayerBattle == null)
//        {
//            Debug.LogWarning(
//                "GameFSM Missing PlayerBattle child. Temp adding as a component.");
//            PlayerBattle = gameObject.AddComponent<PlayerBattleState>();
//                //new PlayerBattleState();
//        }
//        if (EnemyBattle == null)
//        {
//            Debug.LogWarning(
//                "GameFSM Missing EnemyBattle child. Temp adding as a component.");
//            EnemyBattle = gameObject.AddComponent<EnemyBattleState>();
//        }
//    }

//    private void InitStart()
//    {
//        //BattleState.Battle = Battle;
//        //EnemyBattle.Battle = Battle;

//        Battle = PlayerBattle;
//        Battle.Enter();
//    }

//    // Use this for initialization
//    private void Awake()
//    {
//        InitStates();
//    }


//    private void Start()
//    {
//        InitStart();
//    }

//    // Update is called once per frame
//    private void Update()
//    {
//        Battle.HandleInput();
//    }
//}