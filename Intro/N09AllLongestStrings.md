### All Longest String
Given an array of strings, return another array containing all of its longest strings.

Example

For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
allLongestStrings(inputArray) = ["aba", "vcd", "aba"].

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.string inputArray

    A non-empty array.

    Guaranteed constraints:
    1 ≤ inputArray.length ≤ 10,
    1 ≤ inputArray[i].length ≤ 10.

    [output] array.string
        Array of the longest strings, stored in the same order as in the inputArray.
#### python
```python
def allLongestStrings(inputArray):
    Max = 0
    for i in range(len(inputArray)):
        if len(inputArray[i]) >= Max:
            Max = len(inputArray[i])
    outputArray = []
    for string in inputArray:
        if len(string) == Max:
            outputArray.append(string)
    return outputArray
```
```python
def allLongestStrings(inputArray):  
    return [i for i in inputArray if len(i) == max(map(len, inputArray))]
```
```python
def allLongestStrings(inputArray):
    longest = 0
    res = []
    for s in inputArray:
        if len(s) == longest:
            res.append(s)
        if len(s) > longest:
            longest = len(s)
            res = [s]
    return res
```
#### CSharp
```csharp

```