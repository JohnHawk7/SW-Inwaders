using UnityEngine;

public class Invader : MonoBehaviour
{
    public System.Action killed;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Laser")) 
        {
            killed.Invoke();
            gameObject.SetActive(false);
        }
    }
}
