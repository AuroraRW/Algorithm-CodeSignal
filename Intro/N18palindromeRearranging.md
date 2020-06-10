### No.18 palindromeRearranging
Given a string, find out if its characters can be rearranged to form a palindrome.

Example

For inputString = "aabb", the output should be
palindromeRearranging(inputString) = true.

We can rearrange "aabb" to make "abba", which is a palindrome.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string inputString

    A string consisting of lowercase English letters.

    Guaranteed constraints:
    1 ≤ inputString.length ≤ 50.

    [output] boolean
        true if the characters of the inputString can be rearranged to form a palindrome, false otherwise.
#### python
```python
def palindromeRearranging(inputString):
    import collections
    c = list(collections.Counter(inputString).values())
    number = 0
    for i in c:
        if i % 2 == 1:
            number = number + 1
    if number <= 1:
        return True
    else:
        return False
```