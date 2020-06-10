### No.12 Sort by Height
Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task is to rearrange the people by their heights in a non-descending order without moving the trees. People can be very tall!

Example

For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] array.integer a

    If a[i] = -1, then the ith position is occupied by a tree. Otherwise a[i] is the height of a person standing in the ith position.

    Guaranteed constraints:
    1 ≤ a.length ≤ 1000,
    -1 ≤ a[i] ≤ 1000.

    [output] array.integer
        Sorted array a with all the trees untouched.
#### python
```python
def sortByHeight(a):
    aa = []
    for i in a:
        if i != -1:
            aa.append(i)
    for i in range(1, len(aa)):
        for j in range(0, len(aa) - i):
            if aa[j] > aa[j + 1]:
                aa[j], aa[j + 1] = aa[j + 1], aa[j]
    j = 0
    for i in range(len(a)):
        if a[i] != -1:
            a[i] = aa[j]
            j = j + 1
    
    return a
```
```python
def sortByHeight(a):
    SortedList = sorted([i for i in a if i > 0])
    print(SortedList)
    for i, v in enumerate(a):
        if v == -1:
            SortedList.insert(i, v)
    return SortedList
```