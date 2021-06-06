using UnityEngine;

public class Enemy :Tank
{
    private Player player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public new void Update()
    {
        //body.Move(player.transform.position.x, player.transform.position.y);
        StartCoroutine(gun.Shoot());
        base.Update();        
    }
}
