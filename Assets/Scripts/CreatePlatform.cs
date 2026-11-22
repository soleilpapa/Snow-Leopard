using UnityEngine;

public class PlatformOnClick : MonoBehaviour
{
    public GameObject platformPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector2 spawnPosition = new Vector2(
                transform.position.x,
                transform.position.y - 1f
            );

            GameObject platform = Instantiate( //créer la copie.
                platformPrefab,
                spawnPosition, //position
                Quaternion.identity // rotation de objet dans l'espace.
            );

            Destroy(platform, 5f);
        }
    }
}