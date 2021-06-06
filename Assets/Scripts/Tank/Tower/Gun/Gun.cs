using System.Collections;
using UnityEngine;

public class Gun: MonoBehaviour
{
    public int damage;
    public uint radius;

    public float startTimeBetweenShots;
    private float timeBetweenShots = 0;

    public LineRenderer lineRenderer;
    public Transform shotPoint;

    public void Start()
    {
        lineRenderer.enabled = false;
    }

    public IEnumerator Shoot()
    {
        if (timeBetweenShots <= 0)
        {
            RaycastHit2D hit = Physics2D.Raycast(shotPoint.position, shotPoint.right);

            if (hit)
            {
                Tank tank = hit.transform.GetComponent<Tank>();
                if (tank != null)
                {
                    tank.TakeDamage(damage);
                }

                lineRenderer.SetPosition(0, shotPoint.position);
                lineRenderer.SetPosition(1, hit.point);
            }
            else
            {
                lineRenderer.SetPosition(0, shotPoint.position);
                lineRenderer.SetPosition(1, shotPoint.position + shotPoint.right * radius);
            }
            timeBetweenShots = startTimeBetweenShots;

            lineRenderer.enabled = true;

            yield return new WaitForSeconds(0.02f);

            lineRenderer.enabled = false;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }
}

