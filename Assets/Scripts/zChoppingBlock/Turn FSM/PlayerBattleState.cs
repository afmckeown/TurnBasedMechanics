//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class PlayerBattleState : BattleState
//{
//    [SerializeField] private Button EndTurnButton;

//    private Player Player { get; set; }

//    public PointPosition SelectedPoint { get; private set; }
//    public PointPosition HighlightedPoint { get; private set; }

//    public Pawn FriendlySelected { get; private set; }
    
//    public void OnEndTurnButton()
//    {
//        EndTurn();
//    }

//    public override void EndTurn()
//    {
//        Exit();
//        GameFSM.Battle = GameFSM.EnemyBattle;
//        GameFSM.Battle.Enter();
//    }

//    public override void HandleInput()
//    {
//        HandleMouseInput();
//    }

//    private void HandleMouseInput()
//    {
//        MouseInputData mouseInputData = GameManager.Instance.MouseInputData;

//        if (mouseInputData.MouseoverPoint == null) return;

//        if (HighlightedPoint != mouseInputData.MouseoverPoint)
//        {
//            HighlightedPoint = mouseInputData.MouseoverPoint;
//            PointSelectedEvent.OnPointInspected(HighlightedPoint);
//        }

//        if (mouseInputData.IsSelectionPressed)
//        {
//            if (FriendlySelected != null)
//            {
//                if (GameManager.Instance.PointExtensions.IsNeighbor(SelectedPoint, HighlightedPoint))
//                {
//                    FriendlySelected.Facing =
//                        GameManager.Instance.PointExtensions.GetDirection(SelectedPoint, HighlightedPoint);
//                }
//                else
//                {
//                    PointSelectedEvent.OnPawnDeselected(FriendlySelected);
//                    FriendlySelected = null;
//                    return;
//                }
//            }
//            if (SelectedPoint != mouseInputData.MouseoverPoint)
//            {
//                SelectedPoint = mouseInputData.MouseoverPoint;
//                PointSelectedEvent.OnPointSelected(SelectedPoint);

//                if (GameManager.Instance.Player.IsPawnOnPoint(SelectedPoint))
//                {
//                    FriendlySelected =
//                        GameManager.Instance.Player.GetPawnOnPoint(SelectedPoint);

//                    PointSelectedEvent.OnPawnSelected(FriendlySelected);
//                }
//                else if (FriendlySelected != null)
//                {
//                    FriendlySelected = null;
//                }
//            }
//        }

//        if (mouseInputData.IsActionPressed && FriendlySelected != null)
//        {
//            bool isMoveSuccess =
//                FriendlySelected.Move(mouseInputData.MouseoverPoint);

//            if (isMoveSuccess)
//            {
//                PointSelectedEvent.OnSelectedPawnMoved(FriendlySelected);
//                if (FriendlySelected.ActionPoint.PointsRemaining == 0) 
//                {
//                    PointSelectedEvent.OnPawnDeselected(FriendlySelected);
//                    FriendlySelected = null;
//                }
//            }
//        }
//    }

//    public override void Enter()
//    {
//        Debug.Log("Game State: Player Battle.");


//        // Set action points of players units to max

//        List<Pawn> playerUnits = Player.Pawns;

//        foreach (Pawn Pawn in playerUnits)
//        {
//            Pawn.ActionPoint.Fill();
//        }

//        EndTurnButton.gameObject.SetActive(true);
//        EndTurnButton.interactable = true;
//    }

//    public override void Exit()
//    {
//        Debug.Log("Exiting Player Battle");
//        EndTurnButton.interactable = false;
//    }

//    protected override void AddListeners()
//    {
//        throw new System.NotImplementedException();
//    }

//    protected override void RemoveListeners()
//    {
//        throw new System.NotImplementedException();
//    }

//    private void Start()
//    {
//        Player = GameManager.Instance.Player;
//    }
//}