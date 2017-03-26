using UnityEngine;
using System.Collections.Generic;
using Assets.Scripts;

class PointPath {

    private List<Vector2> points;

    private float minDistance;

    private float maxDistance;

    private Vector2 minDirection;

    private Vector2 maxDirection;

    public PointPath(Vector2 minDirection, Vector2 maxDirection, float minDistance, float maxDistance) {
        this.points = new List<Vector2>();
        this.minDirection = minDirection;
        this.maxDirection = maxDirection;
        this.minDistance = minDistance;
        this.maxDistance = maxDistance;
    }

    public List<Vector2> getPoints() {
        return this.points;
    }

    public void addPoint(Vector2 point) {
        if(point != null) {
            this.points.Add(point);
        }
    }

    public void addPoint(Vector2 direction, float distance) {
        Vector2 lastPoint = points[points.Count - 1];
        Vector2 newPoint = lastPoint + (direction.normalized * distance);
        this.points.Add(newPoint);
    }

    public void addPoints(List<Vector2> points) {
        if(points != null) {
            this.points.AddRange(points);
        }
    }

    public void addRandomPoints(int numPoints) {
        for(int i = 0; i < numPoints; i++) {
            this.addRandomPoint();
        }
    }

    public void addRandomPoint() {
        this.addRandomPoint(this.minDirection, this.maxDirection, this.minDistance, this.maxDistance);
    }

    public void addRandomPoint(Vector2 minDirection, Vector2 maxDirection) {
        this.addRandomPoint(minDirection, maxDirection, this.minDistance, this.maxDistance);
    }

    public void addRandomPoint(float distance) {
        this.addRandomPoint(this.minDirection, this.maxDirection, distance);
    }

    public void addRandomPoint(Vector2 minDirection, Vector2 maxDirection, float distance) {
        Vector2 randomDirection = getRandomDirection(minDirection, maxDirection);
        addPoint(randomDirection, distance);
    }

    public void addRandomPoint(Vector2 minDirection, Vector2 maxDirection, float minDistance, float maxDistance) {
        float randomDistance = Random.Range(minDistance, maxDistance);
        Vector2 randomDirection = getRandomDirection(minDirection, maxDirection);
        addPoint(randomDirection, randomDistance);
    }

    private static Vector2 getRandomDirection(Vector2 minDirection, Vector2 maxDirection) {
        float minAngle = Vector2.Angle(Vector2.right, minDirection.normalized) * Mathf.Deg2Rad;
        float maxAngle = Vector2.Angle(Vector2.right, maxDirection.normalized) * Mathf.Deg2Rad;
        float randomAngle = Random.Range(minAngle, maxAngle);

        return new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle));
    }
}
