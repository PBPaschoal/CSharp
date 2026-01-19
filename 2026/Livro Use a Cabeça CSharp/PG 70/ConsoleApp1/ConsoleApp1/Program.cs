int result = 0;
int x = 6;
while (x > 3) {
    result = result + x;
    x = x - 1;
}

for (int z = 1; z < 3; z = z + 1) {
    result = result + z;
}

Console.WriteLine("The result is " + result);
Console.ReadLine();