using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _positionZ;
    [SerializeField] private float _duration;

    private int _repats = -1;
    private LoopType _loopType = LoopType.Yoyo;
    private Ease _ease = Ease.Linear;

    private void Start()
    {
        Vector3 desiredPosition = new Vector3(transform.position.x, transform.position.y, _positionZ);
        transform.DOMove(desiredPosition, _duration).SetEase(_ease).SetLoops(_repats, _loopType);
    }
}
