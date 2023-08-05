string[] arr_1 = new string[7] { "dog", "789", "cucumber", "47", "potato", "6588", "28" };
string[] arr_2 = new string[arr_1.Length];

void ArrayCut(string[] arr_1, string[] arr_2)
{
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++)
    {
        if (arr_1[i].Length <= 3)
        {
            arr_2[count] = arr_1[i];
            count++;
        }
    }
}

