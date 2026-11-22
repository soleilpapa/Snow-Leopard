using UnityEngine;

public class CharacterGround : MonoBehaviour
{
    #region Public


    [Header( "Collider Settings" )]
    [SerializeField] [Tooltip( "Length of the ground-checking collider" )] private float groundLength = 0.95f;
    [SerializeField] [Tooltip( "Distance between the ground-checking colliders" )] private Vector3 colliderOffset;

    [Header( "Layer Masks" )]
    [SerializeField] [Tooltip( "Which layers are read as the ground" )] private LayerMask groundLayer;

    public bool GetOnGround() { return onGround; }

    #endregion

    #region Unity Lifecycle

    private void Update()
    {
        //raycasts pour savoir si le gars et sur le sol #fun
        onGround = Physics2D.Raycast( transform.position + colliderOffset, Vector2.down, groundLength, groundLayer ) || Physics2D.Raycast( transform.position - colliderOffset, Vector2.down, groundLength, groundLayer );
    }

    private void OnDrawGizmos()
    {
        //Ground colliders en vert
        if ( onGround ) { Gizmos.color = Color.green; } else { Gizmos.color = Color.red; }
        Gizmos.DrawLine( transform.position + colliderOffset, transform.position + colliderOffset + Vector3.down * groundLength );
        Gizmos.DrawLine( transform.position - colliderOffset, transform.position - colliderOffset + Vector3.down * groundLength );
    }

    #endregion

    #region Main Methods

    #endregion

    #region Private & Protected

    private bool onGround;

    #endregion
}