using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    [Header("Collision")]
    [SerializeField] private LayerMask wallLayer;

    private ParticleEffectController particleEffectController;

    private void Awake()
    {
        particleEffectController = GetComponent<ParticleEffectController>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((wallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            PlayAudioClip();
            PlayParticleEffect();
        }
    }

    private void PlayAudioClip()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void PlayParticleEffect()
    {
        if (particleEffectController != null)
        {
            particleEffectController.PlayEffect();
        }
    }
}
