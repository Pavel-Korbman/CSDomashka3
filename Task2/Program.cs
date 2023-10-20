int[] pointA = {3, 6, 8};
int[] pointB = {2, 1, -7};
double Length(int[] pointA, int[] pointB)
{
double dist = Math.Round (Math.Sqrt(Math.Pow((pointB[0]-pointA[0]),2) + Math.Pow((pointB[1]-pointA[1]),2) + Math.Pow((pointB[2]-pointA[2]),2)), 2);
return dist;
}
Console.WriteLine (Length(pointA, pointB));