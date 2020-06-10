### No.26 evenDigitsOnly
Check if all digits of the given integer are even.

Example

    For n = 248622, the output should be
    evenDigitsOnly(n) = true;
    For n = 642386, the output should be
    evenDigitsOnly(n) = false.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] integer n

    Guaranteed constraints:
    1 ≤ n ≤ 109.

    [output] boolean
        true if all digits of n are even, false otherwise.
#### python
```python
def evenDigitsOnly(n):
    for i in str(n):
        if int(i) % 2 != 0:
            return False
    return True
```