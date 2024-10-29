using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _desiredScale;
    [SerializeField] private float _duration;

    private int _repats = -1;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOScale(_desiredScale, _duration).SetLoops(_repats, _loopType);
    }
}
