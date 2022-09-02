using UnityEngine;

public class VolumeControls : MonoBehaviour
{
    [Min(0)]
    public float Volume;

    private void Update()
    {
        AudioListener.volume = Volume;
    }
}
