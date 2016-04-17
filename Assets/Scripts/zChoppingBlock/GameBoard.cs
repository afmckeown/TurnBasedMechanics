//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//[ExecuteInEditMode]
//public class GameBoard : MonoBehaviour
//{
//    [SerializeField] private Board _grid;

//    // Sprite Representing Ground Tiles
//    [SerializeField] private List<Sprite> _tileSprite;

//    private List<Sprite> TileSprite
//    {
//        get { return _tileSprite; }
//        set { _tileSprite = value; }
//    }

//    public Board PointExtensions
//    {
//        get { return _grid; }
//        private set { _grid = value; }
//    }

//    public void DestroyChildren()
//    {
//        List<GameObject> children =
//            (from Transform child in transform select child.gameObject).ToList();
//        // Destroy if playing??
//        children.ForEach(DestroyImmediate);
//    }

//    private void ConstructBoard()
//    {
//        DestroyChildren();
//        // Align board with grid
//        transform.position = PointExtensions.Origin;

//        // Layout tiles on PointExtensions Points
//        foreach (PointPosition point in PointExtensions.Points)
//        {
//            // Create new GameObject
//            var tile = new GameObject
//            {
//                name = "Tile_" + point.X + "_" + point.Y
//            };

//            // PointPosition GameObject at PointPosition Location
//            tile.transform.position = PointExtensions.PointToWorldPoint(point);

//            // Make GameObject a child of this scripts GameObject
//            tile.transform.SetParent(transform, true);

//            // Add a sprite renderer, with a sprite set in the inspector
//            var spriteRenderer = tile.AddComponent<SpriteRenderer>();
//            spriteRenderer.sprite = TileSprite[Random.Range(0, TileSprite.Count)];
//            spriteRenderer.sortingLayerName = GameManager.GroundLayer;
//        }
//    }

//    private void InitStart()
//    {
//        ConstructBoard();
//    }

//    public void Start()
//    {
//        InitStart();
//    }
//}