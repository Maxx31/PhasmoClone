using Managers.Services;
using UnityEngine;

namespace Infrastructure.States
{
    public class BootState : IState
    {

        private readonly AllServices _services;
        private readonly InputSystem _inputSystem;
        public BootState(AllServices services, InputSystem inputSystem)
        {
            _services = services;
            _inputSystem = inputSystem;

            RegisterServices();
        }


        public void Enter()
        {
        }

        public void Exit()
        {
        }

        private void RegisterServices()
        {
            _services.RegisterSingle(_inputSystem);
        }
    }
}