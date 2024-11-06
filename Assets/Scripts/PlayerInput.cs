using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _playerYPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount <= 0) return;
        var mousePosition = Input.mousePosition;

        var bottomLeftBoundary = Camera.main.ViewportToWorldPoint(Vector3.zero);
        var topRightBoundary = Camera.main.ViewportToWorldPoint(Vector3.one);

        var mousePositionInWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePositionInWorldSpace.z = 0;
        mousePositionInWorldSpace.y = _playerYPosition;
        mousePositionInWorldSpace.x = Mathf.Clamp(mousePositionInWorldSpace.x, bottomLeftBoundary.x+.5f, topRightBoundary.x-.5f);
        transform.position = mousePositionInWorldSpace;

    }
}
