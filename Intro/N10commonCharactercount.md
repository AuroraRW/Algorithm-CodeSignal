### No.10 Common Character Count
Given two strings, find the number of common characters between them.

Example

For s1 = "aabcc" and s2 = "adcaa", the output should be
commonCharacterCount(s1, s2) = 3.

Strings have 3 common characters - 2 "a"s and 1 "c".

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string s1

    A string consisting of lowercase English letters.

    Guaranteed constraints:
    1 ≤ s1.length < 15.

    [input] string s2

    A string consisting of lowercase English letters.

    Guaranteed constraints:
    1 ≤ s2.length < 15.

    [output] integer
#### python
```python
def commonCharacterCount(s1, s2):
    count = 0
    list_1 = list(s1)
    list_2 = list(s2)
    for i in range(len(list_1)):
        for j in range(len(list_2)):
            if list_1[i] != -1 and list_2[j] != -1:
                if list_1[i] == list_2[j]:
                    count = count + 1
                    list_1[i] = -1
                    list_2[j] = -1
    return count
```
```python
def commonCharacterCount(s1, s2):
    return sum(min(s1.count(i), s2.count(i)) for i in set(s1))
```