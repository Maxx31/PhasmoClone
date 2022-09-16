using UnityEngine;
using Cinemachine;
using Infrastructure;
using Utilities.Constants;
using Items.Logic;
using Infrastructure.Services;

namespace Environment
{
    public class BoardClickable : MonoBehaviour, IClickable
    {
        [SerializeField] private CinemachineVirtualCamera _boardCamera;

        private InputSystem _inputSystem;

        private void Start()
        {
            _inputSystem = AllServices.Container.Single<InputSystem>();
        }
        public void OnClick()
        {
            _boardCamera.Priority = CameraPriorities.ActiveState;
            _inputSystem.LockControl();
            Cursor.lockState = CursorLockMode.Confined;
        }

        public void DecreasePriority()
        {
            _boardCamera.Priority = CameraPriorities.DisabledState;
            UnlockInputControl();
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void UnlockInputControl()
        {
            _inputSystem.UnLockControl();
        }
    }
}