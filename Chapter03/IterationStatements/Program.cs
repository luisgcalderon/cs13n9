#region while loop
int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}
#endregion

#region Looping with for statement
for (int y = 1; y<=10; y++)
{
    WriteLine(y);
}
#endregion


#region  for with different increments
for (int y = 0; y<=10; y+= 3)
{
    WriteLine(y);
}
#endregion

#region Loop for string[]
string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
#endregion