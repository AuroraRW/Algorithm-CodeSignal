### No.35 firstDigit
Find the leftmost digit that occurs in a given string.

Example

    For inputString = "var_1__Int", the output should be
    firstDigit(inputString) = '1';
    For inputString = "q2q-q", the output should be
    firstDigit(inputString) = '2';
    For inputString = "0ss", the output should be
    firstDigit(inputString) = '0'.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string inputString

    A string containing at least one digit.

    Guaranteed constraints:
    3 ≤ inputString.length ≤ 10.

    [output] char
#### python
```python
def firstDigit(inputString):
    digit = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'}
    for i in inputString:
        if i in digit:
            return i
```
```python
def firstDigit(inputString):
    for i in inputString:
        if i.isdigit():
            return i
```
```python
def firstDigit(inputString):
    return re.findall('\d', inputString)[0]
```
```python
def firstDigit(s):
    for i in s:
        try:
            x=int(i)
            return i
        except:
            continue
```