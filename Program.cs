//int Max(int arg1, int arg2, int arg3)
//{
  //  int result = arg1;
    //if(arg2 > result) result = arg2;
    //if(arg3 > result) result = arg3;
    //return result;
//}             0   1    2   3   4  5   6    7  8
//int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
//array[0] = 12;
//Console.WriteLine(array[4]);

//int max = Max(
  //  Max(array[0], array[1], array[2]),
    // Max(array[3],array[4], array[5]),
    //Max(array[6], array[7], array[8])
//);
//Console.WriteLine(max);


//int a1 = 112125;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 2311;
//int c2 = 33;
//int a3 = 13;
//int b3 = 23111;
//int c3 = 313;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

//int max = Max(
  //  Max(a1, b1, c1),
    //Max(a2, b2, c2),
    //Max(a3, b3, c3));

//Console.WriteLine(max);

//void FillArray(int[] collection)
//{
  //  int length = collection.Length;
    //int index = 0;
    //while (index < length)
    //{
      //  collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        //index++;
    //}
//}

//void PrintArray(int [] col)
//{
  //  int count = col.Length;
    //int position = 0;
    //while (position < count)
    //{
      //  Console.WriteLine(col[position]);
        //position++;
    //}
//}

//int IndexofO(int[] collection, int find)
//{
  //  int count = collection.Length;
    //int index = 0;
    //int position = 0;
    //while(index < count)
    //{
      //  if(collection[index] == find)
       // {
         //   position = index;
           // break;
        //}
        //index++;
    //}
    //return position;
//}
//int [] array = new int[10];

//FillArray(array);
//PrintArray(array);
//Console.WriteLine();

//int pos = IndexofO(array, 4);
//Console.WriteLine(pos);