using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float attackCooldown;
    [SerializeField] private float damage;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer += Time.deltaTime;

        if(PlayerInSight())
        {
            if(cooldownTimer >= attackCooldown)
            {
                //ADD ATTACK FUNCTION HERE
            }
        }
    }
    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounce.center, boxCollider.bounce.size, 0, vector2.left, 0, playerLayer);
        return hit.collider != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        OnDrawGizmos.DrawWireCube(boxCollider.bounds.center, boxCollider.bounds.size);
    }
}
