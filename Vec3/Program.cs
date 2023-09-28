//Разработать структуру Vec3 соответствующую трехмерному вектору
//Реализовать возможность:
//-получение длинны вектор
//-сложение векторов
//-умножение векторов на число
//-скалярное произведение векторов 
//-векторное произведени
//-сравнение векторов
//-сонаправленность векторов
using System;

class Program
{
    static void Main(string[] args)
    {
        Vec3 vector1 = new Vec3(1, 2, 7);
        Vec3 vector2 = new Vec3(1, 2, 7);

        double length = vector1.Length();
        Vec3 sum = vector1 + vector2;
        Vec3 scaled = vector1 * 2.0;
        double dotProduct = Vec3.Dot(vector1, vector2);
        Vec3 crossProduct = Vec3.Cross(vector1, vector2);
        bool areEqual = (vector1 == vector2);
        bool areParallel = vector1.IsParallel(vector2);

        Console.WriteLine($"Длинна вектора 1: {length}");
        Console.WriteLine($"Сумма векторов: ({sum.X}, {sum.Y}, {sum.Z})");
        Console.WriteLine($"Масштабированный вектор: ({scaled.X}, {scaled.Y}, {scaled.Z})");
        Console.WriteLine($"Точечное произведение вектора: {dotProduct}");
        Console.WriteLine($"Перекрестное произведение векторов: ({crossProduct.X}, {crossProduct.Y}, {crossProduct.Z})");
        Console.WriteLine($"Равны ли векторы: {areEqual}");
        Console.WriteLine($"Паралельны ли векторы : {areParallel}");
    }
}
