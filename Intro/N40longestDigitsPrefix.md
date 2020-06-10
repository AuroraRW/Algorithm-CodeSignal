### No.40 longestDigitsPrefix
Given a string, output its longest prefix which contains only digits.

Example

For inputString = "123aa1", the output should be
longestDigitsPrefix(inputString) = "123".

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string inputString

    Guaranteed constraints:
    3 ≤ inputString.length ≤ 100.

    [output] string
#### python
```python
def longestDigitsPrefix(inputString):
    for i in range(len(inputString)):
        if inputString[i].isdigit():
            pass
        else:
            return inputString[:i]
    return inputString
```
```python
def longestDigitsPrefix(inputString):
    return re.findall('^\d*',inputString)[0]
```