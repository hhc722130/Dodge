using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;
    private bool isRotating = false; // 회전 상태 저장

    public GameObject bulletPrefad; // 총알 프리팹

    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
        childTransform.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    
    }
    void Update()
    {
        // 마우스 좌클릭 시 회전 상태 토글
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = !isRotating;
        }

        // 회전 상태일 때 제자리에서 계속 회전
        if (isRotating)
        {
            childTransform.Rotate(new Vector3(0, 100000, 0) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 30, 0) * Time.deltaTime); // Move up when up arrow is pressed
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -30, 0) * Time.deltaTime); // Move up when space is pressed
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -360) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 fireDir = (childTransform.position - transform.position).normalized;
            GameObject bullet = Instantiate(bulletPrefad, childTransform.position, Quaternion.LookRotation(fireDir));

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = fireDir * 8f;
            }
        }
        
    }
}
