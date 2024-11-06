using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootSystem : MonoBehaviour
{
    [SerializeField] private ProjectilePoolSystem _projectilePoolSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
        
            var projectile = _projectilePoolSystem.GetFirstProjectileAvailable();
            projectile.transform.position = transform.position;
        }
    }
}
