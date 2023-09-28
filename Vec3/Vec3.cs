using System;
using System.Diagnostics.CodeAnalysis;

struct Vec3
{
    
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Z { get; private set; }

    public Vec3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Получение длины вектора
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    // Сложение векторов
    public static Vec3 operator +(Vec3 v1, Vec3 v2)
    {
        return new Vec3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    // Умножение вектора на число
    public static Vec3 operator *(Vec3 v, double scalar)
    {
        return new Vec3(v.X * scalar, v.Y * scalar, v.Z * scalar);
    }

    // Скалярное произведение векторов
    public static double Dot(Vec3 v1, Vec3 v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
    }

    // Векторное произведение векторов
    public static Vec3 Cross(Vec3 v1, Vec3 v2)
    {
        return new Vec3(
            v1.Y * v2.Z - v1.Z * v2.Y,
            v1.Z * v2.X - v1.X * v2.Z,
            v1.X * v2.Y - v1.Y * v2.X
        );
    }

    // Сравнение векторов
    public static bool operator ==(Vec3 v1, Vec3 v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    public static bool operator !=(Vec3 v1, Vec3 v2)
    {
        return !(v1 == v2);
    }

    public override  bool Equals (Object obj)
    {
        if (!(obj is Vec3))
            return false;

        Vec3 other = (Vec3)obj;
        return this == other;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
    }
    
    // Проверка сонаправленности векторов
    public bool IsParallel(Vec3 other)
    {
        // Векторы считаются сонаправленными, если их векторное произведение равно нулю
        return Cross(this, other) == new Vec3(0, 0, 0);
    }
}