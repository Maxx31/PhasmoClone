using GameFeatures;
using Infrastructure;
using Infrastructure.Services;
using System.Collections;
using UnityEngine;
using Utilities.Constants;

public class SanityHandler : MonoBehaviour
{
    [SerializeField]
    private RoomIdentifire _currPlayerRoom;
    [SerializeField]
    private float _maxSanityValue;
    [SerializeField,Tooltip("How much sanity is taken from the player when he is in the house")]
    private float _houseSecondSanityMinus;  
    [SerializeField,Tooltip("How much sanity is taken from the player when he is in the ghost room")]
    private float _ghostRoomSecondSanityMinus;

    private WaitForSeconds WaitOneSecond = new WaitForSeconds(1f);
    private GhostInfo _ghostInfo;
    private LevelSetUp _levelSetUp;

    private LevelRooms.LevelRoomsEnum _currGhostRoom = LevelRooms.LevelRoomsEnum.NoRoom;

    // public float Sanity { get; private set; }
    public float Sanity;


    private void Start()
    {
        _levelSetUp = AllServices.Container.Single<LevelSetUp>();
        Sanity = _maxSanityValue;
        if (_levelSetUp.CurrGhostRoom == LevelRooms.LevelRoomsEnum.NoRoom) _levelSetUp.OnLevelSetedUp += SetUp;
        else SetUp();

    }

    private void OnDestroy()
    {
        _levelSetUp.OnLevelSetedUp -= SetUp;
    }

    public void ChangeSanity(float ammountToAdd)
    {
        Sanity += ammountToAdd;
    }

    private IEnumerator DropSanityWithTime()
    {
        while (true)
        {
            DropPlayerSanity();
            yield return WaitOneSecond;
        }
    }

    private void DropPlayerSanity()
    {
        if (_currPlayerRoom.CurrRoom == LevelRooms.LevelRoomsEnum.NoRoom) return;
        else if (_currPlayerRoom.CurrRoom == _currGhostRoom) ChangeSanity(-_ghostRoomSecondSanityMinus);
        else ChangeSanity(-_houseSecondSanityMinus);
    }

    private void SetUp()
    {
        _currGhostRoom = _levelSetUp.CurrGhostRoom;
        _ghostInfo = _levelSetUp.GhostInfo;

        _houseSecondSanityMinus = _ghostInfo.GhostData.PlayerSanityMinusPerSecond;
        _ghostRoomSecondSanityMinus = _ghostInfo.GhostData.PlayerSanityMinusInGhostRoomPerSecond;
        StartCoroutine(DropSanityWithTime());
    }

}
