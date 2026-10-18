using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource background;
    [SerializeField] private AudioClip bulletClip;
    [SerializeField] private AudioClip[] explosionClips;
    [SerializeField] private AudioClip damageClip;
    [SerializeField] private AudioClip gameOverClip;
    [SerializeField] private AudioClip backgroundMusicClip;
    void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void ReproduceBulletSound()
    {
        audioSource.PlayOneShot(bulletClip);
    }
    public void ReproduceExplosionSound()
    {
        int index = Random.Range(0, explosionClips.Length);

        audioSource.PlayOneShot(explosionClips[index]);
    }
    public void ReproduceGameOverSound()
    {
        audioSource.PlayOneShot(gameOverClip);
    }
    public void ReproduceDamageSound()
    {

        audioSource.PlayOneShot(damageClip);
    }
    public void ReproduceBackgroundMusic()
    {
        background.PlayOneShot(backgroundMusicClip);
    }
    public void StopMusic()
    {
        audioSource.Stop();
        background.Stop();
    }
}
