### No.34 extractEachKth
Given array of integers, remove each kth element from it.

Example

For inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, the output should be
extractEachKth(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.integer inputArray

    Guaranteed constraints:
    5 ≤ inputArray.length ≤ 15,
    -20 ≤ inputArray[i] ≤ 20.

    [input] integer k

    Guaranteed constraints:
    1 ≤ k ≤ 10.

    [output] array.integer
        inputArray without elements k - 1, 2k - 1, 3k - 1 etc.
#### python
```python
def extractEachKth(inputArray, k):
    result = []
    t = 1
    for i in range(1, len(inputArray) + 1):
        if i != t * k:
            result.append(inputArray[i - 1])
        else:
            t = t + 1
    return result
```
```python
def extractEachKth(inputArray, k):
    del inputArray[k-1::k]
    return inputArray
```
```python
def extractEachKth(inputArray, k):
    return [i for (n,i) in enumerate(inputArray) if (n+1) % k != 0]
```