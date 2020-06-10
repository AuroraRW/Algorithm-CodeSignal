### No.11 Is Lucky
Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.

Given a ticket number n, determine if it's lucky or not.

Example

    For n = 1230, the output should be
    isLucky(n) = true;
    For n = 239017, the output should be
    isLucky(n) = false.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] integer n

    A ticket number represented as a positive integer with an even number of digits.

    Guaranteed constraints:
    10 ≤ n < 106.

    [output] boolean
        true if n is a lucky ticket number, false otherwise.
#### python
```python
def isLucky(n):
    number = str(n)
    sum_1 = 0
    sum_2 = 0
    for i in range(len(number) // 2):
        sum_1 = sum_1 + int(number[i])
    for i in range(len(number) // 2, len(number)):
        sum_2 = sum_2 + int(number[i])
    if sum_1 == sum_2:
        return True
    else:
        return False
```
```python
def isLucky(n):
    number = str(n)
    if sum(int(i) for i in number[:len(number) // 2]) == sum(int(i) for i in number[len(number) // 2:]):
        return True
    return False
```
```python
def isLucky(n):
    return sum(map(int, str(n)[:len(str(n)) // 2])) == sum(map(int, str(n)[len(str(n)) // 2:]))
```