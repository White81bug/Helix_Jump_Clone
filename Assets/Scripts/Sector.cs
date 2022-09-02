using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool IsGood = true;
    public bool Breakable = false;
    public Material GoodMatetial;
    public Material BadMaterial;
    public Material BreakableMaterial;

    private void Awake()
    {
      
        UpdateMaterial();
    }

    private void UpdateMaterial()
    {
        Renderer sectorRenderer = GetComponent<Renderer>();
        sectorRenderer.sharedMaterial = IsGood ? GoodMatetial : BadMaterial;
        if(Breakable)
        {
            sectorRenderer.sharedMaterial = BreakableMaterial;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player))return;
        Vector3 normal = -collision.contacts[0].normal.normalized;
        float dot = Vector3.Dot(normal, Vector3.up);
        if (dot < 0.5) return;

        if (!Breakable)
        {
        }
        else
        {
           
            
            gameObject.SetActive(false);
            player.GetPoint();
            player.BreakSound.Play();

        }
        if (IsGood)
            player.Bounce();
        else
            player.Die();
    }
    private void OnValidate()
    {
        UpdateMaterial();
    }


}