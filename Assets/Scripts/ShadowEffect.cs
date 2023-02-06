using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ShadowEffect : MonoBehaviour
{
    public Vector3 Offset = new Vector3(-0.1f, -0.1f);
    public Material material;
    GameObject _shadow;

    private void Start()
    {
        _shadow = new GameObject("Shadow");
        _shadow.transform.parent = transform;

        _shadow.transform.localPosition = Offset;
        _shadow.transform.localRotation = Quaternion.identity;

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        SpriteRenderer spriteRenderer = _shadow.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = renderer.sprite;
        spriteRenderer.material = material;

        spriteRenderer.sortingLayerName = renderer.sortingLayerName;
        spriteRenderer.sortingOrder = renderer.sortingOrder - 1;
    }

    private void LateUpdate()
    {
        _shadow.transform.localPosition = Offset;
    }
}
