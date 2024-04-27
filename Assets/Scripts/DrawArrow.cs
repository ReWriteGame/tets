﻿using UnityEditor;
using UnityEngine;


public static class DrawArrow
{
    public static void ForGizmo(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25f,
        float arrowHeadAngle = 20.0f)
    {
        Gizmos.DrawRay(pos, direction);

        if (direction.sqrMagnitude < 0.0001f)
            return;

        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) *
                        new Vector3(0, 0, 1);
        Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) *
                       new Vector3(0, 0, 1);
        Gizmos.DrawRay(pos + direction, right * arrowHeadLength);
        Gizmos.DrawRay(pos + direction, left * arrowHeadLength);
    }

    public static void HandlesArrow(Vector3 startPoint, Vector3 endPoint, bool useCenterLine = true,
        float centerThickness = 0, float arrowHeadThickness = 0, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
    {
        if (Vector3.Distance(startPoint,endPoint) < 0.0001f) return;
        Vector3 dir = endPoint - startPoint;
        Vector3 right = Quaternion.LookRotation(dir) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * Vector3.forward;
        Vector3 left = Quaternion.LookRotation(dir) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * Vector3.forward;

        if (useCenterLine) Handles.DrawLine(startPoint, endPoint, centerThickness);
        Handles.DrawLine(endPoint, endPoint + right * arrowHeadLength, arrowHeadThickness);
        Handles.DrawLine(endPoint, endPoint + left * arrowHeadLength, arrowHeadThickness);
    }


    public static void ForGizmo(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f,
        float arrowHeadAngle = 20.0f)
    {
        Gizmos.color = color;
        Gizmos.DrawRay(pos, direction);

        if (direction.sqrMagnitude < 0.0001f)
            return;

        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) *
                        new Vector3(0, 0, 1);
        Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) *
                       new Vector3(0, 0, 1);
        Gizmos.DrawRay(pos + direction, right * arrowHeadLength);
        Gizmos.DrawRay(pos + direction, left * arrowHeadLength);
    }

    public static void ForDebug(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25f,
        float arrowHeadAngle = 20.0f)
    {
        Debug.DrawRay(pos, direction);

        if (direction.sqrMagnitude < 0.0001f)
            return;

        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) *
                        new Vector3(0, 0, 1);
        Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) *
                       new Vector3(0, 0, 1);
        Debug.DrawRay(pos + direction, right * arrowHeadLength);
        Debug.DrawRay(pos + direction, left * arrowHeadLength);
    }

    public static void ForDebug(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f,
        float arrowHeadAngle = 20.0f)
    {
        Debug.DrawRay(pos, direction, color);

        if (direction.sqrMagnitude < 0.0001f)
            return;

        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) *
                        new Vector3(0, 0, 1);
        Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) *
                       new Vector3(0, 0, 1);
        Debug.DrawRay(pos + direction, right * arrowHeadLength, color);
        Debug.DrawRay(pos + direction, left * arrowHeadLength, color);
    }
}