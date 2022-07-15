using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class map_builder : MonoBehaviour
{
    public string selectedObject = "straight_accel";

    public int zRot;

    public Transform rotArrow;

    public Transform player;

    public TextMeshProUGUI xCord;
    public TextMeshProUGUI yCord;

    public GameObject map;

    public GameObject straight_accel;
    public GameObject T_accel;
    public GameObject inv_T_accel;
    public GameObject cur_accel;
    public GameObject inv_cur_accel;
    public GameObject updown_cur_accel;
    public GameObject inv_updown_cur_accel;
    public GameObject piston;
    public GameObject norman_block;
    public GameObject lever;
    public GameObject cable;
    public GameObject AND;
    public GameObject OR;
    public GameObject NOT;

    public void changeSelect(string newValue)
    {
        selectedObject = newValue;
    }

    void Update()
    {
        xCord.SetText("X: " + string.Format("{0:N2}", player.transform.position.x));
        yCord.SetText("Y: " + string.Format("{0:N2}", player.transform.position.y));

        if(Input.GetMouseButtonDown(1))
        {
            SpawnSelectedObject();
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            zRot = zRot + 5;
        }

        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            zRot = zRot - 5;
        }

        Vector3 nextPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
        rotArrow.transform.rotation = Quaternion.Euler(0, 0, zRot);
        rotArrow.transform.position = nextPos;
    }

    void SpawnSelectedObject()
    {
        if(selectedObject == "straight_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(straight_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            straight_accel.name = "straight_accel - " + Time.time;
        }

        if(selectedObject == "T_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(T_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            T_accel.name = "T_accel - " + Time.time;
        }

        if(selectedObject == "inv_T_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(inv_T_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            inv_T_accel.name = "inv_T_accel - " + Time.time;
        }

        if(selectedObject == "cur_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(cur_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            cur_accel.name = "cur_accel - " + Time.time;
        }

        if(selectedObject == "inv_cur_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(inv_cur_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            inv_cur_accel.name = "inv_cur_accel - " + Time.time;
        }

        if(selectedObject == "updown_cur_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(updown_cur_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            updown_cur_accel.name = "updown_cur_accel - " + Time.time;
        }

        if(selectedObject == "inv_updown_cur_accel")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 5) * 5, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 5) * 5, 0);

            Instantiate(inv_updown_cur_accel, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            inv_updown_cur_accel.name = "inv_updown_cur_accel - " + Time.time;
        }

        if(selectedObject == "piston")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 2) * 2, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 2) * 2, 0);

            Instantiate(piston, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            piston.name = "piston - " + Time.time;
        }

        if (selectedObject == "normal_block")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 2) * 2, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 2) * 2, 0);

            Instantiate(norman_block, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            norman_block.name = "normal_block - " + Time.time;
        }

        if (selectedObject == "lever")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 1) * 1, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 1) * 1, 0);

            Instantiate(lever, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            lever.name = "lever - " + Time.time;
        }

        if (selectedObject == "cable")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 1) * 1, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 1) * 1, 0);

            Instantiate(cable, mousePos, Quaternion.Euler(0, 0, zRot + 90));

            cable.name = "cable - " + Time.time;
        }

        if (selectedObject == "AND")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 1) * 1, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 1) * 1, 0);

            Instantiate(AND, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            AND.name = "AND - " + Time.time;
        }

        if (selectedObject == "OR")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 1) * 1, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 1) * 1, 0);

            Instantiate(OR, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            OR.name = "OR - " + Time.time;
        }

        if (selectedObject == "NOT")
        {
            Vector3 mousePos = new Vector3(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x / 1) * 1, Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y / 1) * 1, 0);

            Instantiate(NOT, mousePos, Quaternion.Euler(0, 0, zRot), map.transform);

            NOT.name = "NOT - " + Time.time;
        }
    }
}
