using UnityEngine;

public class IcePlatform : MonoBehaviour
{
    [Header("Multiplicateurs (1 = sol normal, plus petit = plus glissant)")]
    [Range(0.01f, 1f)] public float accelerationMultiplier = 0.15f; // Démarre doucement
    [Range(0.01f, 1f)] public float decelerationMultiplier = 0.04f; // Glisse longtemps
    [Range(0.01f, 1f)] public float turnMultiplier = 0.2f;          // Demi-tour lent
}