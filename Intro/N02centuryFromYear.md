### No.02 centuryFromYear
Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.

Example

    For year = 1905, the output should be
    centuryFromYear(year) = 20;
    For year = 1700, the output should be
    centuryFromYear(year) = 17.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] integer year

    A positive integer, designating the year.

    Guaranteed constraints:
    1 ≤ year ≤ 2005.

    [output] integer
        The number of the century the year is in.  
#### python
```python
def centuryFromYear(year):
    return ((year - 1) // 100) + 1
```
```python
def centuryFromYear(year):
    return math.ceil(year/100)
```
#### CSharp
```csharp
int centuryFromYear(int year)
{
    return ((year - 1) / 100 + 1);
}
```
```csharp
int centuryFromYear1(int year)
{
    return Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(year) / 100));
}
```