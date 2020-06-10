### No.51 deleteDigit
Given some integer, find the maximal number you can obtain by deleting exactly one digit of the given number.

Example

    For n = 152, the output should be
    deleteDigit(n) = 52;
    For n = 1001, the output should be
    deleteDigit(n) = 101.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] integer n

    Guaranteed constraints:
    10 ≤ n ≤ 106.

    [output] integer
#### python
```python
def deleteDigit(n):
    num = list(str(n))
    result = []
    maxnum=0
    for i in range(len(num)):
        result=''.join(num[0:i])
        result=result+''.join(num[i+1:])
        maxnum = max(maxnum, int(result))
    return maxnum
```
```python
def deleteDigit(n):
    n = str(n)
    return max(int(''.join(n[:i]+n[i+1:])) for i in range(len(n)))
```