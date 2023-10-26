using TMPro;
using UnityEngine;

public static class Inputs
{
    private static GameControls _actions;
    private static gameController _owner;


    public static void Init(gameController player)
    {
        _actions = new GameControls();

        _owner = player;

        _actions.Player.Move.performed += ctx => _owner.ButtonPressed();

        PlayMode();
    }

    private static void Attack_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    public static void PlayMode()
    {
        _actions.Player.Enable();
    }

}