int count = 0;
double dist = 10000;
double FirstFrSpeed = 1;
double SecFrSpeed = 2;
double DogSpeed = 5;
int Friend = 2;
double time;
while (dist > 10)
{
    if (Friend == 1)
    {
        time = dist / (FirstFrSpeed + DogSpeed);
        Friend = 2;
    }
    else
    {
        time = dist / (SecFrSpeed + DogSpeed);
        Friend = 1;
    }
    dist = dist - (FirstFrSpeed + SecFrSpeed) * time;
    Console.WriteLine ("между друзьями отсалось " +Math.Round(dist,2)+" м.");
    count++;
} 
Console.WriteLine ("Собака пробежала между друзьями " + count + " раз");
