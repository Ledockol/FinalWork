string[] arrayFirst = new string[5] {":-)", "-2", "hello", "world", "Rus"};
string[] arraySecond = new string[arrayFirst.Length];
int count = 0;
for (int i = 0; i < arrayFirst.Length; i++)
{
    if(arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
            count++;
            Console.Write(arrayFirst[i] + " ");
        }
}