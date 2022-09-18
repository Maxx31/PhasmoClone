using GameFeatures;
using Infrastructure.Services;
using Player.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities.Constants;

namespace Infrastructure.States.GameStates
{
    public class LoadLevelState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly GameFactory _gameFactory;
        private readonly LevelSetUp _levelSetUp;
        private readonly SceneLoader _sceneLoader;
        private GameStateMachine gameStateMachine;

        public LoadLevelState(GameStateMachine stateMachine, GameFactory gameFactory, LevelSetUp levelSetUp, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _gameFactory = gameFactory;
            _levelSetUp = levelSetUp;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.Load(SceneNames.LevelNames.Turkwood.ToString(), InitGameWorld);
            //_sceneLoader.Load(SceneNames.LevelNames.Factory.ToString(), InitGameWorld);
        }

        public void Exit()
        {
        }


        private void InitGameWorld()
        {
            _levelSetUp.InitializeLevel();
            InstantiateAll();
            _levelSetUp.OnLevelSetedUp.Invoke();
            _stateMachine.Enter<GameFlowState>();
        }

        private void InstantiateAll()
        {
            GameObject hero = _gameFactory.CreateHero(GameObject.FindWithTag(Tags.InitialPoint));
            GameObject ghost = _gameFactory.CreateGhost(GameObject.FindWithTag(Tags.GhostInitialPoint));
            GameObject journal = _gameFactory.CreateJournal();
            _gameFactory.CreateJumpscare();
            ghost.GetComponent<GhostInfo>().SetUpGhost(hero.transform, hero.GetComponent<MoveControl>().GetPlayerHuntPoint(), _levelSetUp.CurrGhostRoom, hero.GetComponent<RoomIdentifire>(), hero.GetComponent<SanityHandler>(), _levelSetUp.CurrLevelSize);
            _levelSetUp.GhostInfo = ghost.GetComponent<GhostInfo>();
            _levelSetUp.MainPlayer = hero;
        }
    }
}