using UnityEngine;

public class Tank : MonoBehaviour
{
    public Body body;
    public Gun gun;
    public Turret turret;

    public void TakeDamage(int damage)
    {
        body.defense -= damage;
        Debug.Log("Body defense: " + body.defense.ToString());
    }

    public void Update()
    {
        if(body.defense <= 0)
        {
            Destroy(gameObject);
        }
    }
}