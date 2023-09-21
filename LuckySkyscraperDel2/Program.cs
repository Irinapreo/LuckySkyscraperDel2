// 1 2 3 4 5 6 7 8  9 10 11 12 13 14 15 16 17 18 19 20 21
// 1 2 3 5 6 7 8 9 10 11 12 15 16 17 18 19 20 21 22 23 25
//print number from 1 to x 
//skip every number ending with 4 or 13 and continue

var i = 1;

while (i != 116)
{
    if (i % 10 != 4 && i % 100 != 13)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
}


var i = 24;
var r = i;
var counter = 0;

while (i >= counter)
{
    if (counter % 10 == 4 || counter % 100 == 13)
    {
        r = r + 1;
    }
    counter = counter + 1;
}
Console.WriteLine(r);


