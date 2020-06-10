### No.27 variableName
Correct variable names consist only of English letters, digits and underscores and they can't start with a digit.

Check if the given string is a correct variable name.

Example

    For name = "var_1__Int", the output should be
    variableName(name) = true;
    For name = "qq-q", the output should be
    variableName(name) = false;
    For name = "2w2", the output should be
    variableName(name) = false.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string name

    Guaranteed constraints:
    1 ≤ name.length ≤ 10.

    [output] boolean
        true if name is a correct variable name, false otherwise.
#### python
```python
def variableName(name):
    if 48 <= ord(name[0]) and ord(name[0]) <= 57:
        return False
    else:
        for i in name:
            if 48 <= ord(i) and ord(i) <= 57:
                pass
            elif 97 <= ord(i) and ord(i) <= 122:
                pass
            elif 65 <= ord(i) and ord(i) <= 90:
                pass
            elif i == '_':
                pass
            else:
                return False

    return True
# int(s) does not work if s is char
```