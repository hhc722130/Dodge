using UnityEngine;

public class Rotator : MonoBehaviour {
    [Header("회전 설정")]
    public float rotationSpeed = 60f; // 회전 속도 (도/초)
    public bool clockwise = true; // true: 시계방향, false: 반시계방향
    
    void Update()
    {
        // 회전 방향 결정 (시계방향이면 양수, 반시계방향이면 음수)
        float direction = clockwise ? 1f : -1f;
        float actualSpeed = rotationSpeed * direction * Time.deltaTime;
        
        // Y축으로만 회전
        transform.Rotate(0f, actualSpeed, 0f);
    }
}