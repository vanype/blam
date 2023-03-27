using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : Player
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rb;

    private Vector2 _moveVector;
    private float _vectorX;
    private float _vectorY;

    private bool _isMove = true;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _vectorX = Input.GetAxis("Horizontal");
        _vectorY = Input.GetAxis("Vertical");

        if (_isMove)
        {
            if (_vectorX != 0 || _vectorY != 0)
            {
                Move();
            }
        }
        
    }

    private void Move()
    {
        _moveVector = new Vector2(_vectorX, _vectorY);
        _rb.velocity = _moveVector * _speed;
    }

    private void StopMovement()
    {
        _isMove = false;
    }

    private void RestoreMovement()
    {
        _isMove = true;
    }
}
