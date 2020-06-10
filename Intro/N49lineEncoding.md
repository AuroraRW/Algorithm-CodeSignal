### No.49 lineEncoding
Given a string, return its encoding defined as follows:

    First, the string is divided into the least possible number of disjoint substrings consisting of identical characters
        for example, "aabbbc" is divided into ["aa", "bbb", "c"]
    Next, each substring with length greater than one is replaced with a concatenation of its length and the repeating character
        for example, substring "bbb" is replaced by "3b"
    Finally, all the new strings are concatenated together in the same order and a new string is returned.

Example

For s = "aabbbc", the output should be
lineEncoding(s) = "2a3bc".

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string s

    String consisting of lowercase English letters.

    Guaranteed constraints:
    4 ≤ s.length ≤ 15.

    [output] string
        Encoded version of s.
#### python
```python
def lineEncoding(s):
    start = 0
    StringToList = []
    result = ''
    for i in range(len(s)-1):
        if ord(s[i]) - ord(s[i + 1]) != 0:
            StringToList.append(s[start: i + 1])
            start = i + 1
    StringToList.append(s[start:])
    for i in StringToList:
        if len(i) == 1:
            result = result +i[0]
        else:    
            result = result + str(len(i))+i[0]
        
    return result
```
```python
from itertools import groupby
def lineEncoding(s):
    x = ''
    for k,g in groupby(s):
        y = len((list(g)))
        if y==1:
            x += k
        else:
            x += str(y) + k
    return x
```