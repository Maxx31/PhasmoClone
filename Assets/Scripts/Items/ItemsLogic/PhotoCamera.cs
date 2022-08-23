using Items.Logic;
using UnityEngine;
using System.Collections;
using TMPro;

namespace Items.ItemsLogic
{
    public class PhotoCamera : MonoBehaviour, IMainUsable
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private TextMeshProUGUI _shotsLeftText;

        [SerializeField] private Light _flash;
        [SerializeField] private float _flashTime;

        [SerializeField] private int _shotsLeft;
        [SerializeField] private float _cooldown;

        [SerializeField] private float _rayCastGirth = 0.5f;
        [SerializeField] private float _rayCastWidth = 5f;
        [SerializeField] private LayerMask _rewardLayer;

        private bool _isReady = true;

        private void Start()
        {
            _shotsLeftText.text = _shotsLeft.ToString();
        }

        public void OnMainUse()
        {
            if (CheckIfReady())
            {                
                MakePhoto();
                CheckTargets();
            }
        }
        private bool CheckIfReady()
        {
            if (_shotsLeft > 0 && _isReady) return true;
            else return false;
        }
        private void MakePhoto()
        {   
            _flash.enabled = true;
            _shotsLeft -= 1;
            _shotsLeftText.text = _shotsLeft.ToString();
            _isReady = false;

            StartCoroutine(nameof(Cooldown));

            //Debug.Log("Photo");
        }

        private void CheckTargets()
        {
            var ray = _camera.ViewportPointToRay(Vector3.one * _rayCastGirth);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, _rayCastWidth, _rewardLayer))
            {
                
                //Debug.Log(hit.transform.name + " hitted");
            }
        }

        IEnumerator Cooldown()
        {
            yield return new WaitForSeconds(_flashTime);
            _flash.enabled = false;
            yield return new WaitForSeconds(_cooldown);
            _isReady = true;
        }
    }    
}
