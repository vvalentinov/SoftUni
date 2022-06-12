class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(firstPoint, secondPoint) {
        return Math.sqrt(Math.abs(firstPoint.x - secondPoint.x) ** 2 + Math.abs(firstPoint.y - secondPoint.y) ** 2);
    }
}