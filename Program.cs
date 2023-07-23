//исходные данные
int []arrow={0,1,2,3,4,5};
int size=arrow.Length;
int index=0;
int t1=0;
int t2=size/2;

//вывод на печать исходного массива
var str=string.Join(" ",arrow);
Console.WriteLine(str);

//блок операций
if (size%2==0)
{
    while(index<size/2)
    {
        t1=arrow[size-index-1];
        arrow[size-index-1]=arrow[index];
        arrow[index]=t1;
        index++;
    }
}
else
{
    while(index<t2)
    {
        t1=arrow[size-index-1];
        arrow[size-index-1]=arrow[index];
        arrow[index]=t1;
        index++;
    }
}

//вывод на печать преобразованного массива
var str2=string.Join(" ",arrow);
Console.WriteLine(str2);