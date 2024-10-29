using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _endAngel;
    [SerializeField] private float _duration;

    private int _repeats = -1;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DORotate(_endAngel, _duration, RotateMode.Fast).SetLoops(_repeats, _loopType);
    }
}
