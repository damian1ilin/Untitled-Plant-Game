using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    private Grid m_grid;

    [SerializeField] private Tilemap m_uiTilemap = null;
    [SerializeField] private Tilemap m_interactableTilemap = null;
    [SerializeField] private Tile hoverTile = null;

    private Vector3Int previousMousePos = new Vector3Int();

    private void Start()
    {
        m_grid = GetComponent<Grid>();
    }

    void Update()
    {
        getTileFromMousePos();
        InputManagement();
    }


    private void InputManagement()
    {
        // Left Mouse Button
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 pos = m_grid.CellToWorld(GetMousePosition());
            PlantManager.Instance.setPlant(new Vector3(pos.x + 0.08f, pos.y + 0.08f), PlantManager.Instance.m_testPlant);
        }
    }

    private void getTileFromMousePos()
    {
        Vector3Int mousePos = GetMousePosition();

        if (!mousePos.Equals(previousMousePos))
        {
            m_uiTilemap.SetTile(previousMousePos, null);
            m_uiTilemap.SetTile(mousePos, hoverTile);
            previousMousePos = mousePos;
        }
    }

    Vector3Int GetMousePosition()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return m_grid.WorldToCell(mouseWorldPos);
    }
}
