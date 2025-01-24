using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    [Header("Effects")]
    [SerializeField] private ParticleSystem particleSystem;

    public void PlayEffect()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}
