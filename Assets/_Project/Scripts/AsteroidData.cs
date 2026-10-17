using UnityEngine;
// TODO: crea el ScriptableObject [CreateAssetsMenu...] recorda que no ha d'heretar de MonoBehaviour
[CreateAssetMenu(fileName = "NewAsteroidData", menuName = "Asteroids/Asteroid Data")]
public class AsteroidData : ScriptableObject 
{
    //TODO: introdueix les dades necesaries
    public int maxHealth;
    public Color color;
    public float scale;
    public float minSpeed;
    public float maxSpeed;
    public int points;
    public int damage = 1;
}
