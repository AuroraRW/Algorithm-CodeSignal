### No.45 buildPalindrome
Given a string, find the shortest possible string which can be achieved by adding characters to the end of initial string to make it a palindrome.

Example

For st = "abcdc", the output should be
buildPalindrome(st) = "abcdcba".

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string st

    A string consisting of lowercase English letters.

    Guaranteed constraints:
    3 ≤ st.length ≤ 10.

    [output] string
#### python
```python
def isPalindrome(s):
    return s == s[::-1]

def buildPalindrome(st):
    palindrome = ''
    for i in range(len(st)):
        potentialPalindrome = st[i:]
        if(isPalindrome(potentialPalindrome)):
            palindrome = potentialPalindrome
            if (len(st) == len(palindrome)):
                return palindrome
            break
    return st + st[:i][::-1]
```
```python
def buildPalindrome(st):
    for i in range(0,len(st)):
        if(st[i:len(st)] == st[i:len(st)][::-1]):
            return st[0:i] + st[i:len(st)] + st[0:i][::-1]
```
