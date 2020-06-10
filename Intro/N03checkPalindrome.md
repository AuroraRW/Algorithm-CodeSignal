### No.03 checkPalindrome
Given the string, check if it is a palindrome.

Example

    For inputString = "aabaa", the output should be
    checkPalindrome(inputString) = true;
    For inputString = "abac", the output should be
    checkPalindrome(inputString) = false;
    For inputString = "a", the output should be
    checkPalindrome(inputString) = true.

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string inputString

    A non-empty string consisting of lowercase characters.

    Guaranteed constraints:
    1 ≤ inputString.length ≤ 105.

    [output] boolean
        true if inputString is a palindrome, false otherwise.  
#### python
```python
# convert string to list, then use reverse() function
def checkPalindrome(inputString):
    temp = list(inputString)
    temp.reverse()
    outputString = ''.join(temp)
    if inputString == outputString:
        return True
    else:
        return False
```
```python
# use ~
def checkPalindrome(inputString):
    for i in range(len(inputString)):
        if inputString[i] != inputString[~i]:
            return False
    return True
```
```python
# use reversed() function
def checkPalindrome(inputString):
    return inputString== ''.join(reversed(inputString))
```
```python
def checkPalindrome(inputString):
    return inputString== inputString[::-1]
```
#### CSharp
```csharp
bool checkPalindrome(string inputString)
{
    string result = new string(inputString.Reverse().ToArray());
    return (inputString == result);
}
```
```csharp
bool checkPalindrome1(string myString)
{
    return (myString.SequenceEqual(myString.Reverse()));
}
```
