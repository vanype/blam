using UnityEngine;

public class CameraPursuit : MonoBehaviour
{
    [SerializeField] private float _pursuitSpeed;

    private Transform _player;

    void Start()
    {
        _player = FindObjectOfType<Player>().transform;
    }

    private void FixedUpdate()
    {
        Vector3 transformPlayer = new Vector3(0, 0, -10) + _player.position;
        transform.position = Vector3.Lerp(transform.position, transformPlayer, _pursuitSpeed * Time.deltaTime);
    }
}
