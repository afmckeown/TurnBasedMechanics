//using UnityEngine;

//public class EnemyBattleState : BattleState
//{
//    public override void EndTurn()
//    {
//        Exit();
//        GameFSM.Battle = GameFSM.PlayerBattle;
//        GameFSM.Battle.Enter();
//    }

//    public override void HandleInput()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            Debug.Log("EnemyBattleState && MouseDown");
//            EndTurn();
//        }
//    }

//    public override void Enter()
//    {
//        Debug.Log("Game State: Enemy Battle.");
//    }

//    public override void Exit()
//    {
//        Debug.Log("Exiting Enemy Battle");
//    }

//    private void Update()
//    {
//        //HandleInput();
//    }
//}