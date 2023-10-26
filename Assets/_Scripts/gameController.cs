using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] gameSpaces;
    [SerializeField] private GameObject[] diseaseCubes;

    [SerializeField] private GameObject diseaseCubeFab;

    public int gameState;

    private void Awake()
    {
        Inputs.Init(this);
    }

    public void ButtonPressed()
    {
        switch(gameState)
        {
            case 0:
                DoTurn0();
                gameState++;
                break;
            case 1:
                DoTurn1();
                gameState++; 
                break;
            case 2:
                DoTurn2();
                gameState++;
                break;
            case 3:
                DoTurn3();
                gameState++;
                break;
            case 4:
                DoTurn4();
                gameState++;
                break;
            case 5:
                DoTurn5();
                gameState++;
                break;
            case 6:
                DoTurn6();
                gameState++;
                break;
            case 7:
                DoTurn7();
                gameState++;
                break;
            case 8:
                DoTurn8();
                gameState++;
                break;
        }
    }

    public void DoTurn0()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[0].transform.DOMove(gameSpaces[4].transform.position, 1f));
        
        sequence.Append(diseaseCubes[0].transform.DOScale(Vector3.zero, 0.5f));
        sequence.Append(diseaseCubes[1].transform.DOScale(Vector3.zero, 0.5f));
        sequence.Append(diseaseCubes[2].transform.DOScale(Vector3.zero, 0.5f));
        sequence.Append(diseaseCubes[4].transform.DOScale(0.5f, 0.5f));
        sequence.Append(diseaseCubes[5].transform.DOScale(0.5f, 0.5f));


        /*player.transform.DOMove(moveTo.transform.position, 1f)
            .onComplete(diseaseCube.transform.DOScale(Vector3.zero, 1)
            .onComplete(Destroy(diseaseCube));*/
    }

    public void DoTurn1()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[1].transform.DOMove(gameSpaces[6].transform.position, 1));
        sequence.Append(diseaseCubes[3].transform.DOScale(0.5f, 0.3f));

    }

    public void DoTurn2()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[0].transform.DOMove(gameSpaces[2].transform.position, 1f));
        sequence.Append(diseaseCubes[4].transform.DOScale(0, 0.5f));
    }
    public void DoTurn3()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[1].transform.DOMove(gameSpaces[5].transform.position, 1f));
        sequence.Append(diseaseCubes[6].transform.DOScale(0.5f, 0.3f));
    }

    public void DoTurn4()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[0].transform.DOMove(gameSpaces[0].transform.position, 1f));
        sequence.Append(diseaseCubes[6].transform.DOScale(0, 0.3f));
    }
    public void DoTurn5()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[1].transform.DOMove(gameSpaces[6].transform.position, 1f));
        sequence.Append(diseaseCubes[7].transform.DOScale(0.5f, 0.3f));
        sequence.Append(diseaseCubes[8].transform.DOScale(0.5f, 0.3f));
    }
    public void DoTurn6()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[0].transform.DOMove(gameSpaces[5].transform.position, 1f));
        sequence.Append(diseaseCubes[8].transform.DOScale(0, 0.5f));
        
    }

    public void DoTurn7()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(diseaseCubes[8].transform.DOScale(0.5f, 0.3f));
        sequence.Append(players[1].transform.DOMove(gameSpaces[7].transform.position, 1f));
        sequence.Append(diseaseCubes[9].transform.DOScale(0.5f, 0.3f));

    }
    public void DoTurn8()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(players[0].transform.DOMove(gameSpaces[6].transform.position, 1f));
        sequence.Append(diseaseCubes[3].transform.DOScale(0, 0.3f));
        sequence.Append(diseaseCubes[5].transform.DOScale(0, 0.3f));
        sequence.Append(diseaseCubes[7].transform.DOScale(0, 0.3f));
        sequence.Append(diseaseCubes[8].transform.DOScale(0, 0.3f));
    }
}
