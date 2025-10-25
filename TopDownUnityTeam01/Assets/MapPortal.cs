using Unity.Cinemachine;
using UnityEngine;

public class MapPortal : MonoBehaviour
{
    // 1) Cinemachine Confiner2D의 BoundingShape A안에 BoxCollider2D를 B의 BoxCllider2r2D로 바꾸어야 한다.

    // 2) 플레이어의 캐릭터를 원하는 지점으로 이동해야 한다.

    // 3) Entry의 충돌 지점에 닿았을 때
    public Transform movePosition;
    public Collider2D mapBoundary;          // MapPortal 플레이어가 닿았을 때 이동해야 할 카메라 경계를 넣어주세요.
    public CinemachineConfiner2D Confiner;  // CinemachineConfiner2D 데이터를 저장할 수 있는 상자. 데이터가 들어 있지 않다.
    public Animator SceneTransitionAnimator;// 방금 만들었던 씬 전환 애니메이터를 여기에 저장하세요
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // Tag가 플레이어인 녀석일 때만 실행를 하라
        {
            Confiner.BoundingShape2D = mapBoundary;

            collision.transform.position = movePosition.position;

            SceneTransitionAnimator.SetTrigger("Show");
        }
    }

}
