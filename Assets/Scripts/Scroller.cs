using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 1.0f;
    private RawImage _img;
    void Start()
    {
        _img = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(0, speed) * Time.deltaTime, _img.uvRect.size);
    }
}
