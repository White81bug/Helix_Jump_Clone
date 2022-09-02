using UnityEngine;
using UnityEngine.UI;

public class ProgreesBar : MonoBehaviour
{
    public Player Player;
    public Transform FinishPlatform;
    public Slider Slider;
    public float FinishOffset = 1f;

    private float startY;
    private float minY;

    private void Start()
    {
        startY = Player.transform.position.y;

    }

    private void Update()
    {
        minY = Mathf.Min(minY,Player.transform.position.y);
      
        float finishY = FinishPlatform.transform.position.y;
        float t = Mathf.InverseLerp(startY, finishY + FinishOffset, minY);
        Slider.value = t;
    }

}
