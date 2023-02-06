using UnityEngine;
using UnityEngine.Tilemaps;
using DG.Tweening;

public class GrassFill : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private Tile _newTile;

    public Vector3Int[] position = new Vector3Int[2] { new Vector3Int(7, 10, 0), new Vector3Int(-7, -10, 0) };

    private void Update()
    {
        if (_tilemap.gameObject.GetComponent<GrassFill>())
        {
            var ballPos = _ball.transform.position;
            var cellPos = _tilemap.WorldToCell(ballPos);
            _tilemap.SetTile(cellPos, _newTile);      
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            LevelGoalText.Grass += 1;
        }

    }
}
