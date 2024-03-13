using UnityEngine;

public class ObjectSwapper : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
   [SerializeField] private GameObject selectedObject;
    private void Start()
    {
        offset=transform.position ;
        selectedObject.transform.position = transform.position;
    }
    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10));
            selectedObject.transform.position = new Vector3(mousePos.x + offset.x, mousePos.y + offset.y, selectedObject.transform.position.z);
        }
    }

    void OnMouseDown()
    {
        if (!isDragging)
        {
            selectedObject = gameObject;
            offset = selectedObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isDragging = true;
        }
    }

    void OnMouseUp()
    {
        if (isDragging)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject != selectedObject)
            {
                // Swap positions
                Vector3 tempPos = selectedObject.transform.position;
                selectedObject.transform.position = hit.collider.gameObject.transform.position;
                hit.collider.gameObject.transform.position = tempPos;
                isDragging = false;

            }

            //isDragging = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EmptySpace"))
        {
            offset = collision.gameObject.transform.position;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject != selectedObject)
            {
                // Swap positions
                //Vector3 tempPos = selectedObject.transform.position;
                //selectedObject.transform.position = hit.collider.gameObject.transform.position;
                //hit.collider.gameObject.transform.position = tempPos;
                isDragging = true;
                //Transform COLLIDERTRANS = hit.collider.gameObject.transform;
                //Vector3 tempPos = COLLIDERTRANS.GetComponent<ObjectSwapper>().selectedObject.transform.position;
                //selectedObject.transform.position = hit.collider.gameObject.GetComponent<ObjectSwapper>().offset;
                //hit.collider.gameObject.transform.position = COLLIDERTRANS.position;
            }

            //isDragging = false;
            Debug.Log("hittref");
        }
    }
}
