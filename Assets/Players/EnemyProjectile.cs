using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NETWORK_ENGINE;
public class EnemyProjectile : Projectile
{
    public override void HandleMessage(string flag, string value)
    {

    }

    public override void NetworkedStart()
    {

    }

    public override IEnumerator SlowUpdate()
    {
        yield return new WaitForSeconds(.1f);
    }

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if(IsServer)
        {
            if (collision.gameObject.tag == "Rogue" || collision.gameObject.tag == "Knight" || collision.gameObject.tag == "Ranger" || collision.gameObject.tag == "Wizard")
            {
                MyCore.NetDestroyObject(NetId);
            }
        }

    }
}
