using UnityEngine;
using Utilities.Constants;
using GameFeatures;
using System.Collections;

namespace Ghosts.GhostMood
{
    public class GhostAnger : MonoBehaviour
    {
        [SerializeField]
        private GhostInfo _ghostInfo;
        [SerializeField]
        private GhostMood _ghostMood;

        [SerializeField]
        private RoomIdentifire _playerCurrentRoom;
        [SerializeField]
        private LevelRooms.LevelRoomsEnum _ghostRoom;

        private GhostDataSO _ghostData;
        private float _ghostAnger = 0f;
        private float _ghostAngerToAdd = 0f;

        private float _ghostAngerWithTime = 0f;
        private float _ghostAngerInGhostRoomWithTime = 0f;

        private WaitForSeconds WaitOneSecond = new WaitForSeconds(1f);

        private void Start()
        {
            _ghostData = _ghostInfo.GhostData;
            _ghostAnger = _ghostInfo.GhostData.StartGhostAnger;
            _ghostMood.SetGhostAnger(_ghostAnger);

            _ghostRoom = _ghostInfo.GhostRoom;

            if (_ghostRoom == LevelRooms.LevelRoomsEnum.NoRoom) _ghostInfo.GhostSetedUp += SetUp;
        }

        public void AddGhostAngerWithCalc(float ghostAngerToAdd)
        {
            _ghostAngerToAdd = ghostAngerToAdd;
            if (_ghostAnger > _ghostData.StartLateGhostAnger)
            {
                _ghostAngerToAdd *= ((_ghostData.MaxGhostAnger - _ghostData.StartLateGhostAnger) - (_ghostAnger - _ghostData.StartLateGhostAnger)) / (_ghostData.MaxGhostAnger - _ghostData.StartLateGhostAnger);
            }
            _ghostAnger += _ghostAngerToAdd;
            _ghostMood.SetGhostAnger(_ghostAnger);
        }

        private IEnumerator IncreaseAngerWithTime()
        {
            while (true)
            {
                CalculateGhostAnger();
                yield return WaitOneSecond;
            }
        }

        private void CalculateGhostAnger()
        {
            if (_playerCurrentRoom.CurrRoom == LevelRooms.LevelRoomsEnum.NoRoom) return;
            else if (_playerCurrentRoom.CurrRoom == _ghostRoom) AddGhostAngerWithCalc(_ghostAngerInGhostRoomWithTime);
            else AddGhostAngerWithCalc(_ghostAngerWithTime);
        }

        private void SetUp()
        {
            _ghostRoom = _ghostInfo.GhostRoom;
            _ghostAngerWithTime = _ghostData.GhostAngerPlusPerSec;
        }
    }
}