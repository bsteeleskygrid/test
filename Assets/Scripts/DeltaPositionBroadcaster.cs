using UnityEngine;

public class DeltaPositionBroadcaster : MonoBehaviour
{
    Vector3 _currentPosition;
    private Vector3 currentPosition
    {
        set
        {
            if(_currentPosition != value)
            {
                Vector3 delta = value - _currentPosition;
                _currentPosition = value;
                OnPositionChanged?.Invoke(value);
            }
        }
    }

    public delegate void OnPositionChangedDelegate(Vector3 deltaPosition);
    public event OnPositionChangedDelegate OnPositionChanged;

    public void Update()
    {
        currentPosition = transform.position;
    }

    public void UpdateCurrentPositionSansEvent()
    {
        _currentPosition = transform.position;
    }
}